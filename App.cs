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

           
            try
            {
                
                    // 1. Constructorul tine minte tot
                    Music m1 = new Music("Bohemian Rhapsody", "Queen", MusicGenre.Rock, 355, 1975, true, 150);
                    Console.WriteLine(m1.Title + " - " + m1.Artist + " - " + m1.ReleaseYear);
                    Console.WriteLine("favorita: " + m1.IsFavorite);
                    Console.WriteLine("ascultari: " + m1.PlayCount);

                    // 2. Al doilea constructor
                    Music m2 = new Music("Imagine", "John Lennon", 183);
                    Console.WriteLine(m2.Title + " - " + m2.Artist + " - " + m2.Genre);
                    Console.WriteLine("favorita: " + m2.IsFavorite);
                    Console.WriteLine("ascultari: " + m2.PlayCount);

                    // 3. Durata ca minute:secunde
                    Console.WriteLine(m1.Duration);
                    Console.WriteLine(m2.Duration);
                    Console.WriteLine(new Music("Intro", "X", 65).Duration);
                    Console.WriteLine(new Music("Lunga", "X", 600).Duration);

                    // 4. Validarea
                    try { 
                       m1.ReleaseYear = 1500;
                    }
                    catch (ArgumentException e) { Console.WriteLine(e.Message); }
                    Console.WriteLine(m1.ReleaseYear);

                    try {
                        m1.Title = "  ";
                    }
                    catch (ArgumentException e) {
                        Console.WriteLine(e.Message); 
                    }
                    Console.WriteLine(m1.Title);

                    try
                    {
                        Music m3 = new Music("Yesterday", "The Beatles", -10);
                        Console.WriteLine("creata");
                    }
                    catch (ArgumentException e) { 
                       Console.WriteLine(e.Message); 
                    }
                    
                    Console.WriteLine(m2.Rating); // 0
                    m2.Rating = 4;
                    Console.WriteLine(m2.Rating); // 4
                    try { m2.Rating = 7; }
                    catch (ArgumentException e) { Console.WriteLine(e.Message); }
                    Console.WriteLine(m2.Rating); // tot 4, ca set-ul cu 7 a dat throw inainte de rating = value


                 

                Playlist p = new Playlist("Drum lung");
                Music hotel = new Music("Hotel California", "Eagles",MusicGenre.Rock, 391, 1976, false, 90);
                Music take = new Music("Take Five", "Dave Brubeck", MusicGenre.Jazz, 324, 1959, true, 40);
                Console.WriteLine(p.Add(m1));
                Console.WriteLine(p.Add(m2));
                Console.WriteLine(p.Add(hotel));
                Console.WriteLine(p.Add(take));
                Console.WriteLine(p.Add(new Music("Imagine", "John Lennon", 183)));
                Console.WriteLine(p.Name + ": " + p.Count + " melodii, "+ p.TotalDuration);

                m2.Play(); m2.Play(); m2.Play();
                Music top = p.MostPlayed();
                Console.WriteLine("cea mai ascultata: " + top.Title+ " (" + top.PlayCount + ")");

                List<Music> fav = p.Favorites();
                Console.WriteLine(fav.Count + " favorite");
                for (int i = 0; i < fav.Count; i++)
                {
                    Console.WriteLine(fav[i].Title);
                }

                m2.AddToFavorites();
                Console.WriteLine(p.Favorites().Count + " favorite");

                Playlist gol = new Playlist("Gol");
                if (gol.MostPlayed() == null)
                {
                    Console.WriteLine("playlist gol");
                }
                Console.WriteLine(gol.Count + " melodii, " + gol.TotalDuration);


            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
             


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

        
         
        

        



 
         
       

        

        

 

 



