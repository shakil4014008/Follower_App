using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.Repositories
{
    public interface IFollowingRepository
    {
        IEnumerable<Following> GetFollowers(Gig gig, string userId);
    }
}