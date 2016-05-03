namespace GetBytes
{
    partial class app_GetBytes
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody s editorem kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app_GetBytes));
            this.button_GetBytes = new System.Windows.Forms.Button();
            this.button_MakeFile = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label_bytes = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBytes = new System.Windows.Forms.RichTextBox();
            this.label_size = new System.Windows.Forms.Label();
            this.labelText_size = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_format = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_raw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_base64 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_language = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_slovak = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_english = new System.Windows.Forms.ToolStripMenuItem();
            this.label_format = new System.Windows.Forms.Label();
            this.labelText_format = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_GetBytes
            // 
            this.button_GetBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_GetBytes.Location = new System.Drawing.Point(304, 286);
            this.button_GetBytes.Name = "button_GetBytes";
            this.button_GetBytes.Size = new System.Drawing.Size(75, 23);
            this.button_GetBytes.TabIndex = 0;
            this.button_GetBytes.Text = "GetBytes!";
            this.button_GetBytes.UseVisualStyleBackColor = true;
            this.button_GetBytes.Click += new System.EventHandler(this.buttonGetBytes_Click);
            // 
            // button_MakeFile
            // 
            this.button_MakeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MakeFile.Location = new System.Drawing.Point(385, 286);
            this.button_MakeFile.Name = "button_MakeFile";
            this.button_MakeFile.Size = new System.Drawing.Size(75, 23);
            this.button_MakeFile.TabIndex = 1;
            this.button_MakeFile.Text = "MakeFile!";
            this.button_MakeFile.UseVisualStyleBackColor = true;
            this.button_MakeFile.Click += new System.EventHandler(this.buttonMakeFile_Click);
            // 
            // label_path
            // 
            this.label_path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(12, 43);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(29, 13);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.AllowDrop = true;
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(100, 40);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(360, 20);
            this.textBoxFilePath.TabIndex = 3;
            this.textBoxFilePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFilePath_MouseDoubleClick);
            // 
            // label_bytes
            // 
            this.label_bytes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bytes.AutoSize = true;
            this.label_bytes.Location = new System.Drawing.Point(12, 69);
            this.label_bytes.Name = "label_bytes";
            this.label_bytes.Size = new System.Drawing.Size(33, 13);
            this.label_bytes.TabIndex = 4;
            this.label_bytes.Text = "Bytes";
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBytes.EnableAutoDragDrop = true;
            this.textBoxBytes.Location = new System.Drawing.Point(100, 66);
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(360, 214);
            this.textBoxBytes.TabIndex = 6;
            this.textBoxBytes.Text = "";
            // 
            // label_size
            // 
            this.label_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(12, 291);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(48, 13);
            this.label_size.TabIndex = 7;
            this.label_size.Text = "Veľkosť:";
            // 
            // labelText_size
            // 
            this.labelText_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelText_size.AutoSize = true;
            this.labelText_size.Location = new System.Drawing.Point(66, 291);
            this.labelText_size.Name = "labelText_size";
            this.labelText_size.Size = new System.Drawing.Size(16, 13);
            this.labelText_size.TabIndex = 9;
            this.labelText_size.Text = "   ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_about,
            this.toolStripMenuItem_format,
            this.toolStripMenuItem_language});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem_about
            // 
            this.toolStripMenuItem_about.Name = "toolStripMenuItem_about";
            this.toolStripMenuItem_about.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem_about.Text = "O aplikácii";
            this.toolStripMenuItem_about.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_format
            // 
            this.toolStripMenuItem_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_raw,
            this.toolStripMenuItem_base64});
            this.toolStripMenuItem_format.Name = "toolStripMenuItem_format";
            this.toolStripMenuItem_format.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem_format.Text = "Formát";
            // 
            // toolStripMenuItem_raw
            // 
            this.toolStripMenuItem_raw.Name = "toolStripMenuItem_raw";
            this.toolStripMenuItem_raw.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_raw.Text = "Raw";
            this.toolStripMenuItem_raw.Click += new System.EventHandler(this.rawToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_base64
            // 
            this.toolStripMenuItem_base64.Name = "toolStripMenuItem_base64";
            this.toolStripMenuItem_base64.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_base64.Text = "Base64";
            this.toolStripMenuItem_base64.Click += new System.EventHandler(this.base64ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_language
            // 
            this.toolStripMenuItem_language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_slovak,
            this.toolStripMenuItem_english});
            this.toolStripMenuItem_language.Name = "toolStripMenuItem_language";
            this.toolStripMenuItem_language.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem_language.Text = "Jazyk";
            // 
            // toolStripMenuItem_slovak
            // 
            this.toolStripMenuItem_slovak.Name = "toolStripMenuItem_slovak";
            this.toolStripMenuItem_slovak.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_slovak.Text = "Slovenčina";
            this.toolStripMenuItem_slovak.Click += new System.EventHandler(this.slovakToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_english
            // 
            this.toolStripMenuItem_english.Name = "toolStripMenuItem_english";
            this.toolStripMenuItem_english.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem_english.Text = "English";
            this.toolStripMenuItem_english.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // label_format
            // 
            this.label_format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_format.AutoSize = true;
            this.label_format.Location = new System.Drawing.Point(164, 291);
            this.label_format.Name = "label_format";
            this.label_format.Size = new System.Drawing.Size(42, 13);
            this.label_format.TabIndex = 11;
            this.label_format.Text = "Formát:";
            // 
            // labelText_format
            // 
            this.labelText_format.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelText_format.AutoSize = true;
            this.labelText_format.Location = new System.Drawing.Point(212, 291);
            this.labelText_format.Name = "labelText_format";
            this.labelText_format.Size = new System.Drawing.Size(16, 13);
            this.labelText_format.TabIndex = 12;
            this.labelText_format.Text = "   ";
            // 
            // app_GetBytes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 317);
            this.Controls.Add(this.labelText_format);
            this.Controls.Add(this.label_format);
            this.Controls.Add(this.labelText_size);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.textBoxBytes);
            this.Controls.Add(this.label_bytes);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.button_MakeFile);
            this.Controls.Add(this.button_GetBytes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(493, 268);
            this.Name = "app_GetBytes";
            this.Text = "GetBytes!";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GetBytes;
        private System.Windows.Forms.Button button_MakeFile;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label_bytes;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox textBoxBytes;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label labelText_size;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_about;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_format;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_raw;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_base64;
        private System.Windows.Forms.Label label_format;
        private System.Windows.Forms.Label labelText_format;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_language;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_slovak;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_english;
    }
}

