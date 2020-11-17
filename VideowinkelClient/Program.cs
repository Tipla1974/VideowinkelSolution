using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VideowinkelService.Models;

namespace VideowinkelClient
{
    class Program
    {
        static async Task Main()
        {
            Console.Write("Genre :");
            var genreNaam = Console.ReadLine();
            using var client = new HttpClient();
            var response = await client.GetAsync($"http://localhost:5000/genres/{genreNaam}");
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK :
                    var films = await response.Content.ReadAsAsync<List<Film>>();
                    foreach(var film in films)
                    {
                        Console.WriteLine(film.Titel);
                    }
                    break;
                case HttpStatusCode.NotFound:
                    Console.WriteLine("Niet Gevonden");
                    break;
                default:
                    Console.WriteLine("Technisch probleem, contacteer de helpdesk.");
                    break;
            }

        }
    }
}
