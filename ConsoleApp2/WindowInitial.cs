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
                //MessageBox.Show(Program.userService.Users[1].Password);
                var windowMain = new WindowMain();
                windowMain.Show();
                Hide();
               
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
