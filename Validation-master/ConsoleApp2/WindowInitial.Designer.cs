﻿
namespace EquipmentQualification
{
    partial class WindowInitial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonIN = new System.Windows.Forms.Button();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIN
            // 
            this.buttonIN.Location = new System.Drawing.Point(67, 299);
            this.buttonIN.Name = "buttonIN";
            this.buttonIN.Size = new System.Drawing.Size(76, 23);
            this.buttonIN.TabIndex = 0;
            this.buttonIN.Text = "Вход";
            this.buttonIN.UseVisualStyleBackColor = true;
            this.buttonIN.Click += new System.EventHandler(this.buttonIN_Click);
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.Location = new System.Drawing.Point(159, 299);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(91, 23);
            this.buttonAuthorization.TabIndex = 1;
            this.buttonAuthorization.Text = "Авторизация";
            this.buttonAuthorization.UseVisualStyleBackColor = true;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorization_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 164);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(419, 299);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(76, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(419, 354);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "Тест вход";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // WindowInitial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 389);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonAuthorization);
            this.Controls.Add(this.buttonIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WindowInitial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowInitial";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIN;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button TestButton;
    }
}