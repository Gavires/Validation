using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public partial class WindowMain : Form
    {
       public User users { get; set; }
        public DataBaseContext<Equipment> equipment;
        public WindowMain()
        {
            InitializeComponent();
            equipment = new DataBaseContext<Equipment>("EquipmentEntity");
            equipment.EquipmentDBase.Load();
            dataGridViewUser.DataSource = equipment.EquipmentDBase.Local.ToBindingList();
        }

        private void WindowMain_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Program.windowInitial.Close();
        }

        private void PUserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewUser
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var equipmentRead = new WindowEquipmentRead();
            //equipmentRead.user = users;
            equipmentRead.Show();
            Hide();

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        

    }
}
