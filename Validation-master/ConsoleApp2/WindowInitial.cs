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
        public bool UserIn {get; set;}
        public WindowInitial()
        {
            InitializeComponent();
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            
            var windowUserIN = new WindowUserIN();
            windowUserIN.ShowDialog();
            if (windowUserIN.UserNameFlag && windowUserIN.UserPasswordFlag)
            {
                var windowMain = new WindowMain();
                windowMain.Show();
                Hide();
                MessageBox.Show("Вход выполнен!", "Вход");
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var acces = new UserDataBaseAccess();
            acces.Open("Names");
        }
        private void buttonAuthorization_Click(object sender, EventArgs e)
        {
            var windowReadUser = new WindowReadUser();
            windowReadUser.Show();
            richTextBox1.Text = "";
            foreach (var user in Program.userService.Users)
            {
                richTextBox1.Text += $"Username = {user.UserName}, Name = {user.Name}, password = {user.Password}, status = {user.loginStatus}\n";
            }
            
            //Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
