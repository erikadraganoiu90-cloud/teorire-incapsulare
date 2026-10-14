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

             
            carti.Add(new Carte("Scrisoarea III", new Autor("Mihai Eminescu", 1850, "Romania"), 20));
            carti.Add(new Carte("Dune", new Autor("Frank Herbet", 1920, "SUA"), 45));
            carti.Add(new Carte("Baltagul", new Autor("Mihail Sadoveanu", 1880, "Romania"), 28));
            carti.Add(new Carte("Maitreyi", new Autor("Mircea Eliade", 1907, "Romania"), 35));
            carti.Add(new Carte("Enigma Otiliei", new Autor("George Calinescu", 1899, "Romania"), 40));
            carti.Add(new Carte("Ion", new Autor("Liviu Rebreanu", 1885, "Romania"), 45));
            carti.Add(new Carte("Ultima noapte de dragoste, intaia noapte de razboi", new Autor("Camil Petrescu", 1894, "Romania"), 38));
            carti.Add(new Carte("Morometii", new Autor("Marin Preda", 1922, "Romania"), 50));
            carti.Add(new Carte("Micul print", new Autor("Antoine de Saint-Exupery", 1900, "Franta"), 22));
            carti.Add(new Carte("Procesul", new Autor("Franz Kafka", 1883, "Cehia"), 32));





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