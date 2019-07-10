using DinoTracker.Domain.Exhibits;
using DinoTracker.Domain.Facilities;
using DinoTracker.Domain.Tests.Builders;
using DinoTracker.Domain.Tests.Factories;
using System;
using System.Linq;
using Xunit;

namespace DinoTracker.Domain.Tests
{
    public class ExhibitInventoryUseCaseTest
    {
        private MuseumFactory _museumFactory;
        private BasicTestMuseumBuilder _museumBuilder;
        private BasicTestLocationBuilder _locationBuilder;
        private BasicTestAssetBuilder _assetBuilder;

        public ExhibitInventoryUseCaseTest()
        {
          _locationBuilder = new BasicTestLocationBuilder();
          _museumBuilder = new BasicTestMuseumBuilder();
          _museumFactory = new MuseumFactory(_museumBuilder, _locationBuilder);
          _assetBuilder = new BasicTestAssetBuilder();
        }

        [Fact]
        public void TestExhibitAddedToRightLocationWhenCreated()
        {
          Museum museum = _museumFactory.MusuemWithLocations(3);

          Location exhibitDestination = museum.Locations.First();
          Exhibit toCreate = _assetBuilder.AtLocation(exhibitDestination).Build();

          IExhibitInventoryUseCase useCase = 

          Assert.Equal(toCreate.Id, exhibitDestination.Exhibits.Single().Id);
        }
    }
}
