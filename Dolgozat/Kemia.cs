using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
    class Kemia
    {
        int ev;
        string nev;
        string rendszam;
        string felfedezo;

        public Kemia(int ev, string nev, string rendszam, string felfedezo)
        {
            this.ev = ev;
            this.nev = nev;
            this.rendszam = rendszam;
            this.felfedezo = felfedezo;
        }
    }
}
