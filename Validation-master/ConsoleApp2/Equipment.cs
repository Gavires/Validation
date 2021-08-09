using System;

namespace EquipmentQualification
{
    public class Equipment
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Location { get; set; }
        //public StatusQual Qual { get; set; } = new StatusQual();
        public string Status { get; set; }
        public string NumberProtocol { get; set; }
        public string DateQual { get; set; }
        public int PeriodQual { get; set; }
        public string NextDateQual { get; set; }
        /*public void nextDataQual()
        {
            NextDateQual.AddYears(PeriodQual);
        }*/

    }
}