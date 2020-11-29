using Steganography.Service;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace EmbedApplication
{
    public partial class EmbedMainForm : Form
    {
        public EmbedMainForm()
        {
            InitializeComponent();
        }

        private static string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }

        private void LoadContainer(string fileName)
        {
            Container_pictureBox.ImageLocation = fileName;
            Container_pictureBox.Load();
        }

        private void Container_textBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files(*.*)|*.*|PNG Images(*.png)|*.png|JPEG Images(*.jpeg)|*.jpeg|JPG Images(*.jpg)|*.jpg|BMP Images(*.bmp)|*.bmp";
            fileDialog.InitialDirectory = GetAppFolder();
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                ContainerPath_textBox.Text = fileDialog.FileName;
                LoadContainer(fileDialog.FileName);
                Message_textBox.Enabled = true;
                Cancel_button.Enabled = true;
            }
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
            if (Container_pictureBox.Image != null)
            {
                Container_pictureBox.Image.Dispose();
                Container_pictureBox.Image = null;
            }
            if (FilledContainer_pictureBox.Image != null)
            {
                FilledContainer_pictureBox.Image.Dispose();
                FilledContainer_pictureBox.Image = null;
            }
            FillContainer_button.Enabled = false;
            SaveFillContainer_button.Enabled = false;
            Cancel_button.Enabled = false;
        }

        private void Message_textBox_TextChanged(object sender, EventArgs e)
        {
            FillContainer_button.Enabled = !String.IsNullOrEmpty(Message_textBox.Text);

        }

        private void FillContainer_button_Click(object sender, EventArgs e)
        {
            string message = Message_textBox.Text;
            Image container = Container_pictureBox.Image;
            Channel ch = Red_radioButton.Checked ? Channel.R : Green_radioButton.Checked ? Channel.G : Channel.B;
            Int32 number = Convert.ToInt32(Number_numericUpDown.Value);
            Image filledContainer = Embedding.EmbedMessageInImage(message, container, ch, number);
            FilledContainer_pictureBox.Image = filledContainer;
            if (FilledContainer_pictureBox.Image != null)
            {

                SaveFillContainer_button.Enabled = true;
            }
        }

        private void SaveFillContainer_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = "All Files(*.*)|*.*|PNG Image(*.png)|*.png",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                if (FilledContainer_pictureBox.Image != null)
                {
                    FilledContainer_pictureBox.Image.Save(fileDialog.FileName, ImageFormat.Png);
                    MessageBox.Show("Сохранение прошло успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}