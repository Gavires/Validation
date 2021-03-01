using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    class EquipmentService :IEquipmentService
    {
        public User UserActiv { get; set; }
        private List<Equipment> Equipments { get; set; } = new List<Equipment>();
        public IChecker<Equipment> CheckEquipmentsId { get; set; }
        public IChecker<Equipment> CheckEquipmentsName { get; set; }
        public IChecker<Equipment> CheckEquipmentsLocation { get; set; }
        public IChecker<Equipment> CheckEquipmentsSerialNumber { get; set; }
        public IChecker<Equipment> CheckEquipmentsNumberProtocol { get; set; }
        public IChecker<Equipment> CheckEquipmentsNumberStatusQuall { get; set; }
        private string CheckValue(IChecker<Equipment> cheker, Equipment equipment, string oldValue, string newValue, string field)
        {
            return !cheker.CheckField(equipment, oldValue, newValue, out string message) ? throw new Exception($"{field}: {message}") : newValue;
        }
        private Equipment ChekReal(string value)
        {
            if (Equipments != null) 
            {
                foreach (var equipment in Equipments)
                {
                    if ((equipment.ID == value) || (equipment.SerialNumber == value) || (equipment.Qual.NumberProtocol == value))
                    {
                        return equipment;
                    }
                }
                return null;
            }
            else { return null; } 
        }
        public Equipment CreatEquipment(User userActiv,string iD, string name, string serialNumber, string location, string statusQuall, string numberProtocol)
        {
            if (userActiv.loginStatus)
            {
                var equipment = new Equipment();
                equipment.ID = CheckValue(CheckEquipmentsId, ChekReal(iD), "", iD, "Field ID");
                equipment.Name = CheckValue(CheckEquipmentsName, equipment, "", name, "Field Name Equipment");
                equipment.Location = CheckValue(CheckEquipmentsLocation, equipment, "", location, "Field Equipment Location");
                equipment.SerialNumber = CheckValue(CheckEquipmentsSerialNumber, ChekReal(serialNumber), "", serialNumber, "Field Equipment Serial Number");
                equipment.Qual.Status = CheckValue(CheckEquipmentsNumberStatusQuall, equipment, "", statusQuall, "Field Equipment Status Quall");
                equipment.Qual.NumberProtocol = CheckValue(CheckEquipmentsNumberProtocol, ChekReal(numberProtocol), "", numberProtocol, "Field Equipment Number Protocol");
                Equipments.Add(equipment);
                return equipment;
            }
            else
            {
                Console.WriteLine("Необходим вход зарегистрирвоанного пользователя");
                return null;
            }
        }
        public void WriteInfoStatuse() { }
        public void WriteInfoNextQuilification() { }
        public void WritelnInfoListEquipment()
        {
            foreach (var equipment in Equipments)
            {
                Console.WriteLine($"ID = {equipment.ID}, Name = {equipment.Name}, status quall = {equipment.Qual.Status}, Number protocol quall = {equipment.Qual.NumberProtocol}");
                Console.WriteLine("---------------------------------------------------------------------------");
            }
        }
        public void DellEquipment() { }
    }
}
