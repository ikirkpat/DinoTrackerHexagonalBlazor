using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Tests.Builders
{
  public class BasicTestLocationBuilder : BasicTestBuilder<Location>
  {
    public BasicTestLocationBuilder()
      : base()
    {
      _propertiesToRandomize.AddRange(new List<string>() {
          "Id", "Name", "Exhibits"
      });
    }

    public virtual BasicTestLocationBuilder Id(Guid id)
    {
      _build.Id = id;
      MarkPropertyNotRandomized("Id");
      return this;
    }

    public virtual BasicTestLocationBuilder Name(string name)
    {
      _build.Name = name;
      MarkPropertyNotRandomized("Name");
      return this;
    }

    public virtual BasicTestLocationBuilder Exhibit(List<Exhibit> exhibits)
    {
      _build.Exhibits = exhibits;
      MarkPropertyNotRandomized("Exhibits");
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
        case "Exhibits":
          _build.Exhibits = new List<Exhibit>();
          break;
      }
    }
  }
}
