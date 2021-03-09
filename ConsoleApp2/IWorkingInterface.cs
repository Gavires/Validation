using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    interface IWorkingInterface
    {
       public bool ClonCheck(User[] users, string nameOrPassword, out string error);
    }
}
