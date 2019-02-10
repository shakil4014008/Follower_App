using GigHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.Repositories
{
    public class GenreRepository
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