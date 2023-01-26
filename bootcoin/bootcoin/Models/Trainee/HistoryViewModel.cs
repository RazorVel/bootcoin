using bootcoin.Models.Domain;

namespace bootcoin.Models.Trainee
{
    public class HistoryViewModel
    {
        public Guid? SourceId { get; set; }
        public Guid? TargetId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public int BalanceAfter { get; set; }
    }
}
