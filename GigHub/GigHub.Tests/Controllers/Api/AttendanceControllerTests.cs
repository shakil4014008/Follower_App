using GigHub.Controllers.Api;
using GigHub.Core.Repositories;
using Moq;

namespace GigHub.Tests.Controllers.Api
{


    class AttendanceControllerTests
    {
        private AttendancesController _controller;
        private Mock<IAttendanceRepository> _mockRepository;
        private string _userId;

        public AttendanceControllerTests()
        {
            //_mockRepository = new Mock<IAttendanceRepository>();

            //var mockUoW = new Mock<IUnitOfWork>();
            //mockUoW.Setup(u => u.Attendance).Returns(_mockRepository.Object);

            //_controller = new AttendancesController();
            //_userId = "1";
            //_controller.MockCurrentUser(_userId, "user1@domain.com");
        }
    }
}
