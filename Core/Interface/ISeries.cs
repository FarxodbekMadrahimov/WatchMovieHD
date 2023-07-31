using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface ISeries
    {
        public string name { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public string producer { get; set; }
        public string country { get; set; }
        public string duiration { get; set; }
    }
}
