using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp2.models
{
    class Team
    {

        public string Name { get; set; }
        public int Budget { get; set; }
        public DateTime FoundDate { get; set; }
        public string City { get; set; }
        public List<Sportmans> SportmansList { get; set; }
    }
}
