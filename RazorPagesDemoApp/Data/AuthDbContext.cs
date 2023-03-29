using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//namespace RazorPagesDemoApp.Data
//{
//    public class AuthDbContext : IdentityDbContext
//    {
//        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
//        {

//        }
//    }
//}




namespace RazorPagesDemoApp.Data
{
    public class AuthDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }
    }
}