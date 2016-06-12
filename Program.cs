using System;

namespace TibijskiKolekcjoner
{
    class Program
    {
        static void Main()
        {
            bool exit=false;
            string coChceszZrobic=" ";
            MojaKolekcja kolekcja = new MojaKolekcja();
            while (exit==false)
            {
                Console.WriteLine("CO CHCESZ ZROBIC? wpisz:");
                Console.WriteLine("dodaj-zeby dodac jeden przedmiot");
                Console.WriteLine("wczytaj - zeby wszytac liste z pliku ");
                Console.WriteLine("zapisz - zeby zapisac liste do pliku");
                Console.WriteLine("wypisz - zeby wypisac wszystkie  przedmioty na liscie");
                Console.WriteLine("wyjdz - zeby wyjsc z programu");
                coChceszZrobic=Console.ReadLine();
                switch (coChceszZrobic)
                {
                    case "dodaj":
                        kolekcja.dodaj();
                        break;
                    case "wypisz":
                        kolekcja.wypisz();
                        break;
                    case "zapisz":
                        kolekcja.zapisz();
                        break;
                    case "wczytaj":
                        kolekcja.wczytaj();
                        break;
                    case "wyjdz":
                        exit=true;
                        break;
                    default:
                        Console.WriteLine("cos nie tak");
                        break;
                }
            }
        }
    }
}
