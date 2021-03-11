using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EquipmentQualification
{
    class Program
    {
        static public WindowInitial windowInitial; 
        static public IUserService userService;
        static void Main(string[] args)
        {
           // var userBaseDate = new UserBaseDate();
            userService = CreateUserService(false);
            /*userService.CreateUser("Tasck","Максим","qwerty1");
            userService.CreateUser("Masck", "Максим", "qwerty2");
            userService.CreateUser("Eptr", "Петр", "qwerty3");*/
            windowInitial = new WindowInitial();
            windowInitial.Show();
            Application.Run(windowInitial);
            
        }
       public static  IUserService  CreateUserService(bool checkAdmin)
        {
            var userService = new UserService() { Admin= checkAdmin };
            userService.UserNameChecker = new CompositeCheker<User>() { Checkers = { new languageChecker<User>(), new NotEmptyChecker<User>(), new ClonChecker<User>() {Error = "This username already exists!" } } };
            userService.NameChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>() } };
            userService.PasswordChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>(), new MinLengthChecker<User>() { MinLength = 5 } } };
            userService.NewPasswordChecker = new CompositeCheker<User>() { Checkers = { new NotEmptyChecker<User>(), new NewPasswordChecker<User>() } };
            return userService;
        }
        static IEquipmentService CreateEquipmentService(User userActive)
        {
            var equipmentService = new EquipmentService() { UserActiv=userActive};
            equipmentService.CheckEquipmentsId = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment ID already exists!" } } };
            equipmentService.CheckEquipmentsName = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } }; 
            equipmentService.CheckEquipmentsSerialNumber = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Serial Nunber already exists!" } } };
            equipmentService.CheckEquipmentsLocation = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberStatusQuall = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberProtocol = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Number protocol already exists!" } } };
            return equipmentService;
        }
    }
}