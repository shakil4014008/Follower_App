﻿using System.Collections.Generic;
using GigHub.Core.Models;

namespace GigHub.Core.Repositories
{
    public interface IGigRepository
    {
        Gig GetGigWithAttendees(int gigId);
        IEnumerable<Gig> GetGigsUserAttending(string userId);
        IEnumerable<Gig> GetMyUpcomingGigs(string userId);
        Gig GetGigsWithArtistAndGenre(int id);
        Gig GetGig(int gigId);
        void Add(Gig gig);
    }
}