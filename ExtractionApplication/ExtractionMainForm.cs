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
            SimpleMethod_radioButton.Checked = true;
        }

        private Method GetCurrentMethod()
        {
            return SimpleMethod_radioButton.Checked ? Method.Simple : BitsSkippingMethod_radioButton.Checked ? Method.BitsSkipping : Method.RandBitsSkipping;
        }

        private void ContainerPath_textBox_MouseDoubleClick(object sender, MouseEventArgs e)
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
            Image image = FilledContainer_pictureBox.Image;
            Method method = GetCurrentMethod();
            string message;
            if (method == Method.Simple || method == Method.BitsSkipping)
            {
                Channel channel = Red_radioButton.Checked ? Channel.R : Green_radioButton.Checked ? Channel.G : Channel.B;
                if (method == Method.Simple)
                {
                    message = Extraction.ExtractMessageFromImage(image, channel);
                }
                else
                {
                    int number = Convert.ToInt32(BeginNumber_nud.Value);
                    message = Extraction.ExtractMessageFromImage(image, channel, number);
                }
            }
            else
            {
                int beginNumber = Convert.ToInt32(BeginNumber_nud.Value);
                int endNumber = Convert.ToInt32(EndNumber_nud.Value);
                message = Extraction.ExtractMessageFromImage(image, beginNumber, endNumber);
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
