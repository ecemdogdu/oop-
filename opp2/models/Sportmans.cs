using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp2.models
{
    class Sportmans:Person
    {
        public void Sportsman()        //başlangıcta sportmansda bunlar direk gelsin 
        {
            Position = "";             //construction yapısı
            Weight = 0;
            Height = 0;
            Price = 0;
            Team = new Team();

        }
        public string Position { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public int Price { get; set; }
        public Team Team { get; set; }
        public int Lisence { get; set; }
        public override int GetLicense()
        {
            Random rand = new Random();
            return rand.Next(5);
        }
        public string SporcuÜret()
        {
            string[] isimler = { "adssd", "asdsa", "asdasd" };
            Random rand = new Random();
            int no = rand.Next(0, isimler.Length);
            Console.WriteLine(isimler[no]);
            return isimler[no];
        }

    }
}
