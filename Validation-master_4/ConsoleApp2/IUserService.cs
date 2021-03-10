using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    interface IUserService
    {
        public List<User> Users { get; }
        public User ChekReal(string userName);
        public void SetPassword(IChecker<User> check, User user, string oldPassword, string newPassword);
        public User CreateUser(string userName, string name, string password);
        public void ResetPassword(string userName, string newUserPassword);
        public void WriteUser(string userName);
        public void WriteUsers();
        public User IdentifUser(string userName, string password);
        public void DellUser();

    }
}
