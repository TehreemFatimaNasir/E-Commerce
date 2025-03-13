using System.ComponentModel.DataAnnotations;

namespace ecommercestore.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string position { get; set; } 
    }
}
