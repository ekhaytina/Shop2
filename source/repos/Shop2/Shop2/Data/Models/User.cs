using Microsoft.AspNetCore.Identity;
 
namespace Shop2.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}