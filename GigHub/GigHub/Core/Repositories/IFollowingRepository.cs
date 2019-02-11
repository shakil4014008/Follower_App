using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IFollowingRepository
    {
        IEnumerable<Following> GetFollowers(Gig gig, string userId);
    }
}