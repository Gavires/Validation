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
    public partial class WindowInitial : Form
    {
        public WindowInitial()
        {
            InitializeComponent();
            using (var ctx = new DataBaseContext<User>("Person"))
            {
                ctx.Database.Initialize(false);
            }
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            
            var windowUserIN = new WindowUserIN();
            windowUserIN.ShowDialog();
            if (windowUserIN.UserNameFlag && windowUserIN.UserPasswordFlag)
            {
                var windowMain = new WindowMain();
                windowMain.users = windowUserIN.usersIn;
                windowMain.richTextBox1.Text = $"Вход выполнен! Логин: {windowMain.users.UserName} Имя: {windowMain.users.Name}";
                windowMain.Show();
                Hide();
                MessageBox.Show("Вход выполнен!", "Вход");
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            var windowReadUser = new WindowReadUser();
            windowReadUser.Show();
            richTextBox1.Text = "";
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var windowMain = new WindowMain();
            /*windowMain.users.AdminStatus = true;
            windowMain.users.Name = "Igor";
            windowMain.users.UserName = "Ingvar";
            windowMain.users.Password = "qwerty1";
            windowMain.users.loginStatus = true;
            windowMain.richTextBox1.Text = $"Вход выполнен! Логин: {windowMain.users.UserName} Имя: {windowMain.users.Name}";*/
            windowMain.richTextBox1.Text = $"Вход выполнен! Тестовый режим!";
            windowMain.Show();
            Hide();
            MessageBox.Show("Вход выполнен!", "Вход");
        }
    }
}
