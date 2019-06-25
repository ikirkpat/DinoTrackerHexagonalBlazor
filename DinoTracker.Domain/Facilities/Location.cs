using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Ports.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Facilities
{
  public class Location
  {
    private IExhibitRepository _exhibitRepository;

    public Guid? Id { get; set; }

    public string Name { get; set; }

    public List<IExhibit> Exhibits { get; }

    public Location(IExhibitRepository exhibitRepository)
    {
      _exhibitRepository = exhibitRepository;
    }

    public async Task<IExhibit> AddExhibit(IExhibit exhibitToAdd)
    {
      IExhibit created = await _exhibitRepository.Create(exhibitToAdd);
      Exhibits.Add(created);
      return created;
    }
  }
}
