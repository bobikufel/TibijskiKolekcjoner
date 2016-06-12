using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TibijskiKolekcjoner
{

    class MojaKolekcja
    {
        private List<Item> listaItemow;
        public MojaKolekcja()
        {
            listaItemow = new List<Item>();
        }
        public void dodaj()
        {
            Console.WriteLine("Napisz jaki rodzij EQ chcesz dodać...");
            Console.WriteLine("Helmet,Legs,Armor,Boots,Shield,Spellbook");
            string typ = Console.ReadLine();
            dodaj(typ);
        }

        private void dodaj(string typ)
        {
            if (typ != "Shield" && typ != "Boots" && typ != "Helmet" && typ != "Spellbook" && typ != "Armor" && typ != "Legs") 
            {
                Console.WriteLine("COS NIE TAK, SPROBOJ JESZCZE RAZ");
                return;
            }
            string nazwa, atrybuty, resist;
            int def, lvl;
            double waga;
            bool ilosc, sorc, druid, knight, pall;
            Console.WriteLine("podaj nazwe");
            nazwa = Console.ReadLine();
            Console.WriteLine("podaj wage");
            waga = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj defa");
            def = Int32.Parse(Console.ReadLine());
            Console.WriteLine("podaj ilosc,false=pojedyncza,true stackowane");
            ilosc = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("podaj atrybuty");
            atrybuty = Console.ReadLine();
            if (typ != "Spellbook")
            {
                Console.WriteLine("podaj resisty");
                resist = Console.ReadLine();
            }
            else
            {
                resist = ".";
            }
            if (typ != "Shield")
            {
                Console.WriteLine("podaj minimalny lvl");
                lvl = Int32.Parse(Console.ReadLine());
                Console.WriteLine("czy sorcerer moze uzywac?  true/false");
                sorc = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("czy druid moze uzywac?  true/false");
                druid = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("czy knight moze uzywac?  true/false");
                knight = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("czy Palladyn moze uzywac?  true/false");
                pall = Convert.ToBoolean(Console.ReadLine());
            }
            else
            {
                lvl = 0;
                sorc = true;
                druid = true;
                knight = true;
                pall = true;
            }

            dodajitem(typ, nazwa, waga, ilosc, def, atrybuty, resist, lvl, sorc, druid, knight, pall);
        }
        //wypisz ten item
        private void wypisz(Item item)
        {
            Console.WriteLine(" ");
            item.wypisz();
        }
        //wypisz item z taka nazwa
        private void wypisz(string typ)
        {
            foreach (Item itemek in listaItemow)
            {
                if (itemek.typ == typ)
                {
                    wypisz(itemek);
                }
            }
        }
        public void wypisz()
        {
            foreach (Item itemek in listaItemow)
            {
                Console.WriteLine(" ");
                wypisz(itemek);
            }
        }
        public void zapisz()
        {
            string path = @"D:\x.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(listaItemow.Count);

            for (int i = 0; i < listaItemow.Count; i++)
            {
                    sw.WriteLine(listaItemow[i].zwrocnazwa());
                    sw.WriteLine(listaItemow[i].zwroctyp());
                    sw.WriteLine(listaItemow[i].zwrocdef());
                    sw.WriteLine(listaItemow[i].zwrocwaga());
                    sw.WriteLine(listaItemow[i].zwrocilosc());
                    sw.WriteLine(listaItemow[i].zwrocatrybuty());
                    sw.WriteLine(listaItemow[i].zwrocresist());
                    sw.WriteLine(listaItemow[i].zwroclvl());
                    sw.WriteLine(listaItemow[i].zwrocsorc());
                    sw.WriteLine(listaItemow[i].zwrocdruid());
                    sw.WriteLine(listaItemow[i].zwrocknight());
                    sw.WriteLine(listaItemow[i].zwrocpall());
            }
            sw.Close();
        }
        public void wczytaj()
        {
          
               
                listaItemow = new List<Item>();
                StringBuilder sb = new StringBuilder();
                string path = @"D:\x.txt";
                 if (File.Exists(path))
	            {
		            
                }
                 else
                 {
                    Console.WriteLine("problem z plikiem, najprawdopodobniej nie istnieje, zapisz pustą lub aktualna liste by powstał plik");
                 }
                StreamReader sr = new StreamReader(path);
                int iloscorganizmow = 0;
                iloscorganizmow = Int32.Parse(sr.ReadLine());

                string nazwa, typ, atrybuty, resist;
                int def, lvl;
                double waga;
                bool ilosc, sorc, druid, knight, pall;

                for (int i = 0; i < iloscorganizmow; i++)
                {
                    nazwa = sr.ReadLine();
                    typ = sr.ReadLine();
                    def = Int32.Parse(sr.ReadLine());
                    waga = double.Parse(sr.ReadLine());
                    ilosc = Convert.ToBoolean(sr.ReadLine());
                    atrybuty = sr.ReadLine();
                    resist = sr.ReadLine();
                    lvl = Int32.Parse(sr.ReadLine());
                    sorc = Convert.ToBoolean(sr.ReadLine());
                    druid = Convert.ToBoolean(sr.ReadLine());
                    knight = Convert.ToBoolean(sr.ReadLine());
                    pall = Convert.ToBoolean(sr.ReadLine());
                    dodajitem(typ, nazwa, waga, ilosc, def, atrybuty, resist, lvl, sorc, druid, knight, pall);
                }
                sr.Close();
            }
            
        
        private void dodajitem(string typ,string name, double wagaa, bool stakowane, int defa, string atrybuta, string resista,
            int lvlik, bool mag, bool drut, bool knightcik, bool pallek)
        {
            switch (typ)
            {
                case "Helmet":
                    Helmet helmik = new Helmet(name, wagaa, stakowane, defa,atrybuta, resista,lvlik,mag,drut,knightcik,pallek);
                    listaItemow.Add(helmik);
                    break;
                case "Legs":
                    Legs legi = new Legs(name, wagaa, stakowane, defa, atrybuta, resista, lvlik, mag, drut, knightcik, pallek);
                    listaItemow.Add(legi);
                    break;
                case "Armor":
                    Armor armor = new Armor(name, wagaa, stakowane, defa, atrybuta, resista, lvlik, mag, drut, knightcik, pallek);
                    listaItemow.Add(armor);
                    break;
                case "Boots":
                    Boots botki = new Boots(name, wagaa, stakowane, defa, atrybuta, resista, lvlik, mag, drut, knightcik, pallek);
                    listaItemow.Add(botki);
                    break;
                case "Shield":
                    Shield tarcza = new Shield(name, wagaa, stakowane, defa, atrybuta, resista);
                    listaItemow.Add(tarcza);
                    break;
                case "Spellbook":
                    Spellbook spellboczek = new Spellbook(name, wagaa, stakowane, defa, atrybuta, lvlik, mag, drut, knightcik, pallek);
                    listaItemow.Add(spellboczek);
                    break;

                default:
                    Console.WriteLine("cos nie tak");
                    break;
            }
        }
    }
}
