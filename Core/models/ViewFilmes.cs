using Core.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Viewedfilms 
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Film))]
        public int FilmId { get; set; }
        [ForeignKey(nameof(Users))]
        public int userid { get; set; }

        
        public Film Film { get; set; }

        public Users Users { get; set; }

    }
}
