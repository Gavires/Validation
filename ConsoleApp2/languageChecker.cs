using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    class languageChecker <T> : IChecker<T>
    {
        public bool CheckField(T field, string oldStr, string newStr, out string error)
        {
            foreach (char ch in newStr)
            {
                if (!(ch >= 'A' && ch <= 'z'))
                {
                    error = "The username contains invalid characters";
                    return false;
                }
            }
            error = null;
            return true;
        }
    }
}
