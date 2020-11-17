using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VideowinkelService.Models
{
    [DataContract(Name = "genres", Namespace = "")]
    public class Film
    {
        [DataMember(Name = "id", Order = 1)]
        public int Id { get; set; }
        [DataMember(Name = "genreId", Order = 2)]
        public int GenreId { get; set; }
        [DataMember(Name = "titel", Order = 3)]
        public string Titel { get; set; }
        [DataMember(Name = "voorraad", Order = 4)]
        public int Voorraad { get; set; }
        [DataMember(Name = "gereserveerd", Order = 5)]
        public int Gereserveerd { get; set; }
        [DataMember(Name = "prijs", Order = 6)]
        public decimal Prijs { get; set; }
    }
}
