using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EquipmentQualification
{
    public class EquipmentService :IEquipmentService
    {
        public EquipmentDataBaseService EquipmentList { get; set; } = new EquipmentDataBaseService();
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
        public Equipment CreatEquipment(User userActiv,string iD, string name, string serialNumber, string location, string statusQuall, string numberProtocol, string dateQual, int periodQual)
        {
            MessageBox.Show("Добрый вечер!");
            //if (userActiv.loginStatus)
            //{
                //MessageBox.Show("Попытка создания объекта"); Создаем объект оборудовнаие и сохраняем в Базу данных
                var equipment = new Equipment();
                equipment.ID = CheckValue(CheckEquipmentsId, EquipmentList.ReturnEquipment(iD), "", iD, "Field ID");
                equipment.Name = CheckValue(CheckEquipmentsName, equipment, "", name, "Field Name Equipment");
                equipment.Location = CheckValue(CheckEquipmentsLocation, equipment, "", location, "Field Equipment Location");
                equipment.SerialNumber = CheckValue(CheckEquipmentsSerialNumber, EquipmentList.ReturnEquipment(serialNumber), "", serialNumber, "Field Equipment Serial Number");
                equipment.Status = CheckValue(CheckEquipmentsNumberStatusQuall, equipment, "", statusQuall, "Field Equipment Status Quall");
                equipment.NumberProtocol = CheckValue(CheckEquipmentsNumberProtocol, EquipmentList.ReturnEquipment(numberProtocol), "", numberProtocol, "Field Equipment Number Protocol");
                equipment.DateQual = dateQual;
                equipment.PeriodQual = periodQual;
                var date = DateTime.Parse(equipment.DateQual);
                equipment.NextDateQual= date.AddYears(periodQual).ToString();
                EquipmentList.AddDB(equipment);
                return equipment;
            //}
           /* else
            {
                Console.WriteLine("Необходим вход зарегистрирвоанного пользователя");
                return null;
            }*/
            //MessageBox.Show("Вроде как и создан");
        }
        public void WriteInfoStatuse() { }
        /*public void WriteInfoNextQuilification() { }
        public Equipment WritelnInfoListEquipment(string iD)
        {
            var equipment = EquipmentList.ReturnEquipment(iD);
            if (equipment != null)
            {
                return equipment;
            }
            else
            {
                MessageBox.Show($"Оборудование с номером {iD} не найдено");
            }
        }*/
        public void DellEquipment() { }
    }
}
