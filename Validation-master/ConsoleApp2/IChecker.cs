using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    interface IChecker <T>  
    {
        bool CheckField(T user, string oldStr, string newStr, out string error);
    }
}
