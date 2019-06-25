using DinoTracker.Domain.Exhibits;
using System;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Ports.Repositories
{
  public interface IExhibitRepository
  {
    Task<IExhibit> Create(IExhibit toCreate);

    Task<IExhibit> Get(int id);
  }
}
