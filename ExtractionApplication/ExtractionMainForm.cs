using Steganography.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractionApplication
{
    public partial class ExtractionMainForm : Form
    {
        public ExtractionMainForm()
        {
            InitializeComponent();
        }

        private static string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }

        private void ContainerPath_textBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files(*.*)|*.*|PNG Images(*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.InitialDirectory = GetAppFolder();
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                ContainerPath_textBox.Text = fileDialog.FileName;
                LoadContainer(fileDialog.FileName);
                ExtractMessage_button.Enabled = true;
                Cancel_button.Enabled = true;
            }
        }

        private void LoadContainer(string fileName)
        {
            FilledContainer_pictureBox.ImageLocation = fileName;
            FilledContainer_pictureBox.Load();
        }

        private void ExtractMessage_button_Click(object sender, EventArgs e)
        {
            Image image = FilledContainer_pictureBox.Image;
            string message = Extraction.ExtractMessage(image);
            Message_textBox.Text = message;
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ContainerPath_textBox.Text))
            {
                ContainerPath_textBox.Text = null;
            }
            if (!String.IsNullOrEmpty(Message_textBox.Text))
            {
                Message_textBox.Text = null;
            }
            if (FilledContainer_pictureBox.Image != null)
            {
                FilledContainer_pictureBox.Image.Dispose();
                FilledContainer_pictureBox.Image = null;
            }
            ExtractMessage_button.Enabled = false;
            Cancel_button.Enabled = false;
        }
    }
}
