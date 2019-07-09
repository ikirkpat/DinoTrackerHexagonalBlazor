using DinoTracker.Common.Utils.Patterns;
using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using System;

namespace DinoTracker.Domain.Tests.Builders
{
  public interface IExhibitBuilder : IBuilder<Exhibit>
  {
    IExhibitBuilder Id(Guid id);

    IExhibitBuilder ProperName(string properName);

    IExhibitBuilder CommonName(string commonName);

    IExhibitBuilder Era(string era);

    IExhibitBuilder Notes(string notes);

    IExhibitBuilder AtLocation(Location location);
  }
}
