using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibijskiKolekcjoner
{
    class EQb:EQa
    {
        public string resist=".";
        private void wypiszResist()
        {
            if (resist != ".")
            {
                Console.WriteLine("Resist = {0}", resist);
            }
        }
        public override string zwrocresist()
        { 
            return resist;
        }
        public override void wypisz()
        {
            wypisztyp();
            wypisznazwa();
            wypiszIlosc();
            wypiszWaga();
            wypiszDef();
            wypiszAtrybuty();
            wypiszResist();
            wypiszLvl();
            wypiszvac();
        }
    }
}
