using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class Account : SimpleDomainModel<int>
    {
        /// <summary>
        /// UserId
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Navigation property for User
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// SearchHistories Collection
        /// </summary>
        public IEnumerable<SearchHistory> SearchHistories { get; set; }
        /// <summary>
        /// AccountInfos Collection
        /// </summary>
        public IEnumerable<AccountInfo> AccountInfos { get; set; }
    }
}
