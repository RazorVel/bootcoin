using System.ComponentModel.DataAnnotations;

namespace bootcoin.Models.Domain
{
    public class User
    {
        public Guid UserId { get; set; }
        public string? Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? Role { get; set; }

        public int? Balance { get; set; }

        public List<TransactionHeader> sourceTransaction { get; set; }
        public List<TransactionHeader> targetTransaction { get; set; }
    }
}
