using DinoTracker.Domain.Facilities;
using System;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Ports.Repositories
{
  public interface IMuseumRepository
  {
    Task<Museum> Get(Guid id);
  }
}
