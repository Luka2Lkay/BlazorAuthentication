using Microsoft.AspNetCore.Identity;

namespace BlazorAuthentication.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateOnly DOB { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    }
}
