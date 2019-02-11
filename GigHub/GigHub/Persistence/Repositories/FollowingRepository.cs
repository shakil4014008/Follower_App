using System.Collections.Generic;
using System.Linq;
using GigHub.Core.Models;
using GigHub.Core.Repositories;

namespace GigHub.Persistence.Repositories
{
    public class FollowingRepository : IFollowingRepository
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