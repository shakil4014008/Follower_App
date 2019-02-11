using System.Collections.Generic;
using System.Linq;
using GigHub.Core.Models;
using GigHub.Core.Repositories;

namespace GigHub.Persistence.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        public IEnumerable<Genre> GetGenre()
        {
            return _context.Genres.ToList();
        }
    }
}