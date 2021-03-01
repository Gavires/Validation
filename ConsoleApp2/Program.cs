using System;
using System.Collections.Generic;

namespace EquipmentQualification
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingener = CreateUserService(false);
            ingener.CreateUser("Tasck","Максим","qwerty2");
            ingener.CreateUser("Masck", "Игорь", "fgdgdgdgdd");
            Console.WriteLine(ingener.Users[0].AdminStatus);
            /*var admin = CreateUserService(true);
            admin.CreateUser("ADM", "Игорь", "adminAD");
            Console.WriteLine(admin.Users[0].AdminStatus);*/
            /*var equipmentService = CreateEquipmentService(ingener);
            equipmentService.CreatEquipment(ingener,"1", "Смеситель", "45658", "G202", "ДА", "ПРТ-ВД");
            equipmentService.WritelnInfoListEquipment();*/
        }
       static  IUserService  CreateUserService(bool checkAdmin)
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