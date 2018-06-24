using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Pacijent
    {

        private string ime;
        private string prezime;
        private string jmbg;
        private string br_kartona;

        public Pacijent(string ime, string prezime, string jmbg, string br_kartona)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.br_kartona = br_kartona;
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

        public string Jmbg
        {
            get
            {
                return jmbg;
            }

            set
            {
                if (value.Length == 13)
                    jmbg = value;
                else
                    Console.WriteLine("Neodgovarajuci format maticnog broja");
            }

        }

        public string Br_kartona
        {
            get
            {
                return br_kartona;
            }

            set
            {
                br_kartona = value;
            }
        }

        public void IzaberiDoktora(Doktor doktor)
        {
            Console.WriteLine("Pacijent je izabrao doktora " + doktor.Ime + " kao svog izabranog lekara.\n");
            doktor.DodajPacijenta(this);
        }

        public void ObaviPregled(Pregled pregled)
        {
            Console.WriteLine("Pacijent Obavio pregled");
            pregled.Izracunaj();
        }

        public override string ToString()
        {
            return "Pacijent: " + ime + " " + prezime + " " + jmbg + " - Broj kartona: " + br_kartona;
        }
    }
}
