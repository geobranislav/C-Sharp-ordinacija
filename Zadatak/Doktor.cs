using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Doktor
    {

        private string ime;
        private string prezime;
        private string specijalnost;

        List<Pacijent> pacijenti = new List<Pacijent>();

        public Doktor(string ime, string prezime, string specijalnost)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.specijalnost = specijalnost;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Specijalnost
        {
            get
            {
                return specijalnost;
            }

            set
            {
                specijalnost = value;
            }
        }

        public void ZakaziPregled(Pregled pregled, Pacijent pacijent)
        {
            Console.WriteLine(pregled  +" za "+ pacijent + " zakazan\n");
        }

        public void DodajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
        }

        public void izlistaj()
        {
            for(int i=0; i < pacijenti.Count; i++)
            {
                Console.WriteLine(pacijenti[i]);
            }
        }

        public override string ToString()
        {
            return "Doktor: " + ime + " " + prezime + "\nspecijalnost - " + specijalnost + "\n";
        }

    }
}
