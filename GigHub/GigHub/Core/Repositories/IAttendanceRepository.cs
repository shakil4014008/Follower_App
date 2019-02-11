using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetAttendance(Gig gig, string userId);
        IEnumerable<Attendance> GetFutureAttendances(string userId);
    }
}