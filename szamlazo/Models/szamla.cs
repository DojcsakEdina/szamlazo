using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamlazo.Models
{
    public class Szamla
    {
        private double netto;
        public Szamla(double netto)
        {
            this.netto = netto;
        }
        public double Netto
        {
            get 
            { 
                return netto; 
            }
            set
            {
                netto = value;
            }
        }
        public double Brutto
        {
            get
            {
                double brutto = netto + (netto * 0.27);
                return brutto;
            }
        }

        public override string ToString()
        {
            string result = "A termék ára: " + Netto + " Ft\n";
            result += "Az Áfa: " + (netto * 0.27) + " Ft\n";
            result += "Bruttó ár: " + Brutto + " Ft\n";
            return result;
        }
    }
}
