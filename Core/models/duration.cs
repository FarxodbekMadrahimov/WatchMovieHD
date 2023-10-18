using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class duration
    {
        public int durationId {  get; set; }
        public int? minute { get; set; }
        public int? minut_per_episede { get; set; } 
        public int? season { get; set; }
        public int? episode { get; set; }

        ICollection<Film> films { get; set; }
    }
}
