using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace teorie_incapsulare
{
    internal class Carte
    {
        public string titlu;
        public string autor;
        public int anAparitie;
        public int pret;
        public string disponibila;

   
        public string Descriere()
        {
            string text = "";
            text += "Ttitlu " + titlu + "\n";
            text += "Autor " + autor + "\n";
            text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + pret + "\n";
            text += "Disponibila " + disponibila + "\n";
            text += "Ani de la aparitie " +AnideDeLaAparitie() + "\n";
            return text;
        }


        public int AnideDeLaAparitie()
        {
            return 2026 - anAparitie;
        }
    }
}
