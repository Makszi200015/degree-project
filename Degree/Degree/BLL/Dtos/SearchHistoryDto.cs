using Degree.DataTypes.Enums;

namespace Degree.BLL.Dtos
{
    public class SearchHistoryDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// SocialNetwork enum value
        /// </summary>
        public ESocialNetwork SocialNetwork { get; set; }
        /// <summary>
        /// SocialNetwork login
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Date for creating history
        /// </summary>
        public DateTime CreatingDate { get; set; }
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
