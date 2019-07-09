using Bogus;
using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DinoTracker.Domain.Tests.Builders
{
  public abstract class BasicTestExhibitBuilder<E> : IExhibitBuilder
    where E : Exhibit, new()
  {
    protected E _build;

    protected List<string> _propertiesToRandomize;
    protected Faker _faker;

    public BasicTestExhibitBuilder()
    {
      _build = new E();
      _propertiesToRandomize = new List<string>()
      {
        "Id", "ProperName", "CommonName", "Era", "Notes", "CurrentLocation"
      };
      _faker = new Faker();
    }

    public virtual IExhibitBuilder Id(Guid id)
    {
      _build.Id = id;
      MarkPropertyNotRandomized("Id");
      return this;
    }

    public virtual IExhibitBuilder ProperName(string properName)
    {
      _build.ProperName = properName;
      MarkPropertyNotRandomized("ProperName");
      return this;
    }

    public virtual IExhibitBuilder CommonName(string commonName)
    {
      _build.CommonName = commonName;
      MarkPropertyNotRandomized("CommonName");
      return this;
    }

    public virtual IExhibitBuilder Era(string era)
    {
      _build.Era = era;
      MarkPropertyNotRandomized("Era");
      return this;
    }

    public virtual IExhibitBuilder Notes(string notes)
    {
      _build.Notes = notes;
      MarkPropertyNotRandomized("Notes");
      return this;
    }

    public virtual IExhibitBuilder AtLocation(Location currentLocation)
    {
      _build.CurrentLocation = currentLocation;
      MarkPropertyNotRandomized("CurrentLocation");
      return this;
    }

    public virtual Exhibit Build()
    {
      GenerateRandoms();
      return _build;
    }

    protected virtual void GenerateRandoms()
    {
      foreach (string propertyName in _propertiesToRandomize)
      {
        GenerateRandomValueForProperty(propertyName);
      }
    }

    protected virtual void GenerateRandomValueForProperty(string propertyName)
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

    protected void MarkPropertyNotRandomized(string propertyName)
    {
      if (_propertiesToRandomize.Contains(propertyName))
        _propertiesToRandomize.RemoveAt(_propertiesToRandomize.IndexOf(propertyName));
    }
  }
}
