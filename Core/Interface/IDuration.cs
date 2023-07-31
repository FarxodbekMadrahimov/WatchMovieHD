using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IDuration 
    {
        public int minut { get; set; }
        public int minut_per_episode { get; set; }
        public int season { get; set; }
        public int episode { get; set; }
    }
    
}
