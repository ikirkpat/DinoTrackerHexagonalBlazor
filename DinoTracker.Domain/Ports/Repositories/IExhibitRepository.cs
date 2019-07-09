using DinoTracker.Domain.Exhibits;
using System;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Ports.Repositories
{
  public interface IExhibitRepository
  {
    Task<Exhibit> Create(Exhibit toCreate);

    Task<Exhibit> Get(Guid id);
  }
}
