using GigHub.Core.Repositories;

namespace GigHub.Core
{
    public interface IUnitOfWork
    {
        IGigRepository Gigs { get; }
        IAttendanceRepository Attendance { get; }
        IFollowingRepository Following { get; }
        IGenreRepository Genre { get; }
        void Complete();
    }
}