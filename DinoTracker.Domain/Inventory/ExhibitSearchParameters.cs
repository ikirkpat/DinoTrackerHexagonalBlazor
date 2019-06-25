using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Inventory
{
  public class ExhibitSearchParamenters
  {
    Guid? Id { get; set; }

    string ProperName { get; set; }

    string CommonName { get; set; }
  }
}
