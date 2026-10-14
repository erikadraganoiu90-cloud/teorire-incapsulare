using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Autor
    {
        public string nume;
        public int anNastere;
        public string tara;



        public string DescriereAutor()
        {
            string text = "";
            text += nume + " ";
            text += anNastere + " ";
            text+= tara +"\n";
            return text;
       }

        public Autor(string nume,int anNastere, string tara)
        {
            this.nume = nume;
            this.anNastere = anNastere;
            this.tara = tara;
        }
         
    }
}
