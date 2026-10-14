using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace teorie_incapsulare
{
    internal class App
    {
        //constructorii 
        // sunt functii ce se apeleaza automat la crearea unui obiect
        // au acelasi nume ca si clasa
        // se pot supraincarca
        // nu au tip returnat

         
        static void Main(string[] args)
        {
            Biblioteca b=new Biblioteca();
            Carte c = b.CautaDupaTitlu("Baltagul");
            c.Returneaza();
            Console.WriteLine(c.Disponibila);

           try { c.Pret = -5; }
           catch (ArgumentException e) {
               Console.WriteLine(e.Message);
           }
           Console.WriteLine(c.Pret);

            try { c.Titlu = ""; }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            try { Autor a=new Autor("",1880)}
             

        }
         

        //Ex 18
        
        public static void imprumut()
        {
            imprumut i1 = new imprumut();
            i1.nume = "Andrei Popescu";
            i1.carte = "Baltagul";
            i1.nrZile = 14;
           

            imprumut i2 = new imprumut();
            i2.nume = "Elena Dumitru";
            i2.carte = "Ion";
            i2.nrZile = 21;

            imprumut i3 = new imprumut();
            i3.nume = "Mihai Avram";
            i3.carte = "Enigma Otiliei";
            i3.nrZile = 7;

            imprumut i4 = new imprumut();
            i4.nume = "Ioana Radu";
            i4.carte = "Maitreyi";
            i4.nrZile = 30;

            imprumut i5 = new imprumut();
            i5.nume = "Stefan Marin";
            i5.carte = "Morometii";
            i5.nrZile = 10;

            List <imprumut> imprumuturi=new List<imprumut>();
            imprumuturi.Add(i1);
            imprumuturi.Add(i2);
            imprumuturi.Add(i3);
            imprumuturi.Add(i4);
            imprumuturi.Add(i5);

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(imprumuturi[i].DescriereImprumut());
                Console.WriteLine();
            }
        }


    }

}

        
         
        

        



 
         
       

        

        

 

 



