using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public class UserService : IUserService
    {
        public UserDataBaseService UsersList { get; set; } = new UserDataBaseService();
        public IChecker<User> PasswordChecker { get; set; }
        public IChecker<User> NameChecker { get; set; }
        public IChecker<User> UserNameChecker { get; set; }
        public IChecker<User> NewPasswordChecker { get; set; }
        public bool Admin { get; set; }
        /*public User ChekReal(string userName)
        {
            foreach (var user in UsersList.UsersEntityNew.UsersNew)
            {
                if (user.UserName == userName)
                {
                    return user;
                }
            }
            return null;
        }*/
        private string CheckValue(IChecker<User> cheker, User user, string oldValue, string newValue, string field)
        {
            //MessageBox.Show("Вход в проверки");
            return !cheker.CheckField(user, oldValue, newValue, out string message) ? throw new Exception($"{field}: {message}") : newValue;
        }
        public void SetPassword(IChecker<User> check, User user, string oldPassword, string newPassword)
        {
            user.Password = CheckValue(check, user, oldPassword, newPassword, $"{user.Name}, Password");
        }
        public User CreateUser(string userName, string name, string password)
        {
            var user = new User();
            //MessageBox.Show ("Экземпляр класса User успешно создан");
            user.UserName = CheckValue(UserNameChecker, UsersList.ReturnUser(userName), "", userName, "UserName");
            //user.UserName = CheckValue(UserNameChecker, ChekReal(userName), "", userName, "UserName");
            //MessageBox.Show ("Логин успешно присвоен");
            user.Name = CheckValue(NameChecker, user, "", name, $"{user.UserName}, Name");
            SetPassword(PasswordChecker, user, "", password);
            user.AdminStatus = Admin;
            return UsersList.AddDB(user);
        }
        public void ResetPassword(string userName, string newUserPassword)
        {
            var user = UsersList.ReturnUser(userName);
            if (user == null)
            {
                Console.WriteLine($"Пользователь с логином {userName} в списке отсутствует");
            }
            else
            {
                SetPassword(NewPasswordChecker,user, user.Password, newUserPassword);
            }
        }
        public void WriteUser(string userName)
        {
            var user = UsersList.ReturnUser(userName);
            if (user == null)
            {
                Console.WriteLine($"Пользователь с логином {userName} в списке отсутствует");
            }
            else
            {
                Console.WriteLine($"Имя -  {user.Name }, Логин -  {user.UserName }, Пароль -  {user.Password }");
            }
        }
        public void WriteUsers ()
        {
            foreach (var user in UsersList.UsersEntityNew.UserDBase)
            {
                Console.WriteLine($"Username = {user.UserName}, Name = {user.Name}, password = {user.Password}");
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }
        
        public void DellUser() { }
    }
}
