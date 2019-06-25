using DinoTracker.Domain.Exhibits;
using System;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Ports.UseCases.Inventory
{
  public interface IExhibitInventoryUseCase
  {
    Task<IExhibit> NewExhibit(IExhibit toAdd);
  }
}
