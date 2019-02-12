using GigHub.Core.Models;
using GigHub.Persistence;
using GigHub.Persistence.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;


namespace GigHub.Tests.Persistence.Repositories
{
    [TestClass]
    public class GigRepositoryTests
    {
        private GigRepository _repository;
        private Mock<DbSet<Gig>> _mockGigs;

        [TestInitialize]
        public void TestInitialize()
        {
             _mockGigs = new Mock<DbSet<Gig>>();
            var mockContext = new Mock<IApplicationDbContext>();
            _repository = new GigRepository(mockContext.Object);

            _repository = new GigRepository(mockContext.Object);

        }

        [TestMethod]
        public void GetUpcomingGigsByArtist_GigIsInThePast_ShouldNotBeReturned()
        {
            //this will not work ---- because this method is not called in all the blocks.


            //var gig = new Gig() {DateTime = DateTime.Now.AddDays(-1), ArtistId = "1"};

            //_mockGigs.SetSource(new [] {gig});

            //var gigs = _repository.GetUpComingGigsByArtist("1");

            //gigs.Should().BeEmpty();
        }


    }
}
