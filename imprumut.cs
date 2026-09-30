using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class imprumut
    {
        public string nume;
        public string carte;
        public int nrZile;

        public string DescriereImprumut()
        {
            string text = "";
            text += nume + " " + "-" + " " + carte + " " + "-" + " " + nrZile+" zile"+ " " + "-" + " " +intarziere()+ " " + "-" + " " +penalizare();
            return text;
        }

        public string intarziere()
        {
            if (nrZile > 14)
            {
                return "intarziere ";
            }
            else
            {
                return  "in termen";
            }
        }

        public int penalizare()
        {
            if (nrZile <=14)
            {
                return 0;
            }
            else
            {
                return (nrZile - 14) * 2;
            }
        }
    }
}
