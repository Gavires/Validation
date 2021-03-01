using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    class ClonChecker<T> : IChecker<T>
    {
        public string Error { get; set; }
        public bool CheckField(T obj, string oldStr, string newStr, out string error)
        {
            //Console.WriteLine("ДА");
            if (obj != null)  
                {
                    error = $"Error! {Error}";
                    return false;
                }
            error = null;
            return true;
        }
    }
}
