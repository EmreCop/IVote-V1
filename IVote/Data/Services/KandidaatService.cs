using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace IVote.Data.Services
{
	public class KandidaatService(IDbContextFactory<ApplicationDbContext> dbContextFactory)
	{
		private IDbContextFactory<ApplicationDbContext> _dbContextFactory = dbContextFactory;

		public void AddKandidaat(Kandidaat kandidaat)
		{
			using var context = _dbContextFactory.CreateDbContext();
			context.Kandidaat.Add(kandidaat);
			context.SaveChanges();
		}

		public Kandidaat GetKandidaatById(int id)
		{
			using var context = _dbContextFactory.CreateDbContext();
			var kandidaat = context.Kandidaat.SingleOrDefault(x => x.Id == id);
			return kandidaat ! ;
		}

		public void UpdateKandidaat(Kandidaat kandidaat)
		{
			if (kandidaat == null)
			{
				throw new Exception("Kandidaat Does not Exist");
			}

			using var context = _dbContextFactory.CreateDbContext();
			context.Update(kandidaat);
			context.SaveChanges();
		}

		public List<Kandidaat> GetAllKandidaten()
		{
			using var context = _dbContextFactory.CreateDbContext();
			var kandidaten = context.Kandidaat.ToList();
			return kandidaten;
		}

		public void RemoveKandidaatById(int id)
		{
			using var context = _dbContextFactory.CreateDbContext();
			var kandidaat = GetKandidaatById(id);
			context.Kandidaat.Remove(kandidaat);
			context.SaveChanges();
		}
	}
}
