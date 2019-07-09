using System;

namespace DinoTracker.Common.Utils.Patterns
{
  public interface IBuilder<T>
  {
    T Build();
  }
}
