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
    public class Viewedfilms 
    {
        [Key]
        public int Id { get; set; }
        public int FilmId { get; set; }
        public int userid { get; set; }

        public film film { get; set; }

        public Users users { get; set; }

    }
}
