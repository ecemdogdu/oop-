using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp2.models
{
    class User:Person
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public override int GetLicense()
        {
            return 0;
        }
    }
}
