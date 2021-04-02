using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    public class LengthPasswordCheckerUser<T>: IChecker<T>
    {
        public bool CheckField(T field, string oldPassword, string newPassword, out string error)
        {
            if (newPassword.Length < 5)
            {
                error = "The password cannot be less than 5 characters";
                return false;
            }
            error = "uops";
            return true;
        }
    }
}
