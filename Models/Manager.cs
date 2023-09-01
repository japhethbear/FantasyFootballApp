using Microsoft.AspNetCore.Identity;

namespace FantasyFootballApp.Models
{
    public class Manager : IdentityUser<int>
    {
        public new int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public new string? Email { get; set; }
        public string? Password { get; set; }
        // Other properties and methods...

        // Navigation property for Team
        // public Team Team { get; set; }


        // Constructor
        public Manager()
        {
            // Additional initialization or logic can go here if needed
        }
    }
}
