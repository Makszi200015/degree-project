using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class Account : SimpleDomainModel<int>
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<SearchHistory> SearchHistories { get; set; }
        public IEnumerable<AccountInfo> AccountInfos { get; set; }
    }
}
