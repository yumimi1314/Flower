using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Details
    {
        public int DetailsID { get; set; }
        public int ID { get; set; }
        public string FlowerName { get; set; }
        public string FlowerColor { get; set; }
        public string FlowerSize { get; set; }
        public string FlowerPicUrl { get; set; }
        public float FlowerPrice { get; set; }
        public int DetailsNumber { get; set; }
        public string UserAccount { get; set; }
        public decimal Discount { get; set; }
        public int PayState { get; set; }
        public string PayDesc { get; set; }
    }
}