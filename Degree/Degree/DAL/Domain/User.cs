using Microsoft.AspNetCore.Identity;

namespace Degree.DAL.Domain
{
    public class User : IdentityUser
    {
        /// <summary>
        /// Accounts Collection
        /// </summary>
        public IEnumerable<Account> Accounts { get; set; }
    }
}
