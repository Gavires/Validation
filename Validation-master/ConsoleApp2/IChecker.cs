using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
   public interface IChecker <T>  
    {
        public bool CheckField(T user, string oldStr, string newStr, out string error);
    }
}
