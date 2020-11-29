
namespace ExtractionApplication
{
    partial class ExtractionMainForm
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
            this.Main_splitContainer = new System.Windows.Forms.SplitContainer();
            this.FilledContainer_pictureBox = new System.Windows.Forms.PictureBox();
            this.ContainerPath_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.ContainerPath_label = new System.Windows.Forms.Label();
            this.ExtractMessage_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Message_label = new System.Windows.Forms.Label();
            this.Number_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColorChannel_label = new System.Windows.Forms.Label();
            this.InfoNumber_label = new System.Windows.Forms.Label();
            this.RGB_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Red_radioButton = new System.Windows.Forms.RadioButton();
            this.Green_radioButton = new System.Windows.Forms.RadioButton();
            this.Blue_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).BeginInit();
            this.Main_splitContainer.Panel1.SuspendLayout();
            this.Main_splitContainer.Panel2.SuspendLayout();
            this.Main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).BeginInit();
            this.RGB_flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_splitContainer
            // 
            this.Main_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Main_splitContainer.IsSplitterFixed = true;
            this.Main_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.Main_splitContainer.Name = "Main_splitContainer";
            this.Main_splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main_splitContainer.Panel1
            // 
            this.Main_splitContainer.Panel1.Controls.Add(this.FilledContainer_pictureBox);
            // 
            // Main_splitContainer.Panel2
            // 
            this.Main_splitContainer.Panel2.Controls.Add(this.Number_numericUpDown);
            this.Main_splitContainer.Panel2.Controls.Add(this.ColorChannel_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.RGB_flowLayoutPanel);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ExtractMessage_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Cancel_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_label);
            this.Main_splitContainer.Size = new System.Drawing.Size(1182, 653);
            this.Main_splitContainer.SplitterDistance = 431;
            this.Main_splitContainer.SplitterWidth = 1;
            this.Main_splitContainer.TabIndex = 0;
            // 
            // FilledContainer_pictureBox
            // 
            this.FilledContainer_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledContainer_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.FilledContainer_pictureBox.Name = "FilledContainer_pictureBox";
            this.FilledContainer_pictureBox.Size = new System.Drawing.Size(1180, 429);
            this.FilledContainer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilledContainer_pictureBox.TabIndex = 0;
            this.FilledContainer_pictureBox.TabStop = false;
            // 
            // ContainerPath_textBox
            // 
            this.ContainerPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_textBox.Location = new System.Drawing.Point(271, 7);
            this.ContainerPath_textBox.Name = "ContainerPath_textBox";
            this.ContainerPath_textBox.ReadOnly = true;
            this.ContainerPath_textBox.Size = new System.Drawing.Size(404, 30);
            this.ContainerPath_textBox.TabIndex = 15;
            this.ContainerPath_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContainerPath_textBox_MouseDoubleClick);
            // 
            // Message_textBox
            // 
            this.Message_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_textBox.Location = new System.Drawing.Point(16, 70);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.ReadOnly = true;
            this.Message_textBox.Size = new System.Drawing.Size(659, 141);
            this.Message_textBox.TabIndex = 12;
            // 
            // ContainerPath_label
            // 
            this.ContainerPath_label.AutoSize = true;
            this.ContainerPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_label.Location = new System.Drawing.Point(11, 10);
            this.ContainerPath_label.Name = "ContainerPath_label";
            this.ContainerPath_label.Size = new System.Drawing.Size(260, 25);
            this.ContainerPath_label.TabIndex = 14;
            this.ContainerPath_label.Text = "Контейнер с сообщением:";
            // 
            // ExtractMessage_button
            // 
            this.ExtractMessage_button.Enabled = false;
            this.ExtractMessage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractMessage_button.Location = new System.Drawing.Point(967, 42);
            this.ExtractMessage_button.Name = "ExtractMessage_button";
            this.ExtractMessage_button.Size = new System.Drawing.Size(192, 63);
            this.ExtractMessage_button.TabIndex = 10;
            this.ExtractMessage_button.Text = "Произвести извлечение";
            this.ExtractMessage_button.UseVisualStyleBackColor = true;
            this.ExtractMessage_button.Click += new System.EventHandler(this.ExtractMessage_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Enabled = false;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(967, 111);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(192, 63);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Сброс";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_label.Location = new System.Drawing.Point(11, 42);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(255, 25);
            this.Message_label.TabIndex = 11;
            this.Message_label.Text = "Сообщение в контейнере:";
            // 
            // Number_numericUpDown
            // 
            this.Number_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_numericUpDown.Location = new System.Drawing.Point(762, 11);
            this.Number_numericUpDown.Name = "Number_numericUpDown";
            this.Number_numericUpDown.Size = new System.Drawing.Size(175, 30);
            this.Number_numericUpDown.TabIndex = 19;
            // 
            // ColorChannel_label
            // 
            this.ColorChannel_label.AutoSize = true;
            this.ColorChannel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorChannel_label.Location = new System.Drawing.Point(681, 51);
            this.ColorChannel_label.Name = "ColorChannel_label";
            this.ColorChannel_label.Size = new System.Drawing.Size(119, 25);
            this.ColorChannel_label.TabIndex = 18;
            this.ColorChannel_label.Text = "Контейнер:";
            // 
            // InfoNumber_label
            // 
            this.InfoNumber_label.AutoSize = true;
            this.InfoNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoNumber_label.Location = new System.Drawing.Point(681, 12);
            this.InfoNumber_label.Name = "InfoNumber_label";
            this.InfoNumber_label.Size = new System.Drawing.Size(75, 25);
            this.InfoNumber_label.TabIndex = 17;
            this.InfoNumber_label.Text = "Число:";
            // 
            // RGB_flowLayoutPanel
            // 
            this.RGB_flowLayoutPanel.AutoSize = true;
            this.RGB_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RGB_flowLayoutPanel.Controls.Add(this.Red_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Green_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Blue_radioButton);
            this.RGB_flowLayoutPanel.Location = new System.Drawing.Point(800, 47);
            this.RGB_flowLayoutPanel.Name = "RGB_flowLayoutPanel";
            this.RGB_flowLayoutPanel.Size = new System.Drawing.Size(137, 29);
            this.RGB_flowLayoutPanel.TabIndex = 16;
            // 
            // Red_radioButton
            // 
            this.Red_radioButton.AutoSize = true;
            this.Red_radioButton.Checked = true;
            this.Red_radioButton.Location = new System.Drawing.Point(3, 3);
            this.Red_radioButton.Name = "Red_radioButton";
            this.Red_radioButton.Size = new System.Drawing.Size(39, 21);
            this.Red_radioButton.TabIndex = 0;
            this.Red_radioButton.TabStop = true;
            this.Red_radioButton.Text = "R";
            this.Red_radioButton.UseVisualStyleBackColor = true;
            // 
            // Green_radioButton
            // 
            this.Green_radioButton.AutoSize = true;
            this.Green_radioButton.Location = new System.Drawing.Point(48, 3);
            this.Green_radioButton.Name = "Green_radioButton";
            this.Green_radioButton.Size = new System.Drawing.Size(40, 21);
            this.Green_radioButton.TabIndex = 1;
            this.Green_radioButton.Text = "G";
            this.Green_radioButton.UseVisualStyleBackColor = true;
            // 
            // Blue_radioButton
            // 
            this.Blue_radioButton.AutoSize = true;
            this.Blue_radioButton.Location = new System.Drawing.Point(94, 3);
            this.Blue_radioButton.Name = "Blue_radioButton";
            this.Blue_radioButton.Size = new System.Drawing.Size(38, 21);
            this.Blue_radioButton.TabIndex = 2;
            this.Blue_radioButton.Text = "B";
            this.Blue_radioButton.UseVisualStyleBackColor = true;
            // 
            // ExtractionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.Main_splitContainer);
            this.Name = "ExtractionMainForm";
            this.Text = "Form1";
            this.Main_splitContainer.Panel1.ResumeLayout(false);
            this.Main_splitContainer.Panel2.ResumeLayout(false);
            this.Main_splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).EndInit();
            this.Main_splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).EndInit();
            this.RGB_flowLayoutPanel.ResumeLayout(false);
            this.RGB_flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_splitContainer;
        private System.Windows.Forms.PictureBox FilledContainer_pictureBox;
        private System.Windows.Forms.TextBox ContainerPath_textBox;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Label ContainerPath_label;
        private System.Windows.Forms.Button ExtractMessage_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.NumericUpDown Number_numericUpDown;
        private System.Windows.Forms.Label ColorChannel_label;
        private System.Windows.Forms.Label InfoNumber_label;
        private System.Windows.Forms.FlowLayoutPanel RGB_flowLayoutPanel;
        private System.Windows.Forms.RadioButton Red_radioButton;
        private System.Windows.Forms.RadioButton Green_radioButton;
        private System.Windows.Forms.RadioButton Blue_radioButton;
    }
}

