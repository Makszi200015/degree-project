namespace Degree.DAL.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<SearchHistory> SearchHistories { get; set; }
        public IEnumerable<AccountInfo> AccountInfos { get; set; }
    }
}
