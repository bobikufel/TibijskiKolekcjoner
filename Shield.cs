using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibijskiKolekcjoner
{
    class Shield : EQ
    {
        public string resist;

        public Shield(string name,double wagaa,bool stakowane,int defa,string atrybuta,string resista)
        {
            typ = "Shield";
            nazwa = name;
            waga = wagaa;
            czyStakowane = stakowane;
            resist = resista;
            def = defa;
            atrybuty = atrybuta;
        }
        private void wypiszResist()
        {
            if (resist != ".")
            {
                Console.WriteLine("Resist = {0}", resist);
            }
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
        }
    }
}
