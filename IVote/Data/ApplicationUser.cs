using Microsoft.AspNetCore.Identity;

namespace IVote.Data
{
  // Add profile data for application users by adding properties to the ApplicationUser class
  public class ApplicationUser : IdentityUser
  {
	public bool IsAdmin { get; set; } 
  }

}
