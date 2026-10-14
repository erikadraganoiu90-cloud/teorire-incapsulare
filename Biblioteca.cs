using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Biblioteca
    {
        public string nume;
        public List<Carte> carti = new List<Carte>();
        public List<imprumut> imprumuturi = new List<imprumut>();


        public Biblioteca() { 
        
            Load();
        }


        public void Load()

        {

            carti.Add(new Carte("Amintiri din copilarie", new Autor("Ion Creanga", 1837, "Romania"), 25));


            

             

            imprumut i1 = new imprumut();
            i1.nume = "Maria"; i1.carte = "Ion"; i1.nrZile = 20;
            imprumut i2 = new imprumut();
            i2.nume = "Andrei"; i2.carte = "Hamlet"; i2.nrZile = 10;
            imprumut i3 = new imprumut();
            i3.nume = "Dana"; i3.carte = "Baltagul"; i3.nrZile = 30;
            imprumuturi.Add(i1);
            imprumuturi.Add(i2);
            imprumuturi.Add(i3);
        }



        public Carte CeaMaiScumpaCarte()
        {

            Carte cartePretMaxim = carti[0];

            for (int i = 1; i < carti.Count; i++)
            {
                if (carti[i].Pret > cartePretMaxim.Pret)
                {
                    cartePretMaxim = carti[i];
                }

            }

            return cartePretMaxim;

        }


        //functie de afisare carti

         


        

     
   

        // 1. Cauta o carte dupa titlu
        public Carte CautaDupaTitlu(string titlu)
        {
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].Titlu == titlu)
                {
                    return carti[i];
                }
            }
            return null;
        }

         
         

        // 5a. Total penalizari
        public int TotalPenalizari()
        {
            int suma = 0;
            for (int i = 0; i < imprumuturi.Count; i++)
            {
                suma = suma + imprumuturi[i].penalizare();
            }
            return suma;
        }

        // 5b. Imprumutul cu cea mai mare intarziere
        public imprumut CelMaiIntarziat()
        {
            imprumut max = imprumuturi[0];
            for (int i = 1; i < imprumuturi.Count; i++)
            {
                if (imprumuturi[i].nrZile > max.nrZile)
                {
                    max = imprumuturi[i];
                }
            }
            return max;
        }

    }
}