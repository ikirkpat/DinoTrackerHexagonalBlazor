using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Ports.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Tests.Adaptors.Repositories
{
  public class MemoryExhibitRepository : IExhibitRepository
  {
    private List<Exhibit> Exhibits { get; set; }

    public MemoryExhibitRepository()
    {
      Exhibits = new List<Exhibit>();
    }

    public void Seed(List<Exhibit> seed)
    {
      Exhibits.AddRange(seed);
    }

    public async Task<Exhibit> Create(Exhibit toCreate)
    {
      toCreate.Id = (Guid?) new Guid();
      await Task.Run(() => Exhibits.Add(toCreate));
      return toCreate;
    }

    public async Task<Exhibit> Get(Guid id)
    {
      return await Task.Run(() => Exhibits.Single(e => e.Id.Value == id));
    }
  }
}
