using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Exhibits
{
  public class Dinosaur : Exhibit
  {
    public string Description { get; set; }

    public List<string> Bones { get; set; }

    public List<Artifact> Artifacts { get; set; }
  }
}
