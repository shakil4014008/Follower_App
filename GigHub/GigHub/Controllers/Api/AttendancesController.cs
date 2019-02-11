using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Http;
using GigHub.Core.Dtos;
using GigHub.Core.Models;
using GigHub.Persistence;

namespace GigHub.Controllers.Api
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();

            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == dto.GigId))
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                GigId = dto.GigId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }


        //[HttpDelete]
        //public IHttpActionResult Delete(int id)
        //{
        //    try
        //    {
        //        var userId = User.Identity.GetUserId();

        //        var entity = _context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == id);
        //        if (!entity)
        //        {
        //            return BadRequest("The attendance already exists.");
        //        }
        //        else
        //        {
        //            var gig = _context.Gigs
        //                .Where(a => a.Id == id && a.Artist.Id == userId)
        //                .Include(a => a.Artist);
        //            _context.Gigs.Remove(id);
        //            _context.SaveChanges();


        //        }


        //        return Ok();
        //    }
        //    catch (Exception e)
        //    {

        //        Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
        //    }
           
        //}

        [HttpDelete]
        public IHttpActionResult DeleteAttendance(int id)
        {
            var userId = User.Identity.GetUserId();

            var attendance = _context.Attendances
                .SingleOrDefault(a => a.AttendeeId == userId && a.GigId == id);

            if (attendance == null)
                return NotFound();
            _context.Attendances.Remove(attendance);
            _context.SaveChanges();

            return Ok(id);
        }
    }
}
