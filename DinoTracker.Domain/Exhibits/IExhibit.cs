using DinoTracker.Domain.Facilities;

namespace DinoTracker.Domain.Exhibits
{
  public interface IExhibit
  {
    Guid? Id { get; set; }

    string ProperName { get; set; }

    string CommonName { get; set; }

    string Era { get; set; }

    string Notes { get; set; }

    ILocation CurrentLocation { get; set; }
  }
}
