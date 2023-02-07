namespace bootcoin.Models.Admin
{
    public class TeamsViewModel
    {
        public string Email { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public int? Balance { get; set; }
        public string? Department { get; set; }
        public Byte[]? Avatar { get; set; }
        public string? Mbti { get; set; }
        public string? Zodiac { get; set; }
        public string? FavoriteFood { get; set; }
        public string? FunFact { get; set; }
    }
}