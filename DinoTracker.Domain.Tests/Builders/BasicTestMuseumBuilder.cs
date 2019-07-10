using DinoTracker.Domain.Facilities;
using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Tests.Builders
{
  public class BasicTestMuseumBuilder : BasicTestBuilder<Museum>
  {
    public BasicTestMuseumBuilder()
      : base()
    {
      _propertiesToRandomize.AddRange(new List<string>() {
        "Id", "Name", "Locations"
      });
    }

    public virtual BasicTestMuseumBuilder Id(Guid id)
    {
      _build.Id = id;
      MarkPropertyNotRandomized("Id");
      return this;
    }

    public virtual BasicTestMuseumBuilder Name(string name)
    {
      _build.Name = name;
      MarkPropertyNotRandomized("Name");
      return this;
    }

    public virtual BasicTestMuseumBuilder Locations(List<Location> locations)
    {
      _build.Locations = locations;
      MarkPropertyNotRandomized("Locations");
      return this;
    }

    protected override void GenerateRandomValueForProperty(string propertyName)
    {
      switch (propertyName)
      {
        case "Id":
          _build.Id = new Guid();
          break;
        case "Name":
          _build.Name = _faker.Company.CompanyName();
          break;
        case "Locations":
          _build.Locations = new List<Location>();
          break;
      }
    }
  }
}
