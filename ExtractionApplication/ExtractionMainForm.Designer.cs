
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
            this.ChooseContainer_button = new System.Windows.Forms.Button();
            this.MethodInfo_label = new System.Windows.Forms.Label();
            this.ChoosedMethod_comboBox = new System.Windows.Forms.ComboBox();
            this.EndNumber_nud = new System.Windows.Forms.NumericUpDown();
            this.InfoEndNumber_label = new System.Windows.Forms.Label();
            this.BeginNumber_nud = new System.Windows.Forms.NumericUpDown();
            this.ColorChannel_label = new System.Windows.Forms.Label();
            this.InfoBeginNumber_label = new System.Windows.Forms.Label();
            this.RGB_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Red_radioButton = new System.Windows.Forms.RadioButton();
            this.Green_radioButton = new System.Windows.Forms.RadioButton();
            this.Blue_radioButton = new System.Windows.Forms.RadioButton();
            this.ContainerPath_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.ContainerPath_label = new System.Windows.Forms.Label();
            this.ExtractMessage_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Message_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).BeginInit();
            this.Main_splitContainer.Panel1.SuspendLayout();
            this.Main_splitContainer.Panel2.SuspendLayout();
            this.Main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).BeginInit();
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
            this.Main_splitContainer.Panel1.Controls.Add(this.FilledContainer_pictureBox);
            // 
            // Main_splitContainer.Panel2
            // 
            this.Main_splitContainer.Panel2.Controls.Add(this.ChooseContainer_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.MethodInfo_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ChoosedMethod_comboBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.EndNumber_nud);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoEndNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.BeginNumber_nud);
            this.Main_splitContainer.Panel2.Controls.Add(this.ColorChannel_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoBeginNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.RGB_flowLayoutPanel);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ExtractMessage_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Cancel_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_label);
            this.Main_splitContainer.Size = new System.Drawing.Size(1371, 770);
            this.Main_splitContainer.SplitterDistance = 557;
            this.Main_splitContainer.SplitterWidth = 1;
            this.Main_splitContainer.TabIndex = 0;
            // 
            // FilledContainer_pictureBox
            // 
            this.FilledContainer_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledContainer_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.FilledContainer_pictureBox.Name = "FilledContainer_pictureBox";
            this.FilledContainer_pictureBox.Size = new System.Drawing.Size(1369, 555);
            this.FilledContainer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilledContainer_pictureBox.TabIndex = 0;
            this.FilledContainer_pictureBox.TabStop = false;
            // 
            // ChooseContainer_button
            // 
            this.ChooseContainer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseContainer_button.Location = new System.Drawing.Point(583, 7);
            this.ChooseContainer_button.Name = "ChooseContainer_button";
            this.ChooseContainer_button.Size = new System.Drawing.Size(70, 30);
            this.ChooseContainer_button.TabIndex = 27;
            this.ChooseContainer_button.Text = "Выбор";
            this.ChooseContainer_button.UseVisualStyleBackColor = true;
            this.ChooseContainer_button.Click += new System.EventHandler(this.ChooseContainer_button_Click);
            // 
            // MethodInfo_label
            // 
            this.MethodInfo_label.AutoSize = true;
            this.MethodInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodInfo_label.Location = new System.Drawing.Point(659, 10);
            this.MethodInfo_label.Name = "MethodInfo_label";
            this.MethodInfo_label.Size = new System.Drawing.Size(80, 25);
            this.MethodInfo_label.TabIndex = 26;
            this.MethodInfo_label.Text = "Метод:";
            // 
            // ChoosedMethod_comboBox
            // 
            this.ChoosedMethod_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosedMethod_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosedMethod_comboBox.FormattingEnabled = true;
            this.ChoosedMethod_comboBox.Items.AddRange(new object[] {
            "Простейший метод",
            "Метод с пропуском битов",
            "Метод со случ. пропуском битов",
            "Блочный метод"});
            this.ChoosedMethod_comboBox.Location = new System.Drawing.Point(745, 7);
            this.ChoosedMethod_comboBox.Name = "ChoosedMethod_comboBox";
            this.ChoosedMethod_comboBox.Size = new System.Drawing.Size(332, 33);
            this.ChoosedMethod_comboBox.TabIndex = 25;
            this.ChoosedMethod_comboBox.SelectedIndexChanged += new System.EventHandler(this.MethodChanged);
            // 
            // EndNumber_nud
            // 
            this.EndNumber_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndNumber_nud.Location = new System.Drawing.Point(902, 117);
            this.EndNumber_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumber_nud.Name = "EndNumber_nud";
            this.EndNumber_nud.Size = new System.Drawing.Size(175, 30);
            this.EndNumber_nud.TabIndex = 24;
            this.EndNumber_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumber_nud.Visible = false;
            // 
            // InfoEndNumber_label
            // 
            this.InfoEndNumber_label.AutoSize = true;
            this.InfoEndNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoEndNumber_label.Location = new System.Drawing.Point(750, 119);
            this.InfoEndNumber_label.Name = "InfoEndNumber_label";
            this.InfoEndNumber_label.Size = new System.Drawing.Size(146, 25);
            this.InfoEndNumber_label.TabIndex = 23;
            this.InfoEndNumber_label.Text = "Высота блока:";
            this.InfoEndNumber_label.Visible = false;
            // 
            // BeginNumber_nud
            // 
            this.BeginNumber_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginNumber_nud.Location = new System.Drawing.Point(902, 81);
            this.BeginNumber_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginNumber_nud.Name = "BeginNumber_nud";
            this.BeginNumber_nud.Size = new System.Drawing.Size(175, 30);
            this.BeginNumber_nud.TabIndex = 22;
            this.BeginNumber_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BeginNumber_nud.Visible = false;
            // 
            // ColorChannel_label
            // 
            this.ColorChannel_label.AutoSize = true;
            this.ColorChannel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorChannel_label.Location = new System.Drawing.Point(861, 50);
            this.ColorChannel_label.Name = "ColorChannel_label";
            this.ColorChannel_label.Size = new System.Drawing.Size(73, 25);
            this.ColorChannel_label.TabIndex = 21;
            this.ColorChannel_label.Text = "Канал:";
            // 
            // InfoBeginNumber_label
            // 
            this.InfoBeginNumber_label.AutoSize = true;
            this.InfoBeginNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoBeginNumber_label.Location = new System.Drawing.Point(749, 83);
            this.InfoBeginNumber_label.Name = "InfoBeginNumber_label";
            this.InfoBeginNumber_label.Size = new System.Drawing.Size(147, 25);
            this.InfoBeginNumber_label.TabIndex = 20;
            this.InfoBeginNumber_label.Text = "Ширина блока:";
            this.InfoBeginNumber_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoBeginNumber_label.Visible = false;
            // 
            // RGB_flowLayoutPanel
            // 
            this.RGB_flowLayoutPanel.AutoSize = true;
            this.RGB_flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RGB_flowLayoutPanel.Controls.Add(this.Red_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Green_radioButton);
            this.RGB_flowLayoutPanel.Controls.Add(this.Blue_radioButton);
            this.RGB_flowLayoutPanel.Location = new System.Drawing.Point(940, 46);
            this.RGB_flowLayoutPanel.Name = "RGB_flowLayoutPanel";
            this.RGB_flowLayoutPanel.Size = new System.Drawing.Size(137, 29);
            this.RGB_flowLayoutPanel.TabIndex = 19;
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
            // ContainerPath_textBox
            // 
            this.ContainerPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_textBox.Location = new System.Drawing.Point(136, 7);
            this.ContainerPath_textBox.Name = "ContainerPath_textBox";
            this.ContainerPath_textBox.ReadOnly = true;
            this.ContainerPath_textBox.Size = new System.Drawing.Size(441, 30);
            this.ContainerPath_textBox.TabIndex = 15;
            // 
            // Message_textBox
            // 
            this.Message_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_textBox.Location = new System.Drawing.Point(16, 68);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.ReadOnly = true;
            this.Message_textBox.Size = new System.Drawing.Size(637, 141);
            this.Message_textBox.TabIndex = 12;
            // 
            // ContainerPath_label
            // 
            this.ContainerPath_label.AutoSize = true;
            this.ContainerPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_label.Location = new System.Drawing.Point(11, 10);
            this.ContainerPath_label.Name = "ContainerPath_label";
            this.ContainerPath_label.Size = new System.Drawing.Size(119, 25);
            this.ContainerPath_label.TabIndex = 14;
            this.ContainerPath_label.Text = "Контейнер:";
            // 
            // ExtractMessage_button
            // 
            this.ExtractMessage_button.Enabled = false;
            this.ExtractMessage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractMessage_button.Location = new System.Drawing.Point(1083, 7);
            this.ExtractMessage_button.Name = "ExtractMessage_button";
            this.ExtractMessage_button.Size = new System.Drawing.Size(275, 63);
            this.ExtractMessage_button.TabIndex = 10;
            this.ExtractMessage_button.Text = "Произвести извлечение";
            this.ExtractMessage_button.UseVisualStyleBackColor = true;
            this.ExtractMessage_button.Click += new System.EventHandler(this.ExtractMessage_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Enabled = false;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(1083, 76);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(275, 63);
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
            // ExtractionMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 770);
            this.Controls.Add(this.Main_splitContainer);
            this.Name = "ExtractionMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Main_splitContainer.Panel1.ResumeLayout(false);
            this.Main_splitContainer.Panel2.ResumeLayout(false);
            this.Main_splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).EndInit();
            this.Main_splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumber_nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeginNumber_nud)).EndInit();
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
        private System.Windows.Forms.Label MethodInfo_label;
        private System.Windows.Forms.ComboBox ChoosedMethod_comboBox;
        private System.Windows.Forms.NumericUpDown EndNumber_nud;
        private System.Windows.Forms.Label InfoEndNumber_label;
        private System.Windows.Forms.NumericUpDown BeginNumber_nud;
        private System.Windows.Forms.Label ColorChannel_label;
        private System.Windows.Forms.Label InfoBeginNumber_label;
        private System.Windows.Forms.FlowLayoutPanel RGB_flowLayoutPanel;
        private System.Windows.Forms.RadioButton Red_radioButton;
        private System.Windows.Forms.RadioButton Green_radioButton;
        private System.Windows.Forms.RadioButton Blue_radioButton;
        private System.Windows.Forms.Button ChooseContainer_button;
    }
}

