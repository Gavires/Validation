using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
   public class CompositeCheker<T> : IChecker<T>
    {
        public List<IChecker<T>> Checkers { get; set; } = new List<IChecker<T>>();
        public bool CheckField(T field, string oldStr, string newStr, out string error)
        {
            error = null;
            foreach (IChecker<T> checker in Checkers)
            {
                if (!checker.CheckField(field, oldStr, newStr, out error))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
