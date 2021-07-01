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
            //userService = CreateUserService(false);
            /*userService.CreateUser("Tasck","Максим","qwerty1");
            userService.CreateUser("Masck", "Максим", "qwerty2");
            userService.CreateUser("Eptr", "Петр", "qwerty3");*/
            windowInitial = new WindowInitial();
            windowInitial.Show();
            Application.Run(windowInitial);
            
        }
       
       /* static IEquipmentService CreateEquipmentService(User userActive)
        {
            var equipmentService = new EquipmentService();
            equipmentService.CheckEquipmentsId = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment ID already exists!" } } };
            equipmentService.CheckEquipmentsName = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } }; 
            equipmentService.CheckEquipmentsSerialNumber = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Serial Nunber already exists!" } } };
            equipmentService.CheckEquipmentsLocation = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberStatusQuall = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>() } };
            equipmentService.CheckEquipmentsNumberProtocol = new CompositeCheker<Equipment>() { Checkers = { new BasicChecker<Equipment>(), new ClonChecker<Equipment>() { Error = "This Equipment Number protocol already exists!" } } };
            return equipmentService;
        }*/
    }
}