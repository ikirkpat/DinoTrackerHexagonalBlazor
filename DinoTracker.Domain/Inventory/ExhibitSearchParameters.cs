using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Inventory
{
  public class ExhibitSearchParameters
  {
    public Guid? Id { get; set; }

    public string ProperName { get; set; }

    public string CommonName { get; set; }
  }
}
