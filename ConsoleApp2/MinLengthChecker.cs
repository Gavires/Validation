using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    class MinLengthChecker<T>: IChecker<T>
    {
        public int MinLength { get; set; } = 1; 
        public bool CheckField(T field, string oldPassword, string newPassword, out string error)
        {
            if (newPassword.Length < MinLength)
            {
                error = $"The password cannot be less than {MinLength} characters";
                return false;
            }
            error = null;
            return true;
        }
    }
}
