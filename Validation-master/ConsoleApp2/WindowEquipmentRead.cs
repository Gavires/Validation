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
        public User user { get; set; } = new User();
        private void buttonOK_Click(object sender, EventArgs e)
        {
            var windowMain = new WindowMain();
            string indexId = (windowMain.IndexId + 1).ToString();
            var equipmentService = new EquipmentService();
            equipmentService.CheckEquipmentsId = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment ID already exists!" } } };
            equipmentService.CheckEquipmentsName = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsSerialNumber = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Serial Nunber already exists!" } } };
            equipmentService.CheckEquipmentsLocation = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberStatusQuall = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberProtocol = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Number protocol already exists!" } } };
            
            equipmentService.CreatEquipment(user, indexId, textBoxNameEquipment.Text, textBoxSerialNumber.Text, textBoxLocation.Text, textBoxStatus.Text, textBoxNumberQuall.Text,dateTimePicker1.Value,int.Parse(textBoxYers.Text));

            windowMain.BaseDate("EquipmentEntityTest5");
        }

        private void WindowEquipmentRead_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNameEquipment.Text = "";
            textBoxLocation.Text = "";
            textBoxSerialNumber.Text = "";
            textBoxStatus.Text = "";
            textBoxNumberQuall.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
           "Вы точно хотите отменить?",
           "Сообщение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1,
           MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Close();

            TopMost = true;
        }

        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxYers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
