using DinoTracker.Domain.Facilities;
using DinoTracker.Domain.Tests.Builders;
using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Tests.Factories
{
  public class MuseumFactory
  {
    private BasicTestMuseumBuilder _museumBuilder;
    private BasicTestLocationBuilder _locationBuilder;

    public MuseumFactory(BasicTestMuseumBuilder museumBuilder, BasicTestLocationBuilder locationBuilder)
    {
      _museumBuilder = museumBuilder;
      _locationBuilder = locationBuilder;
    }

    public Museum Random()
    {
      return _museumBuilder.Build();
    }

    public List<Museum> Random(int count)
    {
      List<Museum> museums = new List<Museum>();
      for (int i = 0; i < count; i ++)
      {
        museums.Add(Random());
      }
      return museums;
    }

    public Museum MusuemWithLocations(int numLocations)
    {
      List<Location> locations = new List<Location>();
      for (int i = 0; i < numLocations; i ++)
      {
        locations.Add(_locationBuilder.Build());
      }

      Museum museum = _museumBuilder.Locations(locations).Build();
      return museum;
    }
  }
}
