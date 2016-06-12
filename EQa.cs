using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibijskiKolekcjoner
{
    class EQa : EQ
    {
        public bool sorc=true;
        public bool druid = true;
        public bool knight = true;
        public bool pall = true;
        public int lvl;

        public void wypiszvac()
        {
            if (sorc != true || druid != true || knight != true || pall != true)
            {
                Console.WriteLine("VACATIONS CAN USE:");
                if (sorc == true)
                {
                    Console.WriteLine("-Sorcerer");
                }
                if (druid == true)
                {
                    Console.WriteLine("-Druid");
                }
                if (knight == true)
                {
                    Console.WriteLine("-knight");
                }
                if (pall == true)
                {
                    Console.WriteLine("-Palladin");
                }
            }
        }
        public void wypiszLvl()
        {
            if(lvl>0)
            Console.WriteLine("LVL = {0}", lvl);
        }
        public override bool zwrocsorc()
        {
            return sorc;
        }
        public override bool zwrocdruid()
        {
            return druid;
        }
        public override bool zwrocknight()
        {
            return knight;
        }
        public override bool zwrocpall()
        {
            return pall;
        }
        public override int zwroclvl()
        {
            return lvl;
        }
        
        public override void wypisz()
        {
            wypisztyp();
            wypisznazwa();
            wypiszIlosc();
            wypiszWaga();
            wypiszDef();
            wypiszAtrybuty();
            wypiszLvl();
            wypiszvac();
            
        }
    }
}
