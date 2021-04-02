using System;

namespace EquipmentQualification
{
    public class StatusQual
    {
        public string Status { get; set; }
        public DateTime DateQual { get; set; }
        public string NumberProtocol { get; set; }
        public TimeSpan PeriodQual { get; set; }
    }
}