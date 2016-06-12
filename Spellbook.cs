using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibijskiKolekcjoner
{
    class Spellbook : EQa
    {
        public Spellbook(string name, double wagaa, bool stakowane, int defa, string atrybuta,
            int lvlik,bool mag, bool drut, bool knightcik,bool pallek)
        {
            typ = "Spellbook";
            nazwa = name;
            waga = wagaa;
            czyStakowane = stakowane;
            def = defa;
            atrybuty = atrybuta;
            sorc=mag;
            druid=drut;
            knight=knightcik;
            pall=pallek;
            lvl=lvlik;                
        }
    }
}
