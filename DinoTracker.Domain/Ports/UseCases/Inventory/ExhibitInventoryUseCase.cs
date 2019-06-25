using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using DinoTracker.Repositories;
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

    public async Task<IExhibit> NewExhibit(IExhibit toAdd, Guid museumId)
    {
      IMuseum museum = await _museumRepository.Get(museumId);
      IExhibit createdExhibit = await museum.AddExhibit(toAdd);
      return createdExhibit;
    }
  }
}
