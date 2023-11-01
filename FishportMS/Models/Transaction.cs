using System.ComponentModel.DataAnnotations;

namespace FishportMS.Models
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }

        public Buyer buyer { get; set; }

        public DateTime trasactionDate { get; set; }

        public bool isPaid { get; set; }
    }
}
