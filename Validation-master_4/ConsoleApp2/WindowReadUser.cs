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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Program.userService.ChekReal(UserName.Text) == null)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
           
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            if (UserPasswordClon.Text == UserPassword.Text)
            {
                Program.userService.CreateUser(UserName.Text, Name_User.Text, UserPassword.Text);
                MessageBox.Show("Пользователь успешно создан", "Авторизация");
                Close();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка");
            }
        }

        private void UserPasswordClon_TextChanged(object sender, EventArgs e)
        {
            if (UserPasswordClon.Text!= UserPassword.Text)
            {
                ErrorPasswordClone.Visible = true;
            }
            else
            {
                ErrorPasswordClone.Visible = false;
            }
        }

        private void ErrorPasswordClone_Click(object sender, EventArgs e)
        {
            
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

        }

        private void WindowReadUser_Load(object sender, EventArgs e)
        {

        }
    }
}
