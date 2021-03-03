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
        private bool UserNameFlag { get; set; } = false;
        private bool UserPasswordFlag { get; set; } = false;
        public WindowUserIN()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text == "Igor")
            {
                progressUserIN.Value += 50;
                UserNameFlag = true;
            }
            else
            {
                if (progressUserIN.Value >= 50)
                {
                    progressUserIN.Value -= 50;
                }
            }
        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            if (UserPassword.Text == "GRekIS.exe")
            {
                progressUserIN.Value += 50;
                UserPasswordFlag = true;
            }
            else
            {
                if (progressUserIN.Value > 50)
                {
                    progressUserIN.Value -= 50;
                }
            }
        }
        private void OkUserIN_Click(object sender, EventArgs e)
        {
            if (UserPasswordFlag && UserNameFlag)
            {
                //MessageBox.Show("Вход .....");
                var windowMain = new WindowMain();
                windowMain.Show();
                Hide();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Неверная пара пароль - логин");
            }
        }

        private void progressUserIN_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
