using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    interface IEquipmentService
    {
        User UserActiv { get; set; }
        List<Equipment> Equipments { get; set; }
        Equipment CreatEquipment(User userActiv, string iD, string name, string location, string serialNumber, string numberProtocol, string statusQuall);
        void WriteInfoStatuse();
        void WriteInfoNextQuilification();
        void DellEquipment();
        void WritelnInfoListEquipment();

    }
}
