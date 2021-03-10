
namespace EquipmentQualification
{
    partial class WindowReadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowReadUser));
            this.UserName = new System.Windows.Forms.TextBox();
            this.Name_User = new System.Windows.Forms.TextBox();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserPasswordClon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorPassword = new System.Windows.Forms.Label();
            this.ErrorUserName = new System.Windows.Forms.Label();
            this.ErrorPasswordClone = new System.Windows.Forms.Label();
            this.CheckName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TrueUserName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(127, 68);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(243, 23);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Name_User
            // 
            this.Name_User.Location = new System.Drawing.Point(127, 117);
            this.Name_User.Name = "Name_User";
            this.Name_User.Size = new System.Drawing.Size(243, 23);
            this.Name_User.TabIndex = 1;
            this.Name_User.TextChanged += new System.EventHandler(this.NameUser_TextChanged);
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(127, 165);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(243, 23);
            this.UserPassword.TabIndex = 2;
            this.UserPassword.TextChanged += new System.EventHandler(this.UserPassword_TextChanged);
            // 
            // UserPasswordClon
            // 
            this.UserPasswordClon.Location = new System.Drawing.Point(127, 213);
            this.UserPasswordClon.Name = "UserPasswordClon";
            this.UserPasswordClon.Size = new System.Drawing.Size(243, 23);
            this.UserPasswordClon.TabIndex = 3;
            this.UserPasswordClon.TextChanged += new System.EventHandler(this.UserPasswordClon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Повторите пароль";
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Location = new System.Drawing.Point(112, 295);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(88, 23);
            this.AuthorizationButton.TabIndex = 8;
            this.AuthorizationButton.Text = "Авторизация";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(206, 295);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(85, 23);
            this.ClearAllButton.TabIndex = 9;
            this.ClearAllButton.Text = "Очистить";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(297, 295);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(155, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Включена клавиша \"Caps Lock\"";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ErrorPassword
            // 
            this.ErrorPassword.AutoSize = true;
            this.ErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorPassword.Location = new System.Drawing.Point(127, 191);
            this.ErrorPassword.Name = "ErrorPassword";
            this.ErrorPassword.Size = new System.Drawing.Size(104, 15);
            this.ErrorPassword.TabIndex = 15;
            this.ErrorPassword.Text = "Проверка пароля";
            this.ErrorPassword.Visible = false;
            // 
            // ErrorUserName
            // 
            this.ErrorUserName.AutoSize = true;
            this.ErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.ErrorUserName.Location = new System.Drawing.Point(127, 94);
            this.ErrorUserName.Name = "ErrorUserName";
            this.ErrorUserName.Size = new System.Drawing.Size(125, 15);
            this.ErrorUserName.TabIndex = 16;
            this.ErrorUserName.Text = "проверка поля логин";
            this.ErrorUserName.Visible = false;
            // 
            // ErrorPasswordClone
            // 
            this.ErrorPasswordClone.AutoSize = true;
            this.ErrorPasswordClone.ForeColor = System.Drawing.Color.Red;
            this.ErrorPasswordClone.Location = new System.Drawing.Point(127, 239);
            this.ErrorPasswordClone.Name = "ErrorPasswordClone";
            this.ErrorPasswordClone.Size = new System.Drawing.Size(128, 15);
            this.ErrorPasswordClone.TabIndex = 17;
            this.ErrorPasswordClone.Text = "Пароли не совпадают";
            this.ErrorPasswordClone.Visible = false;
            this.ErrorPasswordClone.Click += new System.EventHandler(this.ErrorPasswordClone_Click);
            // 
            // CheckName
            // 
            this.CheckName.AutoSize = true;
            this.CheckName.ForeColor = System.Drawing.Color.Red;
            this.CheckName.Location = new System.Drawing.Point(127, 143);
            this.CheckName.Name = "CheckName";
            this.CheckName.Size = new System.Drawing.Size(114, 15);
            this.CheckName.TabIndex = 18;
            this.CheckName.Text = "проверка поля имя";
            this.CheckName.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(376, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(376, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(376, 213);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // TrueUserName
            // 
            this.TrueUserName.AutoSize = true;
            this.TrueUserName.ForeColor = System.Drawing.Color.Lime;
            this.TrueUserName.Location = new System.Drawing.Point(127, 94);
            this.TrueUserName.Name = "TrueUserName";
            this.TrueUserName.Size = new System.Drawing.Size(122, 15);
            this.TrueUserName.TabIndex = 24;
            this.TrueUserName.Text = "Этот логин свободен";
            this.TrueUserName.Visible = false;
            // 
            // WindowReadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 330);
            this.Controls.Add(this.TrueUserName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckName);
            this.Controls.Add(this.ErrorPasswordClone);
            this.Controls.Add(this.ErrorUserName);
            this.Controls.Add(this.ErrorPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserPasswordClon);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.Name_User);
            this.Controls.Add(this.UserName);
            this.Name = "WindowReadUser";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowReadUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Name_User;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.TextBox UserPasswordClon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorPassword;
        private System.Windows.Forms.Label ErrorUserName;
        private System.Windows.Forms.Label ErrorPasswordClone;
        private System.Windows.Forms.Label CheckName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TrueUserName;
    }
}