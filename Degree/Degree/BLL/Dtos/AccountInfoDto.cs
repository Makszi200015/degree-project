using Degree.DataTypes.Enums;

namespace Degree.BLL.Dtos
{
    public class AccountInfoDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// SocialNetwork enum
        /// </summary>
        public ESocialNetwork SocialNetwork { get; set; }
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
        public AccountDto Account { get; set; }
    }
}
