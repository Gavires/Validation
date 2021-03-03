
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.OkUserIN = new System.Windows.Forms.Button();
            this.ExitUserIN = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressUserIN = new System.Windows.Forms.ProgressBar();
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
            this.ExitUserIN.Text = "Exit";
            this.ExitUserIN.UseVisualStyleBackColor = true;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(252, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(252, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
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
            // WindowUserIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 191);
            this.Controls.Add(this.progressUserIN);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.ExitUserIN);
            this.Controls.Add(this.OkUserIN);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "WindowUserIN";
            this.Text = "WindowUserIN";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressUserIN;
    }
}