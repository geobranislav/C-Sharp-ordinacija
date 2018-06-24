using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {

            Doktor Milan = new Doktor("Milan", "Pavkovic", "Internista");
            Pacijent Dragan = new Pacijent("Dragan", "Djuric", "1234325436543", "k2341");
            Console.WriteLine(Milan);
            Console.WriteLine(Dragan);
            Dragan.IzaberiDoktora(Milan);

            KrvniPritisak pregled1 = new KrvniPritisak(120, 80, 60);
            NivoSecera pregled2 = new NivoSecera(4, "20:20");

            Milan.ZakaziPregled(pregled1, Dragan);
            Dragan.ObaviPregled(pregled1);

            Milan.ZakaziPregled(pregled2, Dragan);
            Dragan.ObaviPregled(pregled2);

            //Milan.izlistaj();

            Console.ReadKey();
        }
    }
}
