using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellift
{
    internal class Lift
    {
        DateTime datum;
        int kartyaSorszam;
        int indulo;
        int celszint;

        public Lift(string csvsor)
        {
            var mezo = csvsor.Split(" ");
            this.datum = DateTime.Parse(mezo[0]);
            this.kartyaSorszam = int.Parse(mezo[1]);
            this.indulo = int.Parse(mezo[2]);
            this.celszint = int.Parse(mezo[3]);
        }

        public DateTime Datum { get => datum;  }
        public int KartyaSorszam { get => kartyaSorszam;  }
        public int Indulo { get => indulo; }
        public int Celszint { get => celszint; }
    }
}
