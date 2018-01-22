using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opp2.models;
namespace opp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportmans sp = new Sportmans();
            sp.Name = sp.SporcuÜret();
            Console.WriteLine(sp);
            Console.ReadLine();
        }
    }
}
