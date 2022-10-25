namespace Degree.DAL.Domain
{
    public class SearchHistory
    {
        public int Id { get; set; }
        public int SocialNetwork { get; set; }
        public string Login { get; set; }
        public DateTime CreatingDate { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
