using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class AccountInfo : SimpleDomainModel<int>
    {
        /// <summary>
        /// SocialNetwork enum
        /// </summary>
        public int SocialNetwork { get; set; }
        /// <summary>
        /// SocialNetwork login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// AccountId
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Navigation property for AccountId
        /// </summary>
        public Account Account { get; set; }
    }
}
