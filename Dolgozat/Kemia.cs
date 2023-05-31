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
        string vegyjel;
        string rendszam;
        string felfedezo;

        public Kemia(int ev, string nev, string vegyjel, string rendszam, string felfedezo)
        {
            this.ev = ev;
            this.nev = nev;
            this.vegyjel = vegyjel;
            this.rendszam = rendszam;
            this.felfedezo = felfedezo;
        }
    }
}
