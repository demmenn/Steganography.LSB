﻿
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
            this.InfoNumber_label = new System.Windows.Forms.Label();
            this.ColorChannel_label = new System.Windows.Forms.Label();
            this.Number_numericUpDown = new System.Windows.Forms.NumericUpDown();
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
            this.RGB_flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).BeginInit();
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
            this.Main_splitContainer.Panel2.Controls.Add(this.Number_numericUpDown);
            this.Main_splitContainer.Panel2.Controls.Add(this.ColorChannel_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.InfoNumber_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.Cancel_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.SaveFillContainer_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.FillContainer_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.RGB_flowLayoutPanel);
            this.Main_splitContainer.Size = new System.Drawing.Size(1182, 653);
            this.Main_splitContainer.SplitterDistance = 422;
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
            this.Containers_splitContainer.Size = new System.Drawing.Size(1182, 422);
            this.Containers_splitContainer.SplitterDistance = 592;
            this.Containers_splitContainer.SplitterWidth = 1;
            this.Containers_splitContainer.TabIndex = 0;
            // 
            // Container_pictureBox
            // 
            this.Container_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_pictureBox.Location = new System.Drawing.Point(10, 10);
            this.Container_pictureBox.Name = "Container_pictureBox";
            this.Container_pictureBox.Size = new System.Drawing.Size(570, 400);
            this.Container_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Container_pictureBox.TabIndex = 0;
            this.Container_pictureBox.TabStop = false;
            // 
            // FilledContainer_pictureBox
            // 
            this.FilledContainer_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledContainer_pictureBox.Location = new System.Drawing.Point(10, 10);
            this.FilledContainer_pictureBox.Name = "FilledContainer_pictureBox";
            this.FilledContainer_pictureBox.Size = new System.Drawing.Size(567, 400);
            this.FilledContainer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilledContainer_pictureBox.TabIndex = 0;
            this.FilledContainer_pictureBox.TabStop = false;
            // 
            // ContainerPath_textBox
            // 
            this.ContainerPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_textBox.Location = new System.Drawing.Point(130, 10);
            this.ContainerPath_textBox.Name = "ContainerPath_textBox";
            this.ContainerPath_textBox.ReadOnly = true;
            this.ContainerPath_textBox.Size = new System.Drawing.Size(404, 30);
            this.ContainerPath_textBox.TabIndex = 9;
            this.ContainerPath_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Container_textBox_MouseDoubleClick);
            // 
            // ContainerPath_label
            // 
            this.ContainerPath_label.AutoSize = true;
            this.ContainerPath_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_label.Location = new System.Drawing.Point(11, 14);
            this.ContainerPath_label.Name = "ContainerPath_label";
            this.ContainerPath_label.Size = new System.Drawing.Size(119, 25);
            this.ContainerPath_label.TabIndex = 8;
            this.ContainerPath_label.Text = "Контейнер:";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Enabled = false;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(857, 150);
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
            this.SaveFillContainer_button.Location = new System.Drawing.Point(857, 81);
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
            this.Message_textBox.Location = new System.Drawing.Point(16, 70);
            this.Message_textBox.Multiline = true;
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.Size = new System.Drawing.Size(518, 141);
            this.Message_textBox.TabIndex = 5;
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_label.Location = new System.Drawing.Point(11, 42);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(263, 25);
            this.Message_label.TabIndex = 4;
            this.Message_label.Text = "Встраиваемое сообщение:";
            // 
            // FillContainer_button
            // 
            this.FillContainer_button.Enabled = false;
            this.FillContainer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillContainer_button.Location = new System.Drawing.Point(857, 12);
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
            this.RGB_flowLayoutPanel.Location = new System.Drawing.Point(659, 48);
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
            // InfoNumber_label
            // 
            this.InfoNumber_label.AutoSize = true;
            this.InfoNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoNumber_label.Location = new System.Drawing.Point(540, 13);
            this.InfoNumber_label.Name = "InfoNumber_label";
            this.InfoNumber_label.Size = new System.Drawing.Size(75, 25);
            this.InfoNumber_label.TabIndex = 10;
            this.InfoNumber_label.Text = "Число:";
            // 
            // ColorChannel_label
            // 
            this.ColorChannel_label.AutoSize = true;
            this.ColorChannel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorChannel_label.Location = new System.Drawing.Point(540, 52);
            this.ColorChannel_label.Name = "ColorChannel_label";
            this.ColorChannel_label.Size = new System.Drawing.Size(119, 25);
            this.ColorChannel_label.TabIndex = 12;
            this.ColorChannel_label.Text = "Контейнер:";
            // 
            // Number_numericUpDown
            // 
            this.Number_numericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number_numericUpDown.Location = new System.Drawing.Point(621, 12);
            this.Number_numericUpDown.Name = "Number_numericUpDown";
            this.Number_numericUpDown.Size = new System.Drawing.Size(175, 30);
            this.Number_numericUpDown.TabIndex = 13;
            // 
            // EmbedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
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
            this.RGB_flowLayoutPanel.ResumeLayout(false);
            this.RGB_flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Number_numericUpDown)).EndInit();
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
        private System.Windows.Forms.Label InfoNumber_label;
        private System.Windows.Forms.NumericUpDown Number_numericUpDown;
    }
}

