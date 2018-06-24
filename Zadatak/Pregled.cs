using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    public abstract class Pregled
    {
        public abstract void Izracunaj();
    }

    public class KrvniPritisak : Pregled {

        private int gornjaVrednost;
        private int donjaVrednost;
        private int puls;

        public KrvniPritisak(int gornjaVrednost, int donjaVrednost, int puls)
        {
            this.donjaVrednost = donjaVrednost;
            this.gornjaVrednost = gornjaVrednost;
            this.puls = puls;
        }

        public int GornjaVrednost
        {
            get
            {
                return gornjaVrednost;
            }
                 
            set
            {
                gornjaVrednost = value;
            }
        }

        public int DonjaVrednost
        {
            get
            {
                return donjaVrednost;
            }

            set
            {
                donjaVrednost = value;
            }
        }

        public int Puls
        {
            get
            {
                return puls;
            }

            set
            {
                puls = value;
            }
        }

        public override void Izracunaj()
        {
            Console.WriteLine("Vrednosti: Puls: " + puls + "\nGornja vrednost: " + gornjaVrednost + "\nDonja vrednost: " + donjaVrednost + "\n");
        }

        public override string ToString()
        {
            return "Pregled: Krvni pritisak";
        }

    }

    public class NivoSecera : Pregled
    {

        private int vrednost;
        private string vreme;

        public NivoSecera(int vrednost, string vreme)
        {
            this.vrednost = vrednost;
            this.vreme = vreme;
        }

        public int Vrednost
        {
            get 
            {
                return vrednost;
            }

            set
            {
                vrednost = value;
            }
        }

        public string Vreme
        {
            get
            {
                return vreme;
            }

            set
            {
                vreme = value;
            }
        }


        public override void Izracunaj()
        {
            if(vrednost > 7) 
                Console.WriteLine("Na osnovu izracunatih vrednost - Bolesni ste!\n");
            else
                Console.WriteLine("Na osnovu izracunatih vrednost - Zdravi ste!\n");
        }


        public override string ToString()
        {
            return "Pregled: Nivo secera";
        }

    }

    public class NivoHolesterola : Pregled
    {

        private int vrednost;
        private string vreme;

        public NivoHolesterola(int vrednost, string vreme)
        {
            this.vrednost = vrednost;
            this.vreme = vreme;
        }

        public int Vrednost
        {
            get
            {
                return vrednost;
            }

            set
            {
                vrednost = value;
            }
        }

        public string Vreme
        {
            get
            {
                return vreme;
            }

            set
            {
                vreme = value;
            }
        }

        public override void Izracunaj()
        {
            if(vrednost > 30)
                Console.WriteLine("Na osnovu izracunatih vrednost - Bolesni ste!\n");
            else
                Console.WriteLine("Na osnovu izracunatih vrednost - Zdravi ste!\n");
        }

        public override string ToString()
        {
            return "Pregled: Nivo holesterola";
        }
    }
    
}
