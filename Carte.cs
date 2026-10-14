using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace teorie_incapsulare
{
    internal class Carte
    {
        private string titlu;

       
        private Autor autor;
         
        private double pret;
        private bool disponibila;

        public string Titlu
        {
            get { return titlu; }
            set
            {
                if (value == null||)
                {
                    throw new ArgumentNullException("Titlul nu are voie sa fie gol");
                }
                titlu = value;
            }
        }
        public Autor Autor
        {
            get { return autor; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Autorul nu are voie sa fie null");
                }
                autor = value;
            }
        }
        public double Pret
        {
            get { return pret; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Pretul trebuie sa fie mai mare ca 0");
                }
                pret = value;
            }
        }

        public bool Disponibila
        {
            get { return disponibila; }
        }
        public string DescriereCarte()
        {
            string text = "";
            text += "Ttitlu " + Titlu + "\n";
            text += "Autor " + Autor.Nume + "\n";
            text += "An nastere " + Autor.AnNastere + "\n";
            text += "Tara " + Autor.Tara + "\n";
           // text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + Pret +" lei"+" \n";
          //  text += "Disponibila " + disponibila + "\n";
           // text += "Ani de la aparitie " + AnideDeLaAparitie() + "\n";
           // text += "Pret dupa reducere " + reducere(20);
            
             
 

            return text;
        }
public void Returneaza()
        {
            disponibila = true;
        }
        public bool Imprumuta()
        {
            if (disponibila == false)
            {
                return false;
            }
            disponibila = false;
            return true;
        }
         
        
        public string Descrierecarte()
        {
            string text = "";
             
            text += "Ttitlu " + Titlu + "\n";
            text += "Autor " + Autor + "\n";
            //text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + pret + "\n";
            text += "Disponibila " + Disponibila + "\n";
             

            return text;
        }

         
        public Carte(string titlu,Autor autor, double pret)
        {
            this.Titlu = titlu;
            this.Autor = autor;
            Pret = pret;
            disponibila = true;

        }
    }
}
     
 
