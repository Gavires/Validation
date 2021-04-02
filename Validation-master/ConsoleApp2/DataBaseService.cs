using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public class DataBaseService
    {
        public UserContext UsersEntityNew { get; set; } = new UserContext();
        public User AddDB(User user)
        {
                // добавляем в бд
                UsersEntityNew.UsersNew.Add(user);
                UsersEntityNew.SaveChanges();
                MessageBox.Show("Объекты успешно сохранены");
            return user;
        }
        public User ReturnUser(string userName)
        {
            return UsersEntityNew.UsersNew.Find(userName);
        }

        /*public User SearchEntity(User user)
        {

        }*/
    }
}
