using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentQualification
{
   public class EquipmentDataBaseService
    {
        public DataBaseContext<Equipment> EquipmentEntityNew { get; set; } = new DataBaseContext<Equipment>("EquipmentEntityTest5");
        public Equipment AddDB(Equipment equipment)
        {
            // добавляем в бд
            EquipmentEntityNew.EquipmentDBase.Add(equipment);
            EquipmentEntityNew.SaveChanges();
            MessageBox.Show("Объекты успешно сохранены");
            return equipment;
        }
        public Equipment ReturnEquipment(string info)
        {
            return EquipmentEntityNew.EquipmentDBase.Find(info);
        }

        /*public User SearchEntity(User user)
        {

        }*/
    }
}
