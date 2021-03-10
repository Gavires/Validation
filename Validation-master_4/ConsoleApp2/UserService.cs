using System;
using System.Collections.Generic;

namespace EquipmentQualification
{
    class UserService : IUserService
    {
        public List<User> Users { get; set; } = new List<User>();
        public IChecker<User> PasswordChecker { get; set; }
        public IChecker<User> NameChecker { get; set; }
        public IChecker<User> UserNameChecker { get; set; }
        public IChecker<User> NewPasswordChecker { get; set; }
        public bool Admin { get; set; }
        public User ChekReal(string userName)
        {
            foreach (var user in Users)
            {
                if (user.UserName == userName)
                {
                    return user;
                }
            }
            return null;
        }
        private string CheckValue(IChecker<User> cheker, User user, string oldValue, string newValue, string field)
        {
            return !cheker.CheckField(user, oldValue, newValue, out string message) ? throw new Exception($"{field}: {message}") : newValue;
        }
        public void SetPassword(IChecker<User> check, User user, string oldPassword, string newPassword)
        {
            user.Password = CheckValue(check, user, oldPassword, newPassword, $"{user.Name}, Password");
        }
        public User CreateUser(string userName, string name, string password)
        {
            var user = new User();
            //Console.WriteLine("Придумайте логин");
            //string userName = Console.ReadLine();
            user.UserName = CheckValue(UserNameChecker, ChekReal(userName), "", userName, "UserName");
            //Console.WriteLine("Ваше имя");
            //string name = Console.ReadLine();
            user.Name = CheckValue(NameChecker, user, "", name, $"{user.UserName}, Name");
            //Console.WriteLine("Придумайте пароль");
            //string password = Console.ReadLine();
            SetPassword(PasswordChecker, user, "", password);
            user.loginStatus = false;
            user.AvtorStatus = true;
            user.AdminStatus = Admin;
            Users.Add(user); 
            return user;
        }
        public void ResetPassword(string userName, string newUserPassword)
        {
            var user = ChekReal(userName);
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
            var user = ChekReal(userName);
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
            foreach (var user in Users)
            {
                Console.WriteLine($"Username = {user.UserName}, Name = {user.Name}, password = {user.Password}");
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }
        public User IdentifUser(string userName, string password)
        {
            var user = ChekReal(userName);
            if (user != null)
            {
                if (user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        public void DellUser() { }
    }
}
