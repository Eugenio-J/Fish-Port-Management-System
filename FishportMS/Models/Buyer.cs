using System.ComponentModel.DataAnnotations;

namespace FishportMS.Models
{
    public class Buyer
    {
        [Key]
        public int buyerId { get; set; }

        public string buyerName { get; set; }

        //
        public List<Product> boughtItem { get; set; }
    }
}
