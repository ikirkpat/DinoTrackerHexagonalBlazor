using DinoTracker.Domain.Facilities;
using System;

namespace DinoTracker.Domain.Exhibits
{
  public class Exhibit
  {
    public Guid? Id { get; set; }

    public string ProperName { get; set; }

    public string CommonName { get; set; }

    public string Era { get; set; }

    public string Notes { get; set; }

    public Location CurrentLocation { get; set; }
  }
}
