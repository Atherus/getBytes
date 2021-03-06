﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Resources;

namespace GetBytes {
    public partial class app_GetBytes : Form {

        public String formatType = FormatTypesEnum.formatTypes.Base64.ToString();
        ResourceManager rm = new ResourceManager("GetBytes.Language", typeof(app_GetBytes).Assembly);
        CultureInfo cul = CultureInfo.CreateSpecificCulture("sk");

        public app_GetBytes() {
            InitializeComponent();
            labelText_format.Text = formatType;
            Application.EnableVisualStyles();

            setLabelTexts();
        }

        private void setLabelTexts() {
            label_format.Text = rm.GetString("label_format", cul);
            label_bytes.Text = rm.GetString("label_bytes", cul);
            label_path.Text = rm.GetString("label_path", cul);
            label_size.Text = rm.GetString("label_size", cul);
            button_GetBytes.Text = rm.GetString("button_getBytes", cul);
            button_MakeFile.Text = rm.GetString("button_makeFile", cul);
            toolStripMenuItem_about.Text = rm.GetString("menu_about", cul);
            toolStripMenuItem_format.Text = rm.GetString("menu_format", cul);
            toolStripMenuItem_language.Text = rm.GetString("menu_language", cul);
        }

        private void buttonGetBytes_Click(object sender, EventArgs e) {
            if (File.Exists(textBoxFilePath.Text)) {
                byte[] array = File.ReadAllBytes(textBoxFilePath.Text);
                if (formatType.Equals(FormatTypesEnum.formatTypes.Base64.ToString())) {
                    textBoxBytes.Text = Convert.ToBase64String(array);
                    
                } else {
                    StringBuilder hex = new StringBuilder(array.Length * 2);
                    foreach (byte b in array) {
                        hex.AppendFormat("{0:x2}", b);
                    }
                    textBoxBytes.Text = hex.ToString();
                }
            } else {
                MessageBox.Show(this, "Súbor neexistuje.");
            }
        }

        private void buttonMakeFile_Click(object sender, EventArgs e) {
            if (textBoxFilePath.Text == "") {
                String getTime = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                textBoxFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\testFile" + getTime + ".pdf";
            }
            if (formatType.Equals(FormatTypesEnum.formatTypes.Base64.ToString())) {
                File.WriteAllBytes(textBoxFilePath.Text, Convert.FromBase64String(textBoxBytes.Text));
            } else {
                File.WriteAllBytes(textBoxFilePath.Text, StringToByteArray(textBoxBytes.Text.ToString()));
            }
            getFileSize(textBoxFilePath.Text);
        }

        public static byte[] StringToByteArray(string hex) {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        private void textBoxFilePath_MouseDoubleClick(object sender, MouseEventArgs e) {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) {
                textBoxFilePath.Text = openFileDialog.FileName;
                getFileSize(openFileDialog.FileName);
            }
        }

        private void textBoxFilePath_DragDrop(object sender, DragEventArgs e) {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxFilePath.Text = FileList.First();
            getFileSize(FileList.First());
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBoxFilePath.Text = FileList.First();
            getFileSize(FileList.First());
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }

        private void getFileSize(String filePath) {
            labelText_size.Text = File.ReadAllBytes(filePath).Length.ToString() + "bytes";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void rawToolStripMenuItem_Click(object sender, EventArgs e) {
            labelText_format.Text = FormatTypesEnum.formatTypes.Raw.ToString();
            formatType = FormatTypesEnum.formatTypes.Raw.ToString();
        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e) {
            labelText_format.Text = FormatTypesEnum.formatTypes.Base64.ToString();
            formatType = FormatTypesEnum.formatTypes.Base64.ToString();
        }

        private void slovakToolStripMenuItem_Click(object sender, EventArgs e) {
            cul = CultureInfo.CreateSpecificCulture("sk");
            setLabelTexts();
            Refresh();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e) {
            cul = CultureInfo.CreateSpecificCulture("en");
            setLabelTexts();
            Refresh();
        }
    }
}

