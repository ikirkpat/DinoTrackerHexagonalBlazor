using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Inventory;
using DinoTracker.Domain.Ports.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Facilities
{
  public class Museum
  {
    private IExhibitRepository _exhibitRepository;

    public Guid? Id { get; set; }

    public string Name { get; set; }

    public List<Location> Locations { get; set; }

    public Museum(IExhibitRepository exhibitRepository)
    {
      _exhibitRepository = exhibitRepository;
    }

    public Museum()
    {
    }

    public void InjectExhibitRepository(IExhibitRepository exhibitRepository)
    {
      _exhibitRepository = exhibitRepository;
    }

    internal async Task<List<Exhibit>> GetAllExhibits() => throw new NotImplementedException();

    internal async Task<List<Exhibit>> GetExhibits(ExhibitSearchParameters parameters)
    {
      List<Exhibit> exhibits = new List<Exhibit>();
      if (parameters.Id != null)
      {
        exhibits.Add(await GetExhibitById(parameters.Id.Value));
      }
      else
      {
        throw new NotImplementedException("Can only search by Id right now.");
      }
      return exhibits;
    }

    internal async Task<Exhibit> AddExhibit(Exhibit exhibitToAdd)
    {
      Location locationToAdd = GetLocationToAdd(exhibitToAdd);
      Exhibit created = await locationToAdd.AddExhibit(exhibitToAdd);
      return created;
    }

    private async Task<Exhibit> GetExhibitById(Guid id)
    {
      return await _exhibitRepository.Get(id);
    }

    private Location GetLocationToAdd(Exhibit exhibitToAdd)
    {
      List<Location> matchingLocations = Locations.Where(l => l.Id == exhibitToAdd.CurrentLocation.Id).ToList();
      if (!matchingLocations.Any())
      {
        throw new Exception("That location does not belong to this museum");
      }
      return matchingLocations.Single();
    }
  }
}
