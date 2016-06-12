using System;

namespace TibijskiKolekcjoner
{
    public abstract class Item
    {
        public string typ;
        public string nazwa;
        public double waga;
        public bool czyStakowane;
        public void wypiszWaga()
        {
            Console.Write("WAGA = {0}", waga);
            Console.WriteLine(" oz.");
        }
        public void wypiszIlosc()
        {
            if (czyStakowane == true)
            {
                Console.WriteLine("ilosc = 100");
            }
            else
            {
                Console.WriteLine("ilosc = 1");
            }
        }
        public void wypisznazwa()
        {
            Console.Write("nazwa = ");
            Console.WriteLine(nazwa);
        }
        public void wypisztyp()
        {
            Console.WriteLine("typ = {0}", typ);
        }
        public virtual void wypisz()
        {
            wypisztyp();
            wypisznazwa();
            wypiszIlosc();  
            wypiszWaga();
        }
        public string zwroctyp()
        {
            return typ;
        }
        public string zwrocnazwa()
        {
            return nazwa;
        }
        public double zwrocwaga()
        {
            return waga;
        }
        public bool zwrocilosc()
        {
            return czyStakowane;
        }
        public virtual int zwrocdef()
        {
            return 0;
        }
        public virtual string zwrocatrybuty()
        {
            return ".";
        }
        public virtual bool zwrocsorc()
        {
            return true;
        }
        public virtual bool zwrocdruid()
        {
            return true;
        }
        public virtual bool zwrocknight()
        {
            return true;
        }
        public virtual bool zwrocpall()
        {
            return true;
        }
        public virtual int zwroclvl()
        {
            return 0;
        }
        public virtual string zwrocresist()
        { 
            return ".";
        }
       
    }
}
