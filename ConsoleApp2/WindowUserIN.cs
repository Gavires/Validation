﻿using System;
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
        public WindowUserIN()
        {
            InitializeComponent();
        }
        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if (UserName.Text.StartsWith(""))
            {
                                
              //progressUserIN.Value += 50;
            
            }
            else
            {
                //progressUserIN.Value = 0;
            }
        }
        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void OkUserIN_Click(object sender, EventArgs e)
        {
            if ((Program.userService.ChekReal(UserName.Text)!=null) && (UserPassword.Text == "g"))
            {
                UserNameFlag = true;
                UserPasswordFlag = true;
                Close();
            }
            else
            {
                _ = MessageBox.Show("Неверная пара логин пароль!");
            }
            
        }

        private void progressUserIN_Click(object sender, EventArgs e)
        {
         
        }

        private void WindowUserIN_Load(object sender, EventArgs e)
        {

        }
    }
}
