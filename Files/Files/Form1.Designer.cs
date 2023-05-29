namespace Files
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.writeInTheFile = new System.Windows.Forms.Button();
            this.numberOfLinesButton = new System.Windows.Forms.Button();
            this.informationLabel = new System.Windows.Forms.Label();
            this.characterOrWordToCheckTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCharacterRepetitionsButton = new System.Windows.Forms.Button();
            this.toReplaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 55);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(368, 35);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Создать/открыть файл";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 13);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fileNameTextBox.Multiline = true;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.PlaceholderText = "Название файла";
            this.fileNameTextBox.Size = new System.Drawing.Size(368, 34);
            this.fileNameTextBox.TabIndex = 1;
            this.fileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputLabel.Location = new System.Drawing.Point(390, 9);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(390, 543);
            this.outputLabel.TabIndex = 2;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 97);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(370, 405);
            this.inputTextBox.TabIndex = 4;
            // 
            // writeInTheFile
            // 
            this.writeInTheFile.Location = new System.Drawing.Point(12, 508);
            this.writeInTheFile.Name = "writeInTheFile";
            this.writeInTheFile.Size = new System.Drawing.Size(370, 41);
            this.writeInTheFile.TabIndex = 5;
            this.writeInTheFile.Text = "Записать в файл";
            this.writeInTheFile.UseVisualStyleBackColor = true;
            this.writeInTheFile.Click += new System.EventHandler(this.writeInTheFile_Click);
            // 
            // numberOfLinesButton
            // 
            this.numberOfLinesButton.Location = new System.Drawing.Point(790, 303);
            this.numberOfLinesButton.Name = "numberOfLinesButton";
            this.numberOfLinesButton.Size = new System.Drawing.Size(380, 37);
            this.numberOfLinesButton.TabIndex = 6;
            this.numberOfLinesButton.Text = "Подсчет количества строк";
            this.numberOfLinesButton.UseVisualStyleBackColor = true;
            this.numberOfLinesButton.Click += new System.EventHandler(this.numberOfLinesButton_Click);
            // 
            // informationLabel
            // 
            this.informationLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.informationLabel.Location = new System.Drawing.Point(790, 352);
            this.informationLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(380, 200);
            this.informationLabel.TabIndex = 7;
            // 
            // characterOrWordToCheckTextBox
            // 
            this.characterOrWordToCheckTextBox.Location = new System.Drawing.Point(790, 13);
            this.characterOrWordToCheckTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.characterOrWordToCheckTextBox.Multiline = true;
            this.characterOrWordToCheckTextBox.Name = "characterOrWordToCheckTextBox";
            this.characterOrWordToCheckTextBox.PlaceholderText = "Слово/символ для поиска или замены";
            this.characterOrWordToCheckTextBox.Size = new System.Drawing.Size(380, 34);
            this.characterOrWordToCheckTextBox.TabIndex = 8;
            this.characterOrWordToCheckTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfCharacterRepetitionsButton
            // 
            this.numberOfCharacterRepetitionsButton.Location = new System.Drawing.Point(790, 97);
            this.numberOfCharacterRepetitionsButton.Name = "numberOfCharacterRepetitionsButton";
            this.numberOfCharacterRepetitionsButton.Size = new System.Drawing.Size(262, 53);
            this.numberOfCharacterRepetitionsButton.TabIndex = 9;
            this.numberOfCharacterRepetitionsButton.Text = "Подсчет количества повторений символа/слова";
            this.numberOfCharacterRepetitionsButton.UseVisualStyleBackColor = true;
            this.numberOfCharacterRepetitionsButton.Click += new System.EventHandler(this.numberOfCharacterRepetitionsButton_Click);
            // 
            // toReplaceTextBox
            // 
            this.toReplaceTextBox.Location = new System.Drawing.Point(790, 58);
            this.toReplaceTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.toReplaceTextBox.Multiline = true;
            this.toReplaceTextBox.Name = "toReplaceTextBox";
            this.toReplaceTextBox.PlaceholderText = "Слово/символ на который заменить";
            this.toReplaceTextBox.Size = new System.Drawing.Size(380, 35);
            this.toReplaceTextBox.TabIndex = 10;
            this.toReplaceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(1056, 97);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(114, 53);
            this.replaceButton.TabIndex = 11;
            this.replaceButton.Text = "Заменить";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 53);
            this.button1.TabIndex = 12;
            this.button1.Text = "В верхний регистр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(984, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 53);
            this.button2.TabIndex = 13;
            this.button2.Text = "В нижний регистр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(795, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Только найденное";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(984, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 53);
            this.button3.TabIndex = 16;
            this.button3.Text = "В русский";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(790, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 53);
            this.button4.TabIndex = 15;
            this.button4.Text = "В английский";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.toReplaceTextBox);
            this.Controls.Add(this.numberOfCharacterRepetitionsButton);
            this.Controls.Add(this.characterOrWordToCheckTextBox);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.numberOfLinesButton);
            this.Controls.Add(this.writeInTheFile);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button BrowseButton;
        private TextBox fileNameTextBox;
        private Label outputLabel;
        private TextBox inputTextBox;
        private Button writeInTheFile;
        private Button numberOfLinesButton;
        private Label informationLabel;
        private TextBox characterOrWordToCheckTextBox;
        private Button numberOfCharacterRepetitionsButton;
        private TextBox toReplaceTextBox;
        private Button replaceButton;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
        private Button button4;
    }
}