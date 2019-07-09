using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using DinoTracker.Domain.Ports.Repositories;
using System;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Ports.UseCases.Inventory
{
  public class ExhibitInventoryUseCase : IExhibitInventoryUseCase
  {
    private IMuseumRepository _museumRepository;

    public ExhibitInventoryUseCase(IMuseumRepository museumRepository)
    {
      _museumRepository = museumRepository;
    }

    public async Task<Exhibit> NewExhibit(Exhibit toAdd, Guid museumId)
    {
      Museum museum = await _museumRepository.Get(museumId);
      Exhibit createdExhibit = await museum.AddExhibit(toAdd);
      return createdExhibit;
    }
  }
}
