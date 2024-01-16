using Microsoft.EntityFrameworkCore;

namespace IVote.Data.Services
{
	public class PollService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
	{
		private IDbContextFactory<ApplicationDbContext> _dbContextFactory = dbContextFactory;

		public void AddPoll(Poll poll)
		{
			using (var contex = _dbContextFactory.CreateDbContext())
			{
				contex.Polls.Add(poll);
				contex.SaveChanges();
			}
		}

		public Poll GetPollById(int id)
		{
			using (var contex = _dbContextFactory.CreateDbContext())
			{
				var Poll = contex.Polls.SingleOrDefault(x => x.Id == id);
				return Poll ?? throw new Exception("Poll Does not Exits ");
			}
		}

		public void UpdatePoll(Poll poll)
		{

			if (poll == null)
			{
				throw new Exception("Poll Does not Exits");
			}

			using (var context = _dbContextFactory.CreateDbContext())
			{
				context.Update(poll);
				context.SaveChanges();
			}
		}

		public List<Poll> GetallPoll()
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var poll = context.Polls.ToList();
				return poll;
			}

		}

		public void RemovePollById(int id)
		{
			using (var context = _dbContextFactory.CreateDbContext())
			{
				var poll = GetPollById(id);
				context.Polls.Remove(poll);
				context.SaveChanges();
			}

		}
	}

}

