using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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



        public string DescriereCarte()
        {
            string text = "";
            text += "Ttitlu " + titlu + "\n";
            text += "Autor " + autor + "\n";
            text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + pret + "\n";
            text += "Disponibila " + disponibila + "\n";
            text += "Ani de la aparitie " + AnideDeLaAparitie() + "\n";
            text += "Pret dupa reducere " + reducere(20);
             

            return text;
        }

        //Ex 2
        public int AnideDeLaAparitie()
        {
            return 2026 - anAparitie;
        }
        //Ex 3
        public int reducere(int procent)
        {

            return pret - pret * procent / 100;
        }
        //Ex 4
        public void ieftinire(int suma)
        {
            Console.WriteLine("Inainte " + pret);
            int pret2 = pret - suma;
            Console.WriteLine("Dupa " + pret2);


        }//diferenta intre ex 3 si ex4:Ex 3 calculeaza si face return,fara sa modifice pretul,iar Ex 4 modifica pretul si se foloseste de void.

        //ex 5
        public bool veche()
        {
            if (AnideDeLaAparitie() > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
//ex 8
        public string Descrierecarte()
        {
            string text = "";
             
            text += "Ttitlu " + titlu + "\n";
            text += "Autor " + autor + "\n";
            text += "An aparitie " + anAparitie + "\n";
            text += "Pret " + pret + "\n";
            text += "Disponibila " + disponibila + "\n";
             

            return text;
        }

        

    }
}
     
 
