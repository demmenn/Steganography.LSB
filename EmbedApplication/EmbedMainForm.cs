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
            ChoosedMethod_comboBox.SelectedIndex = 0;
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

            Channel channel = Red_radioButton.Checked ? Channel.R : Green_radioButton.Checked ? Channel.G : Channel.B;
            int firstNumber = Convert.ToInt32(BeginNumber_nud.Value);
            int secondNumber = Convert.ToInt32(EndNumber_nud.Value);

            switch (method)
            {
                case Method.Simple:
                    filledContainer = Embedding.EmbedMessageInImage(message, container, channel);
                    break;
                case Method.BitsSkipping:
                    filledContainer = Embedding.EmbedMessageInImage(message, container, channel, firstNumber);
                    break;
                case Method.RandBitsSkipping:
                    filledContainer = Embedding.EmbedMessageInImage(message, container, firstNumber, secondNumber);
                    break;
                case Method.Block:
                    filledContainer = Embedding.EmbedMessageInImage(message, container, channel, firstNumber, secondNumber);
                    break;
                default:
                    throw new Exception("Error.");
            }

            FilledContainer_pictureBox.Image = filledContainer;
            if (FilledContainer_pictureBox.Image != null)
            {
                SaveFillContainer_button.Enabled = true;
            }
        }

        private Method GetCurrentMethod()
        {
            return (Method)ChoosedMethod_comboBox.SelectedIndex;
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

            Method method = GetCurrentMethod();

            ColorChannel_label.Visible = method == Method.Simple || method == Method.BitsSkipping || method == Method.Block;
            RGB_flowLayoutPanel.Visible = method == Method.Simple || method == Method.BitsSkipping || method == Method.Block;
            InfoBeginNumber_label.Visible = method == Method.BitsSkipping || method == Method.RandBitsSkipping || method == Method.Block;
            BeginNumber_nud.Visible = method == Method.BitsSkipping || method == Method.RandBitsSkipping || method == Method.Block;
            InfoEndNumber_label.Visible = method == Method.RandBitsSkipping || method == Method.Block;
            EndNumber_nud.Visible = method == Method.RandBitsSkipping || method == Method.Block;

            if (method == Method.BitsSkipping)
            {
                InfoBeginNumber_label.Text = "Число пропусков:";
                InfoBeginNumber_label.Location = new Point(730, 83);
            }
            else if (method == Method.RandBitsSkipping)
            {
                InfoBeginNumber_label.Text = "Мин. число пропусков:";
                InfoBeginNumber_label.Location = new Point(684, 83);

                InfoEndNumber_label.Text = "Макс. число пропусков:";
                InfoEndNumber_label.Location = new Point(676, 119);
            }
            else if (method == Method.Block)
            {
                InfoBeginNumber_label.Text = "Ширина блока:";
                InfoBeginNumber_label.Location = new Point(757, 83);

                InfoEndNumber_label.Text = "Высота блока:";
                InfoEndNumber_label.Location = new Point(758, 119);
            }
        }

        private void EndNumber_nud_ValueChanged(object sender, EventArgs e)
        {
            if (GetCurrentMethod() == Method.RandBitsSkipping && EndNumber_nud.Value < BeginNumber_nud.Value)
            {
                EndNumber_nud.Value = BeginNumber_nud.Value;
                MessageBox.Show("Максимальное значение пропуска не может быть меньше минимального.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BeginNumber_nud_ValueChanged(object sender, EventArgs e)
        {
            if (GetCurrentMethod() == Method.RandBitsSkipping && BeginNumber_nud.Value > EndNumber_nud.Value)
            {
                BeginNumber_nud.Value = EndNumber_nud.Value;
                MessageBox.Show("Минимальное значение пропуска не может быть больше максимального.", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChooseContainer_button_Click(object sender, EventArgs e)
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
    }
}