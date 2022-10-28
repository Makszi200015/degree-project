namespace Degree.BLL.Dtos
{
    public class AccountDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// UserId
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// Navigation property for User
        /// </summary>
        public UserDto User { get; set; }
        /// <summary>
        /// SearchHistories Collection
        /// </summary>
        public IEnumerable<SearchHistoryDto> SearchHistories { get; set; }
        /// <summary>
        /// AccountInfos Collection
        /// </summary>
        public IEnumerable<AccountInfoDto> AccountInfos { get; set; }
    }
}
