using DinoTracker.Domain.Exhibits;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Facilities
{
  public class Museum : IMuseum
  {
    private IExhibitRepository _exhibitRepository;

    public Museum(IExhibitRepository exhibitRepository)
    {
      _exhibitRepository = exhibitRepository;
    }

    public async Task<List<Exhibit>> GetAllExhibits() => throw new NotImplementedException();

    public async Task<List<Exhibit>> GetExhibits(ExhibitSearchParameters parameters)
    {
      List<Exhibit> exhibits = new List<Exhibit>();
      if (parameters.Id != null)
      {
        exhibits.Add(await GetExhibitById(parameters.Id));
      }
      else
      {
        throw new NotImplementedException("Can only search by Id right now.");
      }
      return exhibits;
    }

    public async Task<IExhibit> AddExhibit(IExhibit exhibitToAdd)
    {
      ILocation locationToAdd = GetLocationToAdd(exhibitToAdd);
      IExhibit created = await locationToAdd.AddExhibit(exhibitToAdd);
      return created;
    }

    private async Task<Exhibit> GetExhibitById(int id)
    {
      return await _exhibitRepository.Get(id);
    }

    private ILocation GetLocationToAdd(IExhibit exhibitToAdd)
    {
      List<ILocation> matchingLocations = Locations.Where(l => l.Id == exhibitToAdd.CurrentLocation.Id);
      if (!matchingLocations.Any())
      {
        throw new Exception("That location does not belong to this museum");
      }
      return matchingLocations.Single();
    }
  }
}
