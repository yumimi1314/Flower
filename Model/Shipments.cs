using System;
namespace Model
{
    public class Shipments
    {
        public int UserDeatialID { get; set; }
        public DateTime ShipmentsDate { get; set; }
        public string ShimpentsPeople { get; set; }
        public string FlowerName { get; set; }
        public string FlowerColor { get; set; }
        public string FlowerPicUrl { get; set; }
        public string FlowerSize { get; set; }
        public float FlowerPrice { get; set; }
        public int DetailsNumber { get; set; }
        public int ShimpentsState { get; set; }
    }
}
