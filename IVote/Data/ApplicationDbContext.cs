using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IVote.Data
{
  public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
  {
	public DbSet<Kandidaat> Kandidaat { get; set; }
	public DbSet<Poll> Polls { get; set; }
  }
}
