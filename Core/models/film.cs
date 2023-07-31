using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class film : Movies
    {
        public int  FilmId { get; set; }

        public string name { get; set; }
        [NotMapped]
        public genre genre { get; set; }
        public int year { get; set; }
        public string producer { get; set; }
        public string country { get; set; }
        public int durationId { get; set; }

        public movies type { get; set; } 

        public duration duration { get; set; }

        public ICollection<likedFilms> likedFilms { get; set;}

        public ICollection<Viewedfilms> viewedFilms { get; set;}

    }
}
