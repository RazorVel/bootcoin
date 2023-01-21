using System.ComponentModel.DataAnnotations.Schema;

namespace bootcoin.Models.Domain
{
    public class TransactionHeader
    {
        public Guid TransactionId { get; set; }
        public Guid? SourceId { get; set; }
        public Guid? TargetId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }

        public User Source { get; set; }
        public User Target { get; set; }

    }
}
