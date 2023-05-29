using System;
using System.Collections;
using System.Diagnostics.Metrics;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        private FileStream fs;
        private string selectedPath;
        private byte[][] rus;
        private byte[][] eng;
        public Form1()
        {
            rus = File.ReadAllText("./rus.txt").Split("\n").Select(x => Encoding.Default.GetBytes(x)).ToArray();
            eng = File.ReadAllText("./eng.txt").Split("\n").Select(x => Encoding.Default.GetBytes(x)).ToArray();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (fileNameTextBox.Text != "")
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = folderBrowserDialog1.SelectedPath + @"\" + fileNameTextBox.Text + ".txt";
                    fs = new FileStream(selectedPath, FileMode.OpenOrCreate);
                    fs.Close();
                    outputInTheLabel();
                }
            }
        }

        private void writeInTheFile_Click(object sender, EventArgs e)
        {
            byte[] buffer1 = readTheFile(selectedPath);

            writeInTheFileFunc(selectedPath, inputTextBox.Text, buffer1);
           
            outputInTheLabel();
        }


        private void outputInTheLabel() //метод выполн€ющий третий пункт задани€, не вижу смысла выносить на отдельную кнопку 
        {
            outputLabel.Text = "";
            byte[] buffer = readTheFile(selectedPath);
            outputLabel.Text = Encoding.Default.GetString(buffer);
        }

        private void numberOfLinesButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            using (FileStream fs = File.OpenRead(selectedPath))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                for (int i = 0; i < buffer.Length; i++)
                    if (buffer[i] == '\n')
                        counter += 1;
                if (buffer[buffer.Length - 1] != '\n')
                    counter += 1;
            }
            informationLabel.Text = counter.ToString() + " - количество строк в текстовом файле.";
        }

        private void numberOfCharacterRepetitionsButton_Click(object sender, EventArgs e) //алгоритм "в лоб"
        {
            byte[] wordBuffer = Encoding.Default.GetBytes(characterOrWordToCheckTextBox.Text);
            byte[] buffer = readTheFile(selectedPath);

            
            informationLabel.Text = getCount(buffer,wordBuffer).ToString() + " - количество повторений символа/слова в текстовом файле.";
        }

        int getCount(byte[]buffer, byte[] wordBuffer)
        {
            int counter = 0;
            bool flag;
            for (int i = 0; i < buffer.Length - wordBuffer.Length + 1; i++)
            {
                flag = true;
                for (int j = 0; j < wordBuffer.Length; j++)
                    if (buffer[i + j] != wordBuffer[j])
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    counter += 1;
            }
            return counter;
        }
        private void replaceAll(ref byte[] buffer, byte[] wordBuffer, byte[] replace)
        {
            if (wordBuffer.Length <= 0) return;
            int rc = getCount(buffer, wordBuffer);
            if (rc == 0) return;
            if (replace.Length > wordBuffer.Length)
            {
                rc = rc * (replace.Length - wordBuffer.Length);
            }
            else
            {
                rc = 0;
            }


            byte[] buf = new byte[buffer.Length + rc];
            uint w = 0;
            for (uint i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == wordBuffer[0])
                {
                    bool flag = true;
                    for (uint k = 1; k < wordBuffer.Length; k++)
                    {
                        if (buffer[i + k] != wordBuffer[k])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        for (uint k = 0; k < replace.Length; k++)
                        {
                            buf[w + k] = replace[k];
                        }
                        w += (uint)replace.Length;
                        i += (uint)wordBuffer.Length - 1;
                    }
                    else
                    {
                        buf[w] = buffer[i];
                        w++;
                    }
                }
                else
                {
                    buf[w] = buffer[i];
                    w++;
                }
            }
            buffer = buf;
        }
        private void replaceButton_Click(object sender, EventArgs e)
        {
            byte[] buffer = readTheFile(selectedPath);
            byte[] wordBuffer = Encoding.Default.GetBytes(characterOrWordToCheckTextBox.Text);
            byte[] replace = Encoding.Default.GetBytes(toReplaceTextBox.Text);
            replaceAll(ref buffer, wordBuffer, replace);

            writeInTheFileFunc(selectedPath, "", buffer);

            outputInTheLabel();
        }

        private byte[] readTheFile(string selectedPath)
        {
            byte[] buffer;
            using (FileStream fs = File.OpenRead(selectedPath))
            {
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        private void writeInTheFileFunc(string selectedPath, string inputText, byte[] readedBuffer)
        {
            using (FileStream fs = new FileStream(selectedPath, FileMode.Open))
            {
                byte[] buffer2 = Encoding.Default.GetBytes(inputText);
                byte[] resultBuffer = new byte[readedBuffer.Length + buffer2.Length];

                for (int i = 0; i < resultBuffer.Length; i++)
                    if (i < readedBuffer.Length && readedBuffer.Length != 0)
                        resultBuffer[i] = readedBuffer[i];
                    else
                        resultBuffer[i] = buffer2[i - readedBuffer.Length];
                fs.Write(resultBuffer, 0, resultBuffer.Length);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ToRegister(bool Upper, ref byte[]buffer)
        {
            for(uint i = 0; i<buffer.Length; i++)
            {
                if (Upper)
                {
                    if (buffer[i] >= (byte)'a' && buffer[i] <= (byte)'z')
                    {
                        buffer[i] = (byte)(((byte)'A') + (buffer[i] - ((byte)'a')));
                    }
                }
                else
                {
                    if (buffer[i] >= (byte)'A' && buffer[i] <= (byte)'Z')
                    {
                        buffer[i] = (byte)(((byte)'a') + (buffer[i] - ((byte)'A')));
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffer = readTheFile(selectedPath);
            if (checkBox1.Checked)
            {
                byte[] wordBuffer = Encoding.Default.GetBytes(characterOrWordToCheckTextBox.Text);
                byte[] replace = (byte[])wordBuffer.Clone();
                ToRegister(true, ref replace);
                replaceAll(ref buffer, wordBuffer, replace);
            }
            else
                ToRegister(true, ref buffer);
            writeInTheFileFunc(selectedPath, "", buffer);
            outputInTheLabel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = readTheFile(selectedPath);
            if (checkBox1.Checked)
            {
                byte[] wordBuffer = Encoding.Default.GetBytes(characterOrWordToCheckTextBox.Text);
                byte[] replace = (byte[])wordBuffer.Clone();
                ToRegister(false, ref replace);
                replaceAll(ref buffer, wordBuffer, replace);
            }
            else
                ToRegister(false, ref buffer);
            writeInTheFileFunc(selectedPath, "", buffer);
            outputInTheLabel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] buffer = readTheFile(selectedPath);
            for (uint i = 0; i<rus.Length;i++)
            {
                replaceAll(ref buffer, rus[i], eng[i]);
            }
            writeInTheFileFunc(selectedPath, "", buffer);
            outputInTheLabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] buffer = readTheFile(selectedPath);
            for (uint i = 0; i < rus.Length; i++)
            {
                replaceAll(ref buffer, eng[i], rus[i]);
            }
            writeInTheFileFunc(selectedPath, "", buffer);
            outputInTheLabel();
        }
    }
}