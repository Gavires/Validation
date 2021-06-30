using System.ComponentModel.DataAnnotations;

namespace EquipmentQualification
{
   public class User
    {
       // public int ID { get; set; }
        [Key]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Password { get;  set; }
        public bool AdminStatus { get; set; }
        public bool loginStatus { get; set; }
    }
}