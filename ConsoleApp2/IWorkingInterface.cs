using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentQualification
{
    interface IWorkingInterface
    {
        bool ClonCheck(User[] users, string nameOrPassword, out string error);
    }
}
