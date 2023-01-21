using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bootcoin.Models.Domain
{
    public class Profile
    {
        public Guid ProfileId { get; set; }    
        public Guid UserId { get; set; }
        public string? Department { get; set; } 
        public Byte[]? Avatar { get; set; }
        public string? Mbti { get; set; }
        public string? Zodiac { get; set; }
        public string? FavoriteFood { get; set; }
        public string? FunFact { get; set; }

        //foreign
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
