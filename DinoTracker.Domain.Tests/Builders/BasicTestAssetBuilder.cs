using Bogus;
using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DinoTracker.Domain.Tests.Builders
{
  public class BasicTestAssetBuilder : BasicTestExhibitBuilder<Asset>
  {
    public BasicTestAssetBuilder()
      : base()
    {
      _propertiesToRandomize.Add("CreditedFounder");
    }

    public virtual IExhibitBuilder CreditedFounder(string creditedFounder)
    {
      _build.CreditedFounder = creditedFounder;
      MarkPropertyNotRandomized("CreditedFounder");
      return this;
    }

    protected override void GenerateRandomValueForProperty(string propertyName)
    {
      base.GenerateRandomValueForProperty(propertyName);
      if (propertyName == "CreditedFounder")
      {
        _build.CreditedFounder = _faker.Name.FullName();
      }
    }
  }
}
