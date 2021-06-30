using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public partial class WindowUserIN : Form
    {
        public bool UserNameFlag { get; set; } = false;
        public bool UserPasswordFlag { get; set; } = false;
        public AuthorizationUser users { get; set; } = new AuthorizationUser();
        public User usersIn;
        public WindowUserIN()
        {
            InitializeComponent();
        }
        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (users.IdentifUser(UserName.Text) != null)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
            }
        }
        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void OkUserIN_Click(object sender, EventArgs e)
        {
            var user = users.IdentifUser(UserName.Text);
            if ( user!= null)
            {
                if (user.Password == UserPassword.Text) 
                {
                    UserNameFlag = true;
                    UserPasswordFlag = true;
                    usersIn = user;
                    usersIn.loginStatus = true;  
                    Close();
                }
                else
                {
                    _ = MessageBox.Show("Неверная пара логин пароль!");
                }
            }
            else
            {
                _ = MessageBox.Show("Пользователя не существует");
            }

        }
        private void progressUserIN_Click(object sender, EventArgs e)
        {
         
        }

        private void WindowUserIN_Load(object sender, EventArgs e)
        {

        }

        private void ExitUserIN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы точно хотите выйти?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();

            this.TopMost = true;
        }
    }
}
