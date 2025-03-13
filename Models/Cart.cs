using System.ComponentModel.DataAnnotations;

namespace ecommercestore.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int userid { get; set; }

        public int perfumeid { get; set; }
        public int quantity { get; set; }
    }
}
