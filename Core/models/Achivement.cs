using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Achivement
    {
        [Key]
        public int AchivementId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        ICollection<Achivements> Achivements { get; set;}
    }
}
