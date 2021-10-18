
namespace WinFormsApp_SymbolsOfStrings
{
    partial class form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_AboutInput = new System.Windows.Forms.Label();
            this.label_AboutLetter = new System.Windows.Forms.Label();
            this.listBox_Input = new System.Windows.Forms.ListBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_FindLetter = new System.Windows.Forms.Button();
            this.textBox_Letter = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AboutInput
            // 
            this.label_AboutInput.AutoSize = true;
            this.label_AboutInput.Location = new System.Drawing.Point(49, 46);
            this.label_AboutInput.Name = "label_AboutInput";
            this.label_AboutInput.Size = new System.Drawing.Size(131, 13);
            this.label_AboutInput.TabIndex = 0;
            this.label_AboutInput.Text = "Набор строк для поиска";
            // 
            // label_AboutLetter
            // 
            this.label_AboutLetter.AutoSize = true;
            this.label_AboutLetter.Location = new System.Drawing.Point(240, 46);
            this.label_AboutLetter.Name = "label_AboutLetter";
            this.label_AboutLetter.Size = new System.Drawing.Size(76, 13);
            this.label_AboutLetter.TabIndex = 1;
            this.label_AboutLetter.Text = "Буква поиска";
            // 
            // listBox_Input
            // 
            this.listBox_Input.FormattingEnabled = true;
            this.listBox_Input.Items.AddRange(new object[] {
            "Употребляйте с пользой время,",
            "Учиться надо по системе",
            "Сперва хочу вам в долг вменить",
            "На курсы логики ходить",
            "Ваш ум, нетронутый доныне,",
            "На них приучат к дисциплине,",
            "Чтоб взял он направленья ось,",
            "Не разбредаясь вкривь и вкось.",
            "",
            "",
            " "});
            this.listBox_Input.Location = new System.Drawing.Point(18, 62);
            this.listBox_Input.Name = "listBox_Input";
            this.listBox_Input.Size = new System.Drawing.Size(204, 121);
            this.listBox_Input.TabIndex = 2;
            this.listBox_Input.SelectedIndexChanged += new System.EventHandler(this.listBox_Input_SelectedIndexChanged);
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(18, 207);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(89, 23);
            this.button_Open.TabIndex = 3;
            this.button_Open.Text = "Открыть";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(133, 207);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(89, 23);
            this.button_Clear.TabIndex = 4;
            this.button_Clear.Text = "Очистить";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(243, 207);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(89, 23);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_FindLetter
            // 
            this.button_FindLetter.Location = new System.Drawing.Point(243, 149);
            this.button_FindLetter.Name = "button_FindLetter";
            this.button_FindLetter.Size = new System.Drawing.Size(89, 23);
            this.button_FindLetter.TabIndex = 6;
            this.button_FindLetter.Text = "Посчитать";
            this.button_FindLetter.UseVisualStyleBackColor = true;
            this.button_FindLetter.Click += new System.EventHandler(this.button_FindLetter_Click);
            // 
            // textBox_Letter
            // 
            this.textBox_Letter.Location = new System.Drawing.Point(243, 72);
            this.textBox_Letter.MaxLength = 1;
            this.textBox_Letter.Multiline = true;
            this.textBox_Letter.Name = "textBox_Letter";
            this.textBox_Letter.ReadOnly = true;
            this.textBox_Letter.Size = new System.Drawing.Size(73, 21);
            this.textBox_Letter.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_File,
            this.ToolStripMenu_Help});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(352, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenu_File
            // 
            this.ToolStripMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_Open,
            this.ToolStripMenu_Clear,
            this.ToolStripMenu_Exit});
            this.ToolStripMenu_File.Name = "ToolStripMenu_File";
            this.ToolStripMenu_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenu_File.Text = "Файл";
            // 
            // ToolStripMenu_Open
            // 
            this.ToolStripMenu_Open.Name = "ToolStripMenu_Open";
            this.ToolStripMenu_Open.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Open.Text = "Открыть";
            // 
            // ToolStripMenu_Clear
            // 
            this.ToolStripMenu_Clear.Name = "ToolStripMenu_Clear";
            this.ToolStripMenu_Clear.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Clear.Text = "Очистить";
            // 
            // ToolStripMenu_Exit
            // 
            this.ToolStripMenu_Exit.Name = "ToolStripMenu_Exit";
            this.ToolStripMenu_Exit.Size = new System.Drawing.Size(126, 22);
            this.ToolStripMenu_Exit.Text = "Выход";
            // 
            // ToolStripMenu_Help
            // 
            this.ToolStripMenu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu_About});
            this.ToolStripMenu_Help.Name = "ToolStripMenu_Help";
            this.ToolStripMenu_Help.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenu_Help.Text = "Помощь";
            // 
            // ToolStripMenu_About
            // 
            this.ToolStripMenu_About.Name = "ToolStripMenu_About";
            this.ToolStripMenu_About.Size = new System.Drawing.Size(149, 22);
            this.ToolStripMenu_About.Text = "О программе";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 255);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(352, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(196, 17);
            this.toolStripStatusLabel.Text = "Приложение загружено успешно!";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "*.txt|*.txt";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 277);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox_Letter);
            this.Controls.Add(this.button_FindLetter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.listBox_Input);
            this.Controls.Add(this.label_AboutLetter);
            this.Controls.Add(this.label_AboutInput);
            this.Controls.Add(this.menuStrip);
            this.Name = "form_Main";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AboutInput;
        private System.Windows.Forms.Label label_AboutLetter;
        private System.Windows.Forms.ListBox listBox_Input;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_FindLetter;
        private System.Windows.Forms.TextBox textBox_Letter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Clear;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_Help;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenu_About;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

