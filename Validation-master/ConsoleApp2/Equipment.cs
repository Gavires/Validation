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

    }
}