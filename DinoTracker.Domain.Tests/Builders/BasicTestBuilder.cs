using Bogus;
using DinoTracker.Common.Utils.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DinoTracker.Domain.Tests.Builders
{
  public abstract class BasicTestBuilder<E> : IBuilder<E>
    where E : new()
  {
    protected E _build;

    protected List<string> _propertiesToRandomize;
    protected Faker _faker;

    public BasicTestBuilder()
    {
      _build = new E();
      _propertiesToRandomize = new List<string>();
      _faker = new Faker();
    }

    public virtual E Build()
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

    protected abstract void GenerateRandomValueForProperty(string propertyName);

    protected void MarkPropertyNotRandomized(string propertyName)
    {
      if (_propertiesToRandomize.Contains(propertyName))
        _propertiesToRandomize.RemoveAt(_propertiesToRandomize.IndexOf(propertyName));
    }
  }
}
