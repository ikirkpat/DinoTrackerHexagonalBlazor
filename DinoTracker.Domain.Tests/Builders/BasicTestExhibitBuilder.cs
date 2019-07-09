using Bogus;
using DinoTracker.Common.Utils.Patterns;
using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DinoTracker.Domain.Tests.Builders
{
  public abstract class BasicTestExhibitBuilder<E> : BasicTestBuilder<E>
    where E : Exhibit, new()
  {
    public BasicTestExhibitBuilder()
      : base()
    {
      _propertiesToRandomize.AddRange(new List<string>()
      {
        "Id", "ProperName", "CommonName", "Era", "Notes", "CurrentLocation"
      });
    }

    public virtual BasicTestExhibitBuilder<E> Id(Guid id)
    {
      _build.Id = id;
      MarkPropertyNotRandomized("Id");
      return this;
    }

    public virtual BasicTestExhibitBuilder<E> ProperName(string properName)
    {
      _build.ProperName = properName;
      MarkPropertyNotRandomized("ProperName");
      return this;
    }

    public virtual BasicTestExhibitBuilder<E> CommonName(string commonName)
    {
      _build.CommonName = commonName;
      MarkPropertyNotRandomized("CommonName");
      return this;
    }

    public virtual BasicTestExhibitBuilder<E> Era(string era)
    {
      _build.Era = era;
      MarkPropertyNotRandomized("Era");
      return this;
    }

    public virtual BasicTestExhibitBuilder<E> Notes(string notes)
    {
      _build.Notes = notes;
      MarkPropertyNotRandomized("Notes");
      return this;
    }

    public virtual BasicTestExhibitBuilder<E> AtLocation(Location currentLocation)
    {
      _build.CurrentLocation = currentLocation;
      MarkPropertyNotRandomized("CurrentLocation");
      return this;
    }
    
    protected override void GenerateRandomValueForProperty(string propertyName)
    {
      switch (propertyName)
      {
        case "Id":
          _build.Id = new Guid();
          break;
        case "ProperName":
          _build.ProperName = String.Join(" ", _faker.Lorem.Words(2));
          break;
        case "CommonName":
          _build.CommonName = _faker.Lorem.Word();
          break;
        case "Era":
          _build.Era = _faker.Lorem.Word();
          break;
        case "Notes":
          _build.Notes = _faker.Lorem.Sentences();
          break;
        default:
          break;
      }
    }
  }
}
