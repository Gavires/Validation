using System;
using System.Collections.Generic;
using System.Data.Entity;
 
namespace EquipmentQualification
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("Person")
        { }
          
        public DbSet<User> UsersNew { get; set; }
        
    }
}