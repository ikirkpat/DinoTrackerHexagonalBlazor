using DinoTracker.Domain.Exhibits;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DinoTracker.Domain.Facilities
{
  public interface IMuseum
  {
    Guid? Id { get; set; }

    string Name { get; set; }

    List<ILocation> Locations { get; }

    List<IExhibit> GetAllExhibits();

    List<IExhibit> GetExhibits(IExhibitSearchParameters parameters);

    Task<IExhibit> AddExhibit(IExhibit exhibitToAdd);
  }
}
