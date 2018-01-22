using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp2.models
{
  abstract  class Person
    {
        public Person()
        {

        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string DogumYeri { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        abstract public int GetLicense();
      
    }
}
