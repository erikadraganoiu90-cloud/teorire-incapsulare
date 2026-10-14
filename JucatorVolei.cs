using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace teorie_incapsulare
{
    internal class JucatorVolei
    {
        private string nume;
        private int anNastere;
        private int pase;
        private int meciuriCastigate;
        private int meciuriPierdute;

        public JucatorVolei(string nume,int anNastere, int meciuriCastigate,int meciuriPierdute )
        {
            Nume = nume;
            AnNastere= anNastere;
            this.pase = 0;
            MeciuriCastigate = meciuriCastigate;
            MeciuriPierdute = meciuriPierdute;

        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Numele nu poate fi gol.");
                }
                nume = value;
            }
        }
        public int AnNastere
        {
            get { return anNastere; }
            set
            {
                if (value < 1970 || value > 2010)
                {
                    throw new ArgumentException("Anul nasterii trebuie sa fie intre 1970 si 2010.");
                }
                anNastere= value;
            }
        }
        public int Pase
        {
            get { return pase; }
        }
        public void AdaugaPase()
        {
            pase++;
        }

        public int MeciuriCastigate
        {
            get { return  meciuriCastigate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Numarul meciurilor castigate nu poate fi negativ.");
                }
                meciuriCastigate= value;
            }
        }
        public int MeciuriPierdute
        {
            get { return meciuriPierdute; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Numarul meciurilor pierdute nu poate fi negativ.");
                }
                meciuriPierdute = value;
            }
        }




    }
}
