using System.ComponentModel.DataAnnotations;

namespace ecommercestore.Models
{
    public class Perfume
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public decimal price { get; set; }
        public string notes { get; set; }
        public string imageurl { get; set; }
        public int categoryid { get; set; }
        public string categoryname { get; set; }
    }
}
