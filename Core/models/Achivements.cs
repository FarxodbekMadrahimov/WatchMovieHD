using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.models
{
    public class Achivements
    {
        public int AchivementsId { get; set; }
        public int FilmId { get; set; }
        public int AchivementId { get; set; }
        public int year { get; set; }

        public Achivement Achivement { get; set; }

    }
}
