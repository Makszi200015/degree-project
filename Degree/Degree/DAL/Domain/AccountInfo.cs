namespace Degree.DAL.Domain
{
    public class AccountInfo
    {
        public int Id { get; set; }
        public int SocialNetwork { get; set; }
        public string Login { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
