using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendance(Gig gig, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}