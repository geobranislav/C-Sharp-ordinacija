using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    class Vreme
    {

        private int sati;
        private int minuti;

        public Vreme(int sati, int minuti)
        {
            this.sati = sati;
            this.minuti = minuti;
        }

        public int Sati
        {
            get
            {
                return sati;
            }

            set
            {
                if((value > 0) && (value < 24))
                {
                    sati = value;
                }
            }
        }

        public int Minuti
        {
            get
            {
                return minuti;
            }

            set
            {
                if((value > 0) && (value < 60))
                {
                    minuti = value;
                }
            }

        }

        public override string ToString()
        {
            return "Vreme: " + sati + ":" + minuti;
        }
    }
}
