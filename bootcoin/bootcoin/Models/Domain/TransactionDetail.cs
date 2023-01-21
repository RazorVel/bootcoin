using System.ComponentModel.DataAnnotations.Schema;

namespace bootcoin.Models.Domain
{
    public class TransactionDetail
    {
        public Guid TransactionId { get; set; }
        public int Amount { get; set; }
        public int BalanceAfter { get; set; }

        [ForeignKey("TransactionId")]
        public TransactionHeader TransactionHeader { get; set; }
    }
}
