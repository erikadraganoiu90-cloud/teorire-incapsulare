using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace teorie_incapsulare
{
    internal class Carte
    {
        public string Titlu;

       
        public Autor Autor;
         
       private double pret;
        public bool Disponibila;

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

        public string DescriereCarte()
        {
            string text = "";
            text += "Ttitlu " + Titlu + "\n";
            text += "Autor " + Autor.nume + "\n";
            text += "An nastere " + Autor.anNastere + "\n";
            text += "Tara " + Autor.tara + "\n";
           // text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + Pret +" lei"+" \n";
          //  text += "Disponibila " + disponibila + "\n";
           // text += "Ani de la aparitie " + AnideDeLaAparitie() + "\n";
           // text += "Pret dupa reducere " + reducere(20);
            
             
 

            return text;
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
            Disponibila = true;

        }
    }
}
     
 
