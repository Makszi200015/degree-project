using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class AccountInfo : SimpleDomainModel<int>
    {
        public int SocialNetwork { get; set; }
        public string Login { get; set; }
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
