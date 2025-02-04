using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebChat.Models
{
    public class UserManager : UserManager<ApplicationUser>
    {
        public UserManager() : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
        }
    }
}