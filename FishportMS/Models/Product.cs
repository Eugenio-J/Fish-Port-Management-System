using System.ComponentModel.DataAnnotations;

namespace FishportMS.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        public int productName { get; set; }

        public int productPrice { get; set; }

        public int productWeight { get; set; }


    }
}
