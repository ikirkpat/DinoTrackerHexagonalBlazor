using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Exhibits
{
  public interface IDinosaur : IExhibit
  {
    string Description { get; set; }

    List<string> Bones { get; set; }

    List<IArtifact> Artifacts { get; set; }
  }
}
