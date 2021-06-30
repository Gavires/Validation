using System;
using System.Collections.Generic;
using System.Data.Entity;
 
namespace EquipmentQualification
{
    public class DataBaseContext<T> : DbContext
    {
        public DataBaseContext (string connection)
            : base(connection)
        { }
          
        public DbSet<User> UserDBase { get; set; }
        public DbSet<Equipment> EquipmentDBase { get; set; }
        //public DbSet<T>

    }
}