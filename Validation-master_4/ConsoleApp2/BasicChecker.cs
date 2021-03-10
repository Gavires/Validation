using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    class BasicChecker<T> : IChecker<T>
    {
        public bool CheckField(T field, string oldStr, string newStr, out string error)
        {
            if (string.IsNullOrEmpty(newStr))
            {
                error = "Error! Field can not be empty!";
                return false;
            }
            error = "uops";
            return true; 
        }
    }
}
