
namespace EmbedApplication
{
    partial class EmbedMainForm
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
            this.Containers_splitContainer = new System.Windows.Forms.SplitContainer();
            this.Container_pictureBox = new System.Windows.Forms.PictureBox();
            this.FilledContainer_pictureBox = new System.Windows.Forms.PictureBox();
            this.Methods_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SimpleMethod_radioButton = new System.Windows.Forms.RadioButton();
            this.BitsSkippingMethod_radioButton = new System.Windows.Forms.RadioButton();
            this.BitsRandSkippingMethod_radioButton = new System.Windows.Forms.RadioButton();
            this.EndNumber_nud = new System.Windows.Forms.NumericUpDown();
            this.InfoEndNumber_label = new System.Windows.Forms.Label();
            this.BeginNumber_nud = new System.Windows.Forms.NumericUpDown();
            this.ColorChannel_label = new System.Windows.Forms.Label();
            this.InfoBeginNumber_label = new System.Windows.Forms.Label();
            this.ContainerPath_textBox = new System.Windows.Forms.TextBox();
            this.ContainerPath_label = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SaveFillContainer_button = new System.Windows.Forms.Button();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.Message_label = new System.Windows.Forms.Label();
            this.FillContainer_button = new System.Windows.Forms.Button();
            this.RGB_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Red_radioButton = new System.Windows.Forms.RadioButton();
            this.Green_radioButton = new System.Windows.Forms.RadioButton();
            this.Blue_radioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).BeginInit();
            this.Main_splitContainer.Panel1.SuspendLayout();
            this.Main_splitContainer.Panel2.SuspendLayout();
            this.Main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Containers_splitContainer)).BeginInit();
            this.Containers_splitContainer.Panel1.SuspendLayout();
            this.Containers_splitContainer.Panel2.SuspendLayout();
            this.Containers_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Container_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).BeginInit();
            this.Methods_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber_nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginNumber_nud)).BeginInit();
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
            this.Main_splitContainer.Panel1.Controls.Add(this.Containers_splitContainer);
            // 
            // Main_splitContainer.Panel2
            // 
            this.Main_splitContainer.Panel2.Controls.Add(this.Methods_flowLayoutPanel);
            this.Main_splitContainer.Panel2.Controls.Add(this.EndNumber_nud);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoEndNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.BeginNumber_nud);
            this.Main_splitContainer.Panel2.Controls.Add(this.ColorChannel_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoBeginNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.Cancel_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.SaveFillContainer_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.FillContainer_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.RGB_flowLayoutPanel);
            this.Main_splitContainer.Size = new System.Drawing.Size(1371, 770);
            this.Main_splitContainer.SplitterDistance = 539;
            this.Main_splitContainer.TabIndex = 0;
            // 
            // Containers_splitContainer
            // 
            this.Containers_splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Containers_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Containers_splitContainer.IsSplitterFixed = true;
            this.Containers_splitContainer.Location = new System.Drawing.Point(0, 0);
            this.Containers_splitContainer.Name = "Containers_splitContainer";
            // 
            // Containers_splitContainer.Panel1
            // 
            this.Containers_splitContainer.Panel1.Controls.Add(this.Container_pictureBox);
            this.Containers_splitContainer.Panel1.Margin = new System.Windows.Forms.Padding(10);
            this.Containers_splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // Containers_splitContainer.Panel2
            // 
            this.Containers_splitContainer.Panel2.Controls.Add(this.FilledContainer_pictureBox);
            this.Containers_splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.Containers_splitContainer.Size = new System.Drawing.Size(1371, 539);
            this.Containers_splitContainer.SplitterDistance = 686;
            this.Containers_splitContainer.SplitterWidth = 1;
            this.Containers_splitContainer.TabIndex = 0;
            // 
            // Container_pictureBox
            // 
            this.Container_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_pictureBox.Location = new System.Drawing.Point(10, 10);
            this.Container_pictureBox.Name = "Container_pictureBox";
            this.Container_pictureBox.Size = new System.Drawing.Size(664, 517);
            this.Container_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Container_pictureBox.TabIndex = 0;
            this.Container_pictureBox.TabStop = false;
            // 
            // FilledContainer_pictureBox
            // 
            this.FilledContainer_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledContainer_pictureBox.Location = new System.Drawing.Point(10, 10);
            this.FilledContainer_pictureBox.Name = "FilledContainer_pictureBox";
            this.FilledContainer_pictureBox.Size = new System.Drawing.Size(662, 517);
            this.FilledContainer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilledContainer_pictureBox.TabIndex = 0;
            this.FilledContainer_pictureBox.TabStop = false;
            // 
            // Methods_flowLayoutPanel
            // 
            this.Methods_flowLayoutPanel.AutoSize = true;
            this.Methods_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Methods_flowLayoutPanel.Controls.Add(this.SimpleMethod_radioButton);
            this.Methods_flowLayoutPanel.Controls.Add(this.BitsSkippingMethod_radioButton);
            this.Methods_flowLayoutPanel.Controls.Add(this.BitsRandSkippingMethod_radioButton);
            this.Methods_flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Methods_flowLayoutPanel.Location = new System.Drawing.Point(667, 122);
            this.Methods_flowLayoutPanel.Name = "Methods_flowLayoutPanel";
            this.Methods_flowLayoutPanel.Size = new System.Drawing.Size(413, 92);
            this.Methods_flowLayoutPanel.TabIndex = 16;
            // 
            // SimpleMethod_radioButton
            // 
            this.SimpleMethod_radioButton.AutoSize = true;
            this.SimpleMethod_radioButton.Checked = true;
            this.SimpleMethod_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleMethod_radioButton.Location = new System.Drawing.Point(3, 3);
            this.SimpleMethod_radioButton.Name = "SimpleMethod_radioButton";
            this.SimpleMethod_radioButton.Size = new System.Drawing.Size(195, 24);
            this.SimpleMethod_radioButton.TabIndex = 0;
            this.SimpleMethod_radioButton.TabStop = true;
            this.SimpleMethod_radioButton.Text = "Простейший метод";
            this.SimpleMethod_radioButton.UseVisualStyleBackColor = true;
            this.SimpleMethod_radioButton.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // BitsSkippingMethod_radioButton
            // 
            this.BitsSkippingMethod_radioButton.AutoSize = true;
            this.BitsSkippingMethod_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitsSkippingMethod_radioButton.Location = new System.Drawing.Point(3, 33);
            this.BitsSkippingMethod_radioButton.Name = "BitsSkippingMethod_radioButton";
            this.BitsSkippingMethod_radioButton.Size = new System.Drawing.Size(248, 24);
            this.BitsSkippingMethod_radioButton.TabIndex = 1;
            this.BitsSkippingMethod_radioButton.Text = "Метод с пропуском битов";
            this.BitsSkippingMethod_radioButton.UseVisualStyleBackColor = true;
            this.BitsSkippingMethod_radioButton.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // BitsRandSkippingMethod_radioButton
            // 
            this.BitsRandSkippingMethod_radioButton.AutoSize = true;
            this.BitsRandSkippingMethod_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BitsRandSkippingMethod_radioButton.Location = new System.Drawing.Point(3, 63);
            this.BitsRandSkippingMethod_radioButton.Name = "BitsRandSkippingMethod_radioButton";
            this.BitsRandSkippingMethod_radioButton.Size = new System.Drawing.Size(405, 24);
            this.BitsRandSkippingMethod_radioButton.TabIndex = 2;
            this.BitsRandSkippingMethod_radioButton.Text = "Метод с псевдослучайным пропуском битов";
            this.BitsRandSkippingMethod_radioButton.UseVisualStyleBackColor = true;
            this.BitsRandSkippingMethod_radioButton.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // EndNumber_nud
            // 
            this.EndNumber_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndNumber_nud.Location = new System.Drawing.Point(905, 84);
            this.EndNumber_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumber_nud.Name = "EndNumber_nud";
            this.EndNumber_nud.Size = new System.Drawing.Size(175, 30);
            this.EndNumber_nud.TabIndex = 15;
            this.EndNumber_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumber_nud.Visible = false;
            this.EndNumber_nud.ValueChanged += new System.EventHandler(this.EndNumber_nud_ValueChanged);
            // 
            // InfoEndNumber_label
            // 
            this.InfoEndNumber_label.AutoSize = true;
            this.InfoEndNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoEndNumber_label.Location = new System.Drawing.Point(671, 86);
            this.InfoEndNumber_label.Name = "InfoEndNumber_label";
            this.InfoEndNumber_label.Size = new System.Drawing.Size(228, 25);
            this.InfoEndNumber_label.TabIndex = 14;
            this.InfoEndNumber_label.Text = "Макс. число пропусков:";
            this.InfoEndNumber_label.Visible = false;
            // 
            // BeginNumber_nud
            // 
            this.BeginNumber_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginNumber_nud.Location = new System.Drawing.Point(905, 48);
            this.BeginNumber_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginNumber_nud.Name = "BeginNumber_nud";
            this.BeginNumber_nud.Size = new System.Drawing.Size(175, 30);
            this.BeginNumber_nud.TabIndex = 13;
            this.BeginNumber_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginNumber_nud.Visible = false;
            this.BeginNumber_nud.ValueChanged += new System.EventHandler(this.BeginNumber_nud_ValueChanged);
            // 
            // ColorChannel_label
            // 
            this.ColorChannel_label.AutoSize = true;
            this.ColorChannel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorChannel_label.Location = new System.Drawing.Point(868, 13);
            this.ColorChannel_label.Name = "ColorChannel_label";
            this.ColorChannel_label.Size = new System.Drawing.Size(73, 25);
            this.ColorChannel_label.TabIndex = 12;
            this.ColorChannel_label.Text = "Канал:";
            // 
            // InfoBeginNumber_label
            // 
            this.InfoBeginNumber_label.AutoSize = true;
            this.InfoBeginNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBeginNumber_label.Location = new System.Drawing.Point(679, 50);
            this.InfoBeginNumber_label.Name = "InfoBeginNumber_label";
            this.InfoBeginNumber_label.Size = new System.Drawing.Size(220, 25);
            this.InfoBeginNumber_label.TabIndex = 10;
            this.InfoBeginNumber_label.Text = "Мин. число пропусков:";
            this.InfoBeginNumber_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoBeginNumber_label.Visible = false;
            // 
            // ContainerPath_textBox
            // 
            this.ContainerPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_textBox.Location = new System.Drawing.Point(127, 7);
            this.ContainerPath_textBox.Name = "ContainerPath_textBox";
            this.ContainerPath_textBox.ReadOnly = true;
            this.ContainerPath_textBox.Size = new System.Drawing.Size(735, 30);
            this.ContainerPath_textBox.TabIndex = 9;
            this.ContainerPath_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Container_textBox_MouseDoubleClick);
            // 
            // ContainerPath_label
            // 
            this.ContainerPath_label.AutoSize = true;
            this.ContainerPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_label.Location = new System.Drawing.Point(2, 10);
            this.ContainerPath_label.Name = "ContainerPath_label";
            this.ContainerPath_label.Size = new System.Drawing.Size(119, 25);
            this.ContainerPath_label.TabIndex = 8;
            this.ContainerPath_label.Text = "Контейнер:";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Enabled = false;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(1095, 150);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(264, 63);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Сброс";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // SaveFillContainer_button
            // 
            this.SaveFillContainer_button.Enabled = false;
            this.SaveFillContainer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveFillContainer_button.Location = new System.Drawing.Point(1095, 81);
            this.SaveFillContainer_button.Name = "SaveFillContainer_button";
            this.SaveFillContainer_button.Size = new System.Drawing.Size(264, 63);
            this.SaveFillContainer_button.TabIndex = 6;
            this.SaveFillContainer_button.Text = "Сохранить контейнер со скрытым сообщением";
            this.SaveFillContainer_button.UseVisualStyleBackColor = true;
            this.SaveFillContainer_button.Click += new System.EventHandler(this.SaveFillContainer_button_Click);
            // 
            // Message_textBox
            // 
            this.Message_textBox.Enabled = false;
            this.Message_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_textBox.Location = new System.Drawing.Point(7, 68);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(654, 146);
            this.Message_textBox.TabIndex = 5;
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_label.Location = new System.Drawing.Point(2, 40);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(263, 25);
            this.Message_label.TabIndex = 4;
            this.Message_label.Text = "Встраиваемое сообщение:";
            // 
            // FillContainer_button
            // 
            this.FillContainer_button.Enabled = false;
            this.FillContainer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillContainer_button.Location = new System.Drawing.Point(1095, 12);
            this.FillContainer_button.Name = "FillContainer_button";
            this.FillContainer_button.Size = new System.Drawing.Size(264, 63);
            this.FillContainer_button.TabIndex = 2;
            this.FillContainer_button.Text = "Произвести внедрение";
            this.FillContainer_button.UseVisualStyleBackColor = true;
            this.FillContainer_button.Click += new System.EventHandler(this.FillContainer_button_Click);
            // 
            // RGB_flowLayoutPanel
            // 
            this.RGB_flowLayoutPanel.AutoSize = true;
            this.RGB_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RGB_flowLayoutPanel.Controls.Add(this.Red_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Green_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Blue_radioButton);
            this.RGB_flowLayoutPanel.Location = new System.Drawing.Point(943, 13);
            this.RGB_flowLayoutPanel.Name = "RGB_flowLayoutPanel";
            this.RGB_flowLayoutPanel.Size = new System.Drawing.Size(137, 29);
            this.RGB_flowLayoutPanel.TabIndex = 0;
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
            // EmbedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 770);
            this.Controls.Add(this.Main_splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EmbedMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внедрение сообщения";
            this.Main_splitContainer.Panel1.ResumeLayout(false);
            this.Main_splitContainer.Panel2.ResumeLayout(false);
            this.Main_splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).EndInit();
            this.Main_splitContainer.ResumeLayout(false);
            this.Containers_splitContainer.Panel1.ResumeLayout(false);
            this.Containers_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Containers_splitContainer)).EndInit();
            this.Containers_splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Container_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).EndInit();
            this.Methods_flowLayoutPanel.ResumeLayout(false);
            this.Methods_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginNumber_nud)).EndInit();
            this.RGB_flowLayoutPanel.ResumeLayout(false);
            this.RGB_flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_splitContainer;
        private System.Windows.Forms.SplitContainer Containers_splitContainer;
        private System.Windows.Forms.FlowLayoutPanel RGB_flowLayoutPanel;
        private System.Windows.Forms.RadioButton Red_radioButton;
        private System.Windows.Forms.RadioButton Green_radioButton;
        private System.Windows.Forms.RadioButton Blue_radioButton;
        private System.Windows.Forms.Button FillContainer_button;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.PictureBox Container_pictureBox;
        private System.Windows.Forms.PictureBox FilledContainer_pictureBox;
        private System.Windows.Forms.Button SaveFillContainer_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.TextBox ContainerPath_textBox;
        private System.Windows.Forms.Label ContainerPath_label;
        private System.Windows.Forms.Label ColorChannel_label;
        private System.Windows.Forms.Label InfoBeginNumber_label;
        private System.Windows.Forms.NumericUpDown BeginNumber_nud;
        private System.Windows.Forms.NumericUpDown EndNumber_nud;
        private System.Windows.Forms.Label InfoEndNumber_label;
        private System.Windows.Forms.FlowLayoutPanel Methods_flowLayoutPanel;
        private System.Windows.Forms.RadioButton SimpleMethod_radioButton;
        private System.Windows.Forms.RadioButton BitsSkippingMethod_radioButton;
        private System.Windows.Forms.RadioButton BitsRandSkippingMethod_radioButton;
    }
}

