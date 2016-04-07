namespace GetBytes
{
    partial class GetBytes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetBytes));
            this.buttonGetBytes = new System.Windows.Forms.Button();
            this.buttonMakeFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxBytes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFormat = new System.Windows.Forms.Label();
            this.jazykToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slovakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetBytes
            // 
            this.buttonGetBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetBytes.Location = new System.Drawing.Point(304, 286);
            this.buttonGetBytes.Name = "buttonGetBytes";
            this.buttonGetBytes.Size = new System.Drawing.Size(75, 23);
            this.buttonGetBytes.TabIndex = 0;
            this.buttonGetBytes.Text = "GetBytes!";
            this.buttonGetBytes.UseVisualStyleBackColor = true;
            this.buttonGetBytes.Click += new System.EventHandler(this.buttonGetBytes_Click);
            // 
            // buttonMakeFile
            // 
            this.buttonMakeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeFile.Location = new System.Drawing.Point(385, 286);
            this.buttonMakeFile.Name = "buttonMakeFile";
            this.buttonMakeFile.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeFile.TabIndex = 1;
            this.buttonMakeFile.Text = "MakeFile!";
            this.buttonMakeFile.UseVisualStyleBackColor = true;
            this.buttonMakeFile.Click += new System.EventHandler(this.buttonMakeFile_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.AllowDrop = true;
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(59, 40);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(401, 20);
            this.textBoxFilePath.TabIndex = 3;
            this.textBoxFilePath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxFilePath_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bytes";
            // 
            // textBoxBytes
            // 
            this.textBoxBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBytes.EnableAutoDragDrop = true;
            this.textBoxBytes.Location = new System.Drawing.Point(59, 66);
            this.textBoxBytes.Name = "textBoxBytes";
            this.textBoxBytes.Size = new System.Drawing.Size(401, 214);
            this.textBoxBytes.TabIndex = 6;
            this.textBoxBytes.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Veľkosť:";
            // 
            // labelSize
            // 
            this.labelSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(66, 291);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(16, 13);
            this.labelSize.TabIndex = 9;
            this.labelSize.Text = "   ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.jazykToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.aboutToolStripMenuItem.Text = "O aplikácii";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawToolStripMenuItem,
            this.base64ToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Formát";
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rawToolStripMenuItem.Text = "Raw";
            this.rawToolStripMenuItem.Click += new System.EventHandler(this.rawToolStripMenuItem_Click);
            // 
            // base64ToolStripMenuItem
            // 
            this.base64ToolStripMenuItem.Name = "base64ToolStripMenuItem";
            this.base64ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.base64ToolStripMenuItem.Text = "Base64";
            this.base64ToolStripMenuItem.Click += new System.EventHandler(this.base64ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Formát:";
            // 
            // labelFormat
            // 
            this.labelFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point(212, 291);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size(16, 13);
            this.labelFormat.TabIndex = 12;
            this.labelFormat.Text = "   ";
            // 
            // jazykToolStripMenuItem
            // 
            this.jazykToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slovakToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.jazykToolStripMenuItem.Name = "jazykToolStripMenuItem";
            this.jazykToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.jazykToolStripMenuItem.Text = "Jazyk";
            // 
            // slovakToolStripMenuItem
            // 
            this.slovakToolStripMenuItem.Name = "slovakToolStripMenuItem";
            this.slovakToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.slovakToolStripMenuItem.Text = "Slovenčina";
            this.slovakToolStripMenuItem.Click += new System.EventHandler(this.slovakToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // GetBytes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 317);
            this.Controls.Add(this.labelFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBytes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMakeFile);
            this.Controls.Add(this.buttonGetBytes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(493, 268);
            this.Name = "GetBytes";
            this.Text = "GetBytes!";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetBytes;
        private System.Windows.Forms.Button buttonMakeFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox textBoxBytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ToolStripMenuItem jazykToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slovakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

