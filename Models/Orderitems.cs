using System.ComponentModel.DataAnnotations;

namespace ecommercestore.Models
{
    public class Orderitems
    {
        [Key]
        public int Id { get; set; }
        public string orderid { get; set; }

      
        public string perfumeid { get; set; }
        public int quantity { get; set; }
        public int price{ get; set; }
    }
}
