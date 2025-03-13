using System.ComponentModel.DataAnnotations;

namespace ecommercestore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; } 
    }
}
