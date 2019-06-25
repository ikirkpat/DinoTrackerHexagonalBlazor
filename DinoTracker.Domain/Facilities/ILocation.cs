using DinoTracker.Domain.Exhibits;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Facilities
{
  public interface ILocation
  {
    Guid? Id { get; set; }

    string Name { get; set; }

    List<IExhibit> Exhibits { get; }

    Task<IExhibit> AddExhibit(IExhibit exhibitToAdd);
  }
}
