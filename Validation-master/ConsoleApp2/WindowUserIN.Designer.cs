
namespace EquipmentQualification
{
    partial class WindowUserIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUserIN));
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.OkUserIN = new System.Windows.Forms.Button();
            this.ExitUserIN = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.progressUserIN = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(15, 51);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(41, 15);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Логин";
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(15, 85);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(49, 15);
            this.labelUserPassword.TabIndex = 1;
            this.labelUserPassword.Text = "Пароль";
            // 
            // OkUserIN
            // 
            this.OkUserIN.Location = new System.Drawing.Point(89, 146);
            this.OkUserIN.Name = "OkUserIN";
            this.OkUserIN.Size = new System.Drawing.Size(75, 23);
            this.OkUserIN.TabIndex = 2;
            this.OkUserIN.Text = "OK";
            this.OkUserIN.UseVisualStyleBackColor = true;
            this.OkUserIN.Click += new System.EventHandler(this.OkUserIN_Click);
            // 
            // ExitUserIN
            // 
            this.ExitUserIN.Location = new System.Drawing.Point(170, 146);
            this.ExitUserIN.Name = "ExitUserIN";
            this.ExitUserIN.Size = new System.Drawing.Size(75, 23);
            this.ExitUserIN.TabIndex = 3;
            this.ExitUserIN.Text = "Отмена";
            this.ExitUserIN.UseVisualStyleBackColor = true;
            this.ExitUserIN.Click += new System.EventHandler(this.ExitUserIN_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(89, 51);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(156, 23);
            this.UserName.TabIndex = 4;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(89, 82);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(156, 23);
            this.UserPassword.TabIndex = 5;
            this.UserPassword.TextChanged += new System.EventHandler(this.UserPassword_TextChanged);
            // 
            // progressUserIN
            // 
            this.progressUserIN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressUserIN.ForeColor = System.Drawing.Color.Lime;
            this.progressUserIN.Location = new System.Drawing.Point(112, 111);
            this.progressUserIN.Name = "progressUserIN";
            this.progressUserIN.Size = new System.Drawing.Size(96, 14);
            this.progressUserIN.Step = 1;
            this.progressUserIN.TabIndex = 8;
            this.progressUserIN.Click += new System.EventHandler(this.progressUserIN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(260, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(260, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // WindowUserIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(332, 189);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressUserIN);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ExitUserIN);
            this.Controls.Add(this.OkUserIN);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "WindowUserIN";
            this.Text = "WindowUserIN";
            this.Load += new System.EventHandler(this.WindowUserIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelUserPassword;
        private System.Windows.Forms.Button OkUserIN;
        private System.Windows.Forms.Button ExitUserIN;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.ProgressBar progressUserIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}