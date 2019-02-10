using GigHub.Models;
using GigHub.Repositories;

namespace GigHub.Persistence
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public GigRepository Gigs { get; private set; }
        public AttendanceRepository Attendance { get; private set; }
        public FollowingRepository Following { get; private set; }
        public GenreRepository Genre { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Gigs = new GigRepository(context);
            Attendance = new AttendanceRepository(context);
            Attendance = new AttendanceRepository(context);
            Genre  = new GenreRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}