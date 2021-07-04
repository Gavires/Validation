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
        public int IndexId;
        public void BaseDate(string connection)
        {
            equipment = new DataBaseContext<Equipment>(connection);
            equipment.EquipmentDBase.Load();
            dataGridViewUser.DataSource = equipment.EquipmentDBase.Local.ToBindingList();
            IndexId = dataGridViewUser.Rows.Count;
            textBoxCount.Text = IndexId.ToString();
        }
        public WindowMain()
        {
            InitializeComponent();
            BaseDate("EquipmentEntityTest5");
            
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
            //Hide();

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (users.AdminStatus)
            {
                
            }
            else
            {
                MessageBox.Show("Для совершения действия требуются права администратора! А я так понимаю у Вас их нет?! Да и Вы сам какой-то не очень человек");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<int> flag = new List<int> { };
            List<Equipment> newDbTabl = new List<Equipment> { };
            Equipment newEquipment = new Equipment();
            try
            {
                //((DataTable)dataGridViewUser.DataSource).DefaultView.RowFilter = "Name Like '%" + textBoxSearch.Text.Trim().Replace("'", "''") + "%'";
                for (int i = 0; i < dataGridViewUser.Rows.Count; i++)
                {
                    
                    if (dataGridViewUser[0, i].Value.ToString() == textBoxSearch.Text)
                        flag.Add(i);
                }
                //MessageBox.Show("Вроде как начал поиск", "Поиск инфы");
                //dataGridViewUser.DataSource = flag;
               foreach (var fl in flag)
                {
                    //MessageBox.Show("Вроде как начал поиск", "Поиск инфы");
                    newEquipment.ID = dataGridViewUser[0, fl].Value.ToString();
                    newEquipment.Name = dataGridViewUser[1, fl].Value.ToString();
                    newEquipment.SerialNumber = dataGridViewUser[2, fl].Value.ToString();
                    newEquipment.Location = dataGridViewUser[3, fl].Value.ToString();
                    newEquipment.Status = dataGridViewUser[4, fl].Value.ToString();
                    newEquipment.NumberProtocol = dataGridViewUser[5, fl].Value.ToString();
                    newDbTabl.Add(newEquipment);
                    //MessageBox.Show("Вроде как добавил в лист","Поиск инфы");
                }
                dataGridViewUser.DataSource = newDbTabl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"УПС");
            }         
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                BaseDate("EquipmentEntityTest5");
            }
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }
    }
}
