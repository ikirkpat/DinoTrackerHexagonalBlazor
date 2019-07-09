using DinoTracker.Domain.Facilities;
using DinoTracker.Domain.Ports.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Tests.Adaptors.Repositories
{
  public class MemoryMuseumRepository : IMuseumRepository
  {
    private List<Museum> Museums { get; set; }

    public MemoryMuseumRepository()
    {
      Museums = new List<Museum>();
    }

    public void Seed(List<Museum> seed)
    {
      Museums.AddRange(seed);
    }

    public async Task<Museum> Get(Guid id)
    {
      return await Task.Run(() => Museums.Single(m => m.Id == id));
    }
  }
}
