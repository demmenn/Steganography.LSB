﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.Main_splitContainer)).BeginInit();
            this.Main_splitContainer.Panel1.SuspendLayout();
            this.Main_splitContainer.Panel2.SuspendLayout();
            this.Main_splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilledContainer_pictureBox)).BeginInit();
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
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_textBox);
            this.Main_splitContainer.Panel2.Controls.Add(this.ContainerPath_label);
            this.Main_splitContainer.Panel2.Controls.Add(this.ExtractMessage_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Cancel_button);
            this.Main_splitContainer.Panel2.Controls.Add(this.Message_label);
            this.Main_splitContainer.Size = new System.Drawing.Size(1182, 653);
            this.Main_splitContainer.SplitterDistance = 425;
            this.Main_splitContainer.SplitterWidth = 1;
            this.Main_splitContainer.TabIndex = 0;
            // 
            // FilledContainer_pictureBox
            // 
            this.FilledContainer_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledContainer_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.FilledContainer_pictureBox.Name = "FilledContainer_pictureBox";
            this.FilledContainer_pictureBox.Size = new System.Drawing.Size(1180, 423);
            this.FilledContainer_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilledContainer_pictureBox.TabIndex = 0;
            this.FilledContainer_pictureBox.TabStop = false;
            // 
            // ContainerPath_textBox
            // 
            this.ContainerPath_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContainerPath_textBox.Location = new System.Drawing.Point(397, 10);
            this.ContainerPath_textBox.Name = "ContainerPath_textBox";
            this.ContainerPath_textBox.ReadOnly = true;
            this.ContainerPath_textBox.Size = new System.Drawing.Size(404, 30);
            this.ContainerPath_textBox.TabIndex = 15;
            this.ContainerPath_textBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ContainerPath_textBox_MouseDoubleClick);
            // 
            // Message_textBox
            // 
            this.Message_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_textBox.Location = new System.Drawing.Point(142, 73);
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
            this.ContainerPath_label.Location = new System.Drawing.Point(137, 13);
            this.ContainerPath_label.Name = "ContainerPath_label";
            this.ContainerPath_label.Size = new System.Drawing.Size(254, 25);
            this.ContainerPath_label.TabIndex = 14;
            this.ContainerPath_label.Text = "Контейнер с сообщением";
            // 
            // ExtractMessage_button
            // 
            this.ExtractMessage_button.Enabled = false;
            this.ExtractMessage_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExtractMessage_button.Location = new System.Drawing.Point(807, 10);
            this.ExtractMessage_button.Name = "ExtractMessage_button";
            this.ExtractMessage_button.Size = new System.Drawing.Size(264, 63);
            this.ExtractMessage_button.TabIndex = 10;
            this.ExtractMessage_button.Text = "Произвести извлечение";
            this.ExtractMessage_button.UseVisualStyleBackColor = true;
            this.ExtractMessage_button.Click += new System.EventHandler(this.ExtractMessage_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Enabled = false;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel_button.Location = new System.Drawing.Point(807, 79);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(264, 63);
            this.Cancel_button.TabIndex = 13;
            this.Cancel_button.Text = "Сброс";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message_label.Location = new System.Drawing.Point(137, 45);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(249, 25);
            this.Message_label.TabIndex = 11;
            this.Message_label.Text = "Сообщение в контейнере";
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
    }
}

