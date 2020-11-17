using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideowinkelService.Models;

namespace VideowinkelService.Repositories
{
    public class VideowinkelRepository : IVideowinkelRepository
    {
        private readonly VideowinkelContext context;
        public VideowinkelRepository(VideowinkelContext context) => this.context = context;

        public async Task<List<Film>> FindAllFilmsByGenreIdAsync(int id) => 
            await context.Films.AsNoTracking()
                                .Where(idgenre => idgenre.GenreId == id)
                                .ToListAsync();


        public async Task<Genre> FindGenreIDByNaamAsync(string naam) =>
            await context.Genres
                         .Where(n => n.Naam == naam)
                         .FirstOrDefaultAsync();
                         

    }
}
