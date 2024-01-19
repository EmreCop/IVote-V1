using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IVote.Data.Services;


namespace IVote.Data
{
  public class Poll
  {
    private readonly KandidaatService? _kandidaatService;

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
    // this works but break things
    //public void HandleInactivePoll()
    //{
    //  if (!IsActive && KanditaatIds != null)
    //  {
    //    foreach (var id in KanditaatIds)
    //    {
    //      var kandidaat = _kandidaatService?.GetKandidaatById(id);
    //      if (kandidaat != null)
    //      {
    //        kandidaat.Votes = 0;
    //        _kandidaatService 
            
    //      }
    //    }
    //  }

    }
  }
