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
            SimpleMethod_radioButton.Checked = true;
        }

        private void LoadContainer(string fileName)
        {
            if (fileName.CheckImageExtension())
            {
                Container_pictureBox.ImageLocation = fileName;
                Container_pictureBox.Load();
            }
            else
            {
                Reset();
                MessageBox.Show("Попытка загрузить не изображение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Container_textBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All Files(*.*)|*.*|PNG Images(*.png)|*.png|JPEG Images(*.jpeg)|*.jpeg|JPG Images(*.jpg)|*.jpg|BMP Images(*.bmp)|*.bmp";
            fileDialog.InitialDirectory = Utils.GetAppFolder();
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                ContainerPath_textBox.Text = fileDialog.FileName;
                LoadContainer(fileDialog.FileName);
                Message_textBox.Enabled = true;
                Cancel_button.Enabled = true;
            }
        }

        private void Reset()
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
            Message_textBox.Enabled = false;
            Cancel_button.Enabled = false;
        }

        private void Cancel_button_Click(object sender, EventArgs e) => Reset();

        private void Message_textBox_TextChanged(object sender, EventArgs e)
        {
            FillContainer_button.Enabled = !String.IsNullOrEmpty(Message_textBox.Text);
        }

        private void FillContainer_button_Click(object sender, EventArgs e)
        {
            string message = Message_textBox.Text;
            Image container = Container_pictureBox.Image;
            Image filledContainer;
            Method method = GetCurrentMethod();

            if (method == Method.Simple || method == Method.BitsSkipping)
            {
                Channel channel = Red_radioButton.Checked ? Channel.R : Green_radioButton.Checked ? Channel.G : Channel.B;
                if (method == Method.Simple)
                {
                    filledContainer = Embedding.EmbedMessageInImage(message, container, channel);
                }
                else
                {
                    int number = Convert.ToInt32(BeginNumber_nud.Value);
                    filledContainer = Embedding.EmbedMessageInImage(message, container, channel, number);
                }
            }
            else
            {
                int beginNumber = Convert.ToInt32(BeginNumber_nud.Value);
                int endNumber = Convert.ToInt32(EndNumber_nud.Value);
                filledContainer = Embedding.EmbedMessageInImage(message, container, beginNumber, endNumber);
            }
            FilledContainer_pictureBox.Image = filledContainer;
            if (FilledContainer_pictureBox.Image != null)
            {
                SaveFillContainer_button.Enabled = true;
            }
        }

        private Method GetCurrentMethod()
        {
            return SimpleMethod_radioButton.Checked ? Method.Simple : BitsSkippingMethod_radioButton.Checked ? Method.BitsSkipping : Method.RandBitsSkipping;
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

        private void MethodChanged(object sender, EventArgs e)
        {
            if (FilledContainer_pictureBox.Image != null)
            {
                FilledContainer_pictureBox.Image.Dispose();
                FilledContainer_pictureBox.Image = null;
            }

            bool _1 = SimpleMethod_radioButton.Checked;
            bool _2 = BitsSkippingMethod_radioButton.Checked;
            bool _3 = BitsRandSkippingMethod_radioButton.Checked;

            ColorChannel_label.Visible = _1 || _2;
            RGB_flowLayoutPanel.Visible = _1 || _2;
            InfoBeginNumber_label.Visible = _2 || _3;
            BeginNumber_nud.Visible = _2 || _3; 
            InfoEndNumber_label.Visible = _3;
            EndNumber_nud.Visible = _3;
        }

        private void EndNumber_nud_ValueChanged(object sender, EventArgs e)
        {
            if (EndNumber_nud.Value < BeginNumber_nud.Value)
            {
                EndNumber_nud.Value = BeginNumber_nud.Value;
                MessageBox.Show("Максимальное значение пропуска не может быть меньше минимального.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BeginNumber_nud_ValueChanged(object sender, EventArgs e)
        {
            if (GetCurrentMethod() != Method.BitsSkipping && BeginNumber_nud.Value > EndNumber_nud.Value)
            {
                BeginNumber_nud.Value = EndNumber_nud.Value;
                MessageBox.Show("Минимальное значение пропуска не может быть больше максимального.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}