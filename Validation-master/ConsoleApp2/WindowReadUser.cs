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
    public partial class WindowReadUser : Form
    {
        public WindowReadUser()
        {
            InitializeComponent();
        }
        public AuthorizationUser UsersWReadUser { get; set; } = new AuthorizationUser(); 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (UsersWReadUser.IdentifUser(UserName.Text) == null)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                ErrorUserName.Visible = false;
                TrueUserName.Text = "Этот логин свободен!";
                TrueUserName.Visible = true;
                ErrorUserName.Visible = false;
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                TrueUserName.Visible = false;
                ErrorUserName.Text = "Пользователь с таким именем уже существет!";
                ErrorUserName.Visible = true;
            }
        }
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible && pictureBox3.Visible)
            {
                var userService = UsersWReadUser.CreateUserService(UserName.Text, UserPassword.Text);
                userService.CreateUser(UserName.Text, Name_User.Text, UserPassword.Text);
                MessageBox.Show("Пользователь успешно создан", "Авторизация");
                Close();
            }
            else
            {
                MessageBox.Show("Неверно заполнены поля!", "Ошибка");
            }
        }
        private void UserPasswordClon_TextChanged(object sender, EventArgs e)
        {
            TrueUserName.Visible = false;
            if (UserPassword.Text == UserPasswordClon.Text)
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                ErrorPasswordClone.Visible = false;
            }
            else
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                ErrorPasswordClone.Visible = true;
            }
        }
        private void ErrorPasswordClone_Click(object sender, EventArgs e)
        {
            TrueUserName.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Name_User.Text = "";
            UserPassword.Text = "";
            UserPasswordClon.Text = "";
            TrueUserName.Visible = false;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Вы точно хотите отменить авторизацию?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();

            TopMost = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void NameUser_TextChanged(object sender, EventArgs e)
        {
            TrueUserName.Visible = false;
        }

        private void WindowReadUser_Load(object sender, EventArgs e)
        {

        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            TrueUserName.Visible = false;
        }
    }
}
