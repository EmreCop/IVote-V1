using System.ComponentModel.DataAnnotations;

namespace IVote.Data
{
	public class Kandidaat
	{
		[Key]
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string Party { get; set; }
		public string? Description { get; set; }
		public string? ImagePath { get; set; }
		public string? ImageUrl { get; set;}
		public int Votes { get; set; }

	}
}
