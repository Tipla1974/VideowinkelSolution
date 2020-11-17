using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideowinkelService.Models;

namespace VideowinkelService.Repositories
{
    public interface IVideowinkelRepository
    {
        Task<List<Film>> FindAllFilmsByGenreIdAsync(int id);
        Task<Genre> FindGenreIDByNaamAsync(string naam);
    }
}
