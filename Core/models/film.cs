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
    public class Film 
    {
        [Key]
        public int  Id { get; set; }

        public string Name { get; set; }
        
        public string Genre { get; set; }
        public string Year { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }
        public string Duration { get; set; }
        public string? Achivement { get; set; }
        public string Type { get; set; }



        public ICollection<likedFilms> likedFilms { get; set; }

        public ICollection<Viewedfilms> viewedFilms { get; set; }

    }
}
