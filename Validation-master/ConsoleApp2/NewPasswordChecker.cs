using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
   public class NewPasswordChecker<T> : IChecker<T>
    {
        public bool CheckField(T field, string oldStr, string newStr, out string error)
        {
            if (oldStr == newStr)
                {
                    error = "The new and old password must not match";
                    return false;
                }
                error = null;
            return true;
        }
    }
}
