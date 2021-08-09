using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
   public interface IEquipmentService
    {
        //User UserActiv { get; set; }
        //List<Equipment> Equipments { get; set; }
        public EquipmentDataBaseService EquipmentList { get; set; }
        //public Equipment ChekRealEquipment(string value);
        Equipment CreatEquipment(User userActiv, string iD, string name, string location, string serialNumber, string numberProtocol, string statusQuall, string dateQual, int lingthQual);
        //void WriteInfoStatuse();
        //void WriteInfoNextQuilification();
        void DellEquipment();
       // void WritelnInfoListEquipment();

    }
}
