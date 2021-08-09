using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public class UserDataBaseService
    {
        public DataBaseContext<User> UsersEntityNew { get; set; } = new DataBaseContext<User> ("newPersonTest3");
        public User AddDB(User user)
        {
                // добавляем в бд
                UsersEntityNew.UserDBase.Add(user);
                UsersEntityNew.SaveChanges();
                MessageBox.Show("Объекты успешно сохранены");
            return user;
        }
        public User ReturnUser(string userName)
        {
            return UsersEntityNew.UserDBase.Find(userName);
        }

        /*public User SearchEntity(User user)
        {

        }*/
    }
}
