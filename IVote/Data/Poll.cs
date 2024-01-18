using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IVote.Data
{
  public class Poll
  {
    [Key]
    public int Id { get; set; }
    public string? Naam { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }

    [ForeignKey("Kandidaat ")]
    public virtual List<int>? KanditaatIds { get; set; }
    public int? TotalAmoutofVotes { get; set; }

    public int WinaarPollID { get; set; }

    public bool IsActive
    {
      get
      {
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        return (currentDate >= StartDate) && (currentDate <= EndDate);
      }
    }
  }
}
