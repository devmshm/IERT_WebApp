using System.ComponentModel.DataAnnotations;

namespace ClsData.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string add1 { get; set; }
        public string add2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pincode { get; set; }
        public string postcode { get; set; }


    }
}
