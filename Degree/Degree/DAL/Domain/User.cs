using Microsoft.AspNetCore.Identity;

namespace Degree.DAL.Domain
{
    public class User : IdentityUser
    {
        public IEnumerable<Account> Accounts { get; set; }
    }
}
