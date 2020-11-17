using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideowinkelService.Models;

namespace VideowinkelService.Repositories
{
    public class VideowinkelContext : DbContext
    {
        public VideowinkelContext(DbContextOptions<VideowinkelContext> options) : base(options) { }
        public DbSet<Film> Films { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
