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
    public partial class WindowEquipmentRead : Form
    {
        public WindowEquipmentRead()
        {
            InitializeComponent();
        }
        public User user { get; set; }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            var equipmentNew = new EquipmentService();
            equipmentNew.CreatEquipment(user, "1", textBoxNameEquipment.Text, textBoxSerialNumber.Text, textBoxLocation.Text, textBoxStatus.Text, textBoxSerialNumber.Text);
        }

        private void WindowEquipmentRead_Load(object sender, EventArgs e)
        {

        }
    }
}
