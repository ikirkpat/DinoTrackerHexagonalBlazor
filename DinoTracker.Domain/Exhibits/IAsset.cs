using System;
using System.Collections.Generic;

namespace DinoTracker.Domain.Exhibits
{
  public interface IAsset : IExhibit
  {
    string CreditedFounder { get; set; }
  }
}
