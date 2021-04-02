using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentQualification
{
    public class AuthorizationUser
    {
        public UserService AuthorizationUsers { get; set; } = new UserService();
        
        public bool CheckAdmin(string userName, string userPassword)
        {
            return (userName == "ADMIgor") && (userPassword =="ADM.exe.ADM");
        }
        public IUserService CreateUserService(string userName, string userPassword)
        {
            AuthorizationUsers.Admin = CheckAdmin(userName,userPassword);
            AuthorizationUsers.UserNameChecker = new CompositeCheker<User>() { Checkers = { new languageChecker<User>(), new NotEmptyChecker<User>(), new ClonChecker<User>() { Error = "This username already exists!" } } };
            AuthorizationUsers.NameChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>() } };
            AuthorizationUsers.PasswordChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>(), new MinLengthChecker<User>() { MinLength = 5 } } };
            AuthorizationUsers.NewPasswordChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>(), new NewPasswordChecker<User>() } };
            return AuthorizationUsers;
        }

        public User IdentifUser(string userName)
        {
            var user = AuthorizationUsers.UsersList.ReturnUser(userName);
            return user ?? null;
        }
    }
}
