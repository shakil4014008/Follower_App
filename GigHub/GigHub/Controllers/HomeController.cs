using Microsoft.AspNet.Identity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using GigHub.Core.Models;
using GigHub.Core.ViewModels;
using GigHub.Persistence;

namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        private UnitOfWork _unitOfWork;
      

        public HomeController()
        {
            _context =  new ApplicationDbContext();
            _unitOfWork = new UnitOfWork(_context);
        }

        public ActionResult Index(string query = null)
        {
            var upcomingGigs = _context.Gigs
                .Include(g => g.Artist)
                .Include(g => g.Genre)
                .Where(g => g.DateTime > DateTime.Now && !g.IsCancelled);

            if (!string.IsNullOrWhiteSpace(query))
            {
                upcomingGigs = upcomingGigs
                    .Where(g =>
                        g.Artist.Name.Contains(query) ||
                        g.Genre.Name.Contains(query) ||
                        g.Venue.Contains(query));
            }

            ILookup<int, Attendance> attendances = null;
            var userId = User.Identity.GetUserId();
            if (userId != null)
            {
                 attendances = _unitOfWork.Attendance.GetFutureAttendances(userId)
                    .ToLookup(a => a.GigId);
            }
               

            var viewModel = new GigsViewModel
            {
                UpcomingGigs = upcomingGigs,
                ShowActions = User.Identity.IsAuthenticated,
                Heading = "Upcoming Gigs",
                SearchTerm = query,
                Attendances = attendances
            };

            return View("Gigs", viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}