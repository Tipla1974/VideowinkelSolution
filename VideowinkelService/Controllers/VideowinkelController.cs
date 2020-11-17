using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideowinkelService.Repositories;
using VideowinkelService.Models;
using Microsoft.EntityFrameworkCore;
using VideowinkelService.Controllers;

namespace VideowinkelService.Controllers
{
    [Route("genres")]
    [ApiController]
    public class VideowinkelController : ControllerBase
    {
        private readonly IVideowinkelRepository repository;
        public VideowinkelController(IVideowinkelRepository repository) => this.repository = repository;

        [HttpGet("{Naam}")]
        [SwaggerOperation("Films van Genre")]
        public async Task<ActionResult> FindFilmByGenreNaam(string naam)
        {
            var genre = await repository.FindGenreIDByNaamAsync(naam);
            if (genre == null)
            {
                return base.NotFound();
            }
            var genreId = genre.Id;
            return base.Ok(await repository.FindAllFilmsByGenreIdAsync(genreId));
        }
        
 
        

        
    }
}
