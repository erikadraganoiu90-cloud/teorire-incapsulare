using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Autor
    {
        private string nume;
        private int anNastere;
        private string tara;

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Numele nu are voie sa fie gol");
                }
                nume = value;
            }
        }

        public int AnNastere
        {
            get { return anNastere;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Anul nasterii trebuie sa fie mai mare ca 0");
                }
                anNastere = value;
            }
        }

        public string Tara
        {
            get { return tara; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Tara nu are voie sa fie goala");
                }
                tara = value;
            }
        }

        public string DescriereAutor()
        {
            string text = "";
            text += Nume + " ";
            text += AnNastere + " ";
            text+= Tara +"\n";
            return text;
       }

        public Autor(string nume,int anNastere, string tara)
        {
            this.Nume = nume;
            this.AnNastere = anNastere;
            this.Tara = tara;
        }
         
    }
}
