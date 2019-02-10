using GigHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Repositories
{
    public class FollowingRepository
    {
        private readonly ApplicationDbContext _context;

        public FollowingRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Following> GetFollowers(Gig gig, string userId)
        {
            return _context.Followings
                .Where(f => f.FolloweeId == gig.ArtistId && f.FollowerId == userId);
        }
    }
}