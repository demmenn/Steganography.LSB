using Steganography.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExtractionApplication
{
    public partial class ExtractionMainForm : Form
    {
        public ExtractionMainForm()
        {
            InitializeComponent();
            ChoosedMethod_comboBox.SelectedIndex = 0;
        }

        private Method GetCurrentMethod()
        {
            return (Method)ChoosedMethod_comboBox.SelectedIndex;
        }

        private void LoadContainer(string fileName)
        {
            if (fileName.CheckImageExtension())
            {
                FilledContainer_pictureBox.ImageLocation = fileName;
                FilledContainer_pictureBox.Load();
            }
            else
            {
                Reset();
                MessageBox.Show("Попытка загрузить не изображение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExtractMessage_button_Click(object sender, EventArgs e)
        {
            Image container = FilledContainer_pictureBox.Image;
            Method method = GetCurrentMethod();
            string message;

            Channel channel = Red_radioButton.Checked ? Channel.R : Green_radioButton.Checked ? Channel.G : Channel.B;
            int firstNumber = Convert.ToInt32(BeginNumber_nud.Value);
            int secondNumber = Convert.ToInt32(EndNumber_nud.Value);

            switch (method)
            {
                case Method.Simple:
                    message = Extraction.Simple(container, channel);
                    break;
                case Method.BitsSkipping:
                    message = Extraction.Simple(container, channel, firstNumber);
                    break;
                case Method.RandBitsSkipping:
                    message = Extraction.RandBitsSkipping(container, firstNumber, secondNumber);
                    break;
                case Method.BlockOneChannel:
                    message = Extraction.BlockOneChannel(container, channel, firstNumber, secondNumber);
                    break;
                case Method.BlockThreeChannel:
                    message = Extraction.BlockThreeChannel(container, firstNumber, secondNumber);
                    break;
                default:
                    throw new Exception("Error.");
            }

            Message_textBox.Text = message;
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
            if (FilledContainer_pictureBox.Image != null)
            {
                FilledContainer_pictureBox.Image.Dispose();
                FilledContainer_pictureBox.Image = null;
            }
            ExtractMessage_button.Enabled = false;
            Message_textBox.Enabled = false;
            Cancel_button.Enabled = false;
        }

        private void Cancel_button_Click(object sender, EventArgs e) => Reset();

        private void MethodChanged(object sender, EventArgs e)
        {
            Method method = GetCurrentMethod();

            ColorChannel_label.Visible = method == Method.Simple || method == Method.BitsSkipping || method == Method.BlockOneChannel;
            RGB_flowLayoutPanel.Visible = method == Method.Simple || method == Method.BitsSkipping || method == Method.BlockOneChannel;
            InfoBeginNumber_label.Visible = method == Method.BitsSkipping || method == Method.RandBitsSkipping || method == Method.BlockOneChannel || method == Method.BlockThreeChannel;
            BeginNumber_nud.Visible = method == Method.BitsSkipping || method == Method.RandBitsSkipping || method == Method.BlockOneChannel || method == Method.BlockThreeChannel;
            InfoEndNumber_label.Visible = method == Method.RandBitsSkipping || method == Method.BlockOneChannel || method == Method.BlockThreeChannel;
            EndNumber_nud.Visible = method == Method.RandBitsSkipping || method == Method.BlockOneChannel || method == Method.BlockThreeChannel ;

            if (method == Method.BitsSkipping)
            {
                InfoBeginNumber_label.Text = "Число пропусков:";
                InfoBeginNumber_label.Location = new Point(722, 83);
            }
            else if (method == Method.RandBitsSkipping)
            {
                InfoBeginNumber_label.Text = "Мин. число пропусков:";
                InfoBeginNumber_label.Location = new Point(676, 83);

                InfoEndNumber_label.Text = "Макс. число пропусков:";
                InfoEndNumber_label.Location = new Point(668, 119);
            }
            else if (method == Method.BlockOneChannel || method == Method.BlockThreeChannel)
            {
                InfoBeginNumber_label.Text = "Ширина блока:";
                InfoBeginNumber_label.Location = new Point(749, 83);

                InfoEndNumber_label.Text = "Высота блока:";
                InfoEndNumber_label.Location = new Point(750, 119);
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
            fileDialog.Filter = "All Files(*.*)|*.*|PNG Images(*.png)|*.png";
            fileDialog.FilterIndex = 2;
            fileDialog.InitialDirectory = Utils.GetAppFolder();
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() != DialogResult.Cancel)
            {
                ContainerPath_textBox.Text = fileDialog.FileName;
                LoadContainer(fileDialog.FileName);
                ExtractMessage_button.Enabled = true;
                Cancel_button.Enabled = true;
            }
        }
    }
}
