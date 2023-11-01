using System.ComponentModel.DataAnnotations;

namespace FishportMS.Models
{
    public class Vendor 
    {
        [Key]
        public int vendorId { get; set; }
        public string fullName { get; set; }


    }
}
