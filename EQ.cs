using System;
namespace TibijskiKolekcjoner
{
    abstract class EQ : Item
    {
        public int def;
        public string atrybuty = ".";

        public void wypiszDef()
        {
            Console.WriteLine("Def = {0}", def);
        }
        public void wypiszAtrybuty()
        {
            if (atrybuty != ".")
            Console.WriteLine("Atrybuty = {0}", atrybuty);
        }
        public override void wypisz()
        {
            wypisztyp();
            wypisznazwa();
            wypiszIlosc();
            wypiszWaga();
            wypiszDef();
            wypiszAtrybuty();
        }
        public override int zwrocdef()
        {
            return def;
        }
        public override string zwrocatrybuty()
        {
            return atrybuty;
        }
    }
}
