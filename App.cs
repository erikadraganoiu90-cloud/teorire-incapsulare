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
        static void Main(string[] args)
        {
            // Useri();
            //Car();
            //Carte();
            //Elev();
            //carte();
            // elev();
            //carteEx15();
            // Autor();
            //imprumut();
        }

        public static void Useri()
        {
            User x = new User();

            x.age = 1;
            x.username = "test";
            x.password = "test";
            x.email = "test1";
            x.activated = true;
            x.salary = 1;


            User a = new User();
            a.username = "test";
            a.email = "test";
            a.activated = true;
            a.password = "test";
            a.age = 12;
            a.salary = 12;

            User u1 = new User();
            u1.username = "ana";
            u1.email = "ana@mail.com";
            u1.password = "ana123";
            u1.age = 21;
            u1.salary = 3500;
            u1.activated = true;

            User u2 = new User();
            u2.username = "mihai";
            u2.email = "mihai@mail.com";
            u2.password = "mihai123";
            u2.age = 34;
            u2.salary = 6200;
            u2.activated = true;

            User u3 = new User();
            u3.username = "ioana";
            u3.email = "ioana@mail.com";
            u3.password = "ioana123";
            u3.age = 27;
            u3.salary = 4800;
            u3.activated = false;

            User u4 = new User();
            u4.username = "andrei";
            u4.email = "andrei@mail.com";
            u4.password = "andrei123";
            u4.age = 42;
            u4.salary = 8100;
            u4.activated = true;

            User u5 = new User();
            u5.username = "elena";
            u5.email = "elena@mail.com";
            u5.password = "elena123";
            u5.age = 19;
            u5.salary = 2900;
            u5.activated = false;

            User u6 = new User();
            u6.username = "radu";
            u6.email = "radu@mail.com";
            u6.password = "radu123";
            u6.age = 31;
            u6.salary = 5500;
            u6.activated = true;

            User u7 = new User();
            u7.username = "maria";
            u7.email = "maria@mail.com";
            u7.password = "maria123";
            u7.age = 25;
            u7.salary = 4200;
            u7.activated = true;

            User u8 = new User();
            u8.username = "george";
            u8.email = "george@mail.com";
            u8.password = "george123";
            u8.age = 50;
            u8.salary = 9300;
            u8.activated = false;

            User u9 = new User();
            u9.username = "cristina";
            u9.email = "cristina@mail.com";
            u9.password = "cristina123";
            u9.age = 38;
            u9.salary = 7000;
            u9.activated = true;

            User u10 = new User();
            u10.username = "vlad";
            u10.email = "vlad@mail.com";
            u10.password = "vlad123";
            u10.age = 23;
            u10.salary = 3900;
            u10.activated = false;



            List<User> users = new List<User>();


            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);
            users.Add(u6);
            users.Add(u7);
            users.Add(u8);
            users.Add(u9);
            users.Add(u10);


            Console.WriteLine("======================AFISAREA USERILOR============================");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].Descriere());

            }
        }

        public static void Car()
        {
            Car c1 = new Car();
            c1.color = "white";
            c1.size = "big";
            c1.yearofproduction = 2000;
            c1.horsepower = 570;
            c1.damaged = true;

            Car c2 = new Car();
            c2.color = "black";
            c2.size = "big";
            c2.yearofproduction = 2010;
            c2.horsepower = 600;
            c2.damaged = true;

            Car c3 = new Car();
            c3.color = "yellow";
            c3.size = "small";
            c3.yearofproduction = 2012;
            c3.horsepower = 620;
            c3.damaged = false;

            Car c4 = new Car();
            c4.color = "white";
            c4.size = "big";
            c4.yearofproduction = 2000;
            c4.horsepower = 520;
            c4.damaged = false;

            Car c5 = new Car();
            c5.color = "green";
            c5.size = "big";
            c5.yearofproduction = 2020;
            c5.horsepower = 580;
            c5.damaged = true;


            List<Car> cars = new List<Car>();

            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            cars.Add(c5);

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].Descriere());
            }
        }





        public static void Carte()
        {
            Carte ca1 = new Carte();
            ca1.autor = "Tatiana Țîbuleac";
            ca1.titlu = "Vara in care mama a avut ochii verzi";
            ca1.anAparitie = 2016;
            ca1.pret = 45; // int
            ca1.disponibila = "Da"; // string




            Carte ca2 = new Carte();
            ca2.autor = "Mihai Eminescu";
            ca2.titlu = "Poezii";
            ca2.anAparitie = 1883;
            ca2.pret = 35;
            ca2.disponibila = "Da";



            Carte ca3 = new Carte();
            ca3.autor = "Ion Creanga";
            ca3.titlu = "Amintiri din copilarie";
            ca3.anAparitie = 1892;
            ca3.pret = 25;
            ca3.disponibila = "Nu";


            Carte ca4 = new Carte();
            ca4.autor = "Liviu Rebreanu";
            ca4.titlu = "Ion";
            ca4.anAparitie = 1920;
            ca4.pret = 40;
            ca4.disponibila = "Da";


            Carte ca5 = new Carte();
            ca5.autor = "Mircea Eliade";
            ca5.titlu = "Maitreyi";
            ca5.anAparitie = 1933;
            ca5.pret = 38;
            ca5.disponibila = "Da";


            Carte ca6 = new Carte();
            ca6.autor = "George Orwell";
            ca6.titlu = "1984";
            ca6.anAparitie = 1949;
            ca6.pret = 42;
            ca6.disponibila = "Nu";


            Carte ca7 = new Carte();
            ca7.autor = "Antoine de Saint-Exupery";
            ca7.titlu = "Micul Print";
            ca7.anAparitie = 1943;
            ca7.pret = 30;
            ca7.disponibila = "Da";

            Carte ca8 = new Carte();
            ca8.autor = "Gabriel Garcia Marquez";
            ca8.titlu = "Un veac de singuratate";
            ca8.anAparitie = 1967;
            ca8.pret = 55;
            ca8.disponibila = "Da";

            Carte ca9 = new Carte();
            ca9.autor = "Marin Preda";
            ca9.titlu = "Morometii";
            ca9.anAparitie = 1955;
            ca9.pret = 48;
            ca9.disponibila = "Nu";

            Carte ca10 = new Carte();
            ca10.autor = "Fiodor Dostoievski";
            ca10.titlu = "Crima si pedeapsa";
            ca10.anAparitie = 1866;
            ca10.pret = 60;
            ca10.disponibila = "Da";

            List<Carte> carti = new List<Carte>();

            carti.Add(ca1);
            carti.Add(ca2);
            carti.Add(ca3);
            carti.Add(ca4);
            carti.Add(ca5);
            carti.Add(ca6);
            carti.Add(ca7);
            carti.Add(ca8);
            carti.Add(ca9);
            carti.Add(ca10);

            for (int i = 0; i < carti.Count; i++)
            {
                Console.WriteLine(carti[i].DescriereCarte());

                carti[i].ieftinire(24);
                Console.WriteLine("Veche? " + carti[i].veche());

                Console.WriteLine();

            }





        }

        public static void Elev()
        {

            Elev e1 = new Elev();
            e1.nume = "Popescu Ana";
            e1.clasa = "IX";
            e1.nota1 = 10;
            e1.nota2 = 8;
            e1.nota3 = 9;

            Elev e2 = new Elev();
            e2.nume = "Ionescu Vlad";
            e2.clasa = "X";
            e2.nota1 = 9;
            e2.nota2 = 7;
            e2.nota3 = 8;

            Elev e3 = new Elev();
            e3.nume = "Marinescu Elena";
            e3.clasa = "XI";
            e3.nota1 = 4;
            e3.nota2 = 4;
            e3.nota3 = 5;

            Elev e4 = new Elev();
            e4.nume = "Dumitrescu Andrei";
            e4.clasa = "XII";
            e4.nota1 = 6;
            e4.nota2 = 5;
            e4.nota3 = 2;

            Elev e5 = new Elev();
            e5.nume = "Vasilescu Maria";
            e5.clasa = "IX";
            e5.nota1 = 8;
            e5.nota2 = 9;
            e5.nota3 = 8;

            Elev e6 = new Elev();
            e6.nume = "Radu Mihai";
            e6.clasa = "X";
            e6.nota1 = 3;
            e6.nota2 = 2;
            e6.nota3 = 6;

            Elev e7 = new Elev();
            e7.nume = "Stoica Geanina";
            e7.clasa = "XI";
            e7.nota1 = 9;
            e7.nota2 = 9;
            e7.nota3 = 10;

            Elev e8 = new Elev();
            e8.nume = "Gheorghe Cristian";
            e8.clasa = "XII";
            e8.nota1 = 5;
            e8.nota2 = 6;
            e8.nota3 = 5;

            Elev e9 = new Elev();
            e9.nume = "Nistor Sofia";
            e9.clasa = "IX";
            e9.nota1 = 10;
            e9.nota2 = 9;
            e9.nota3 = 10;

            Elev e10 = new Elev();
            e10.nume = "Stan Matei";
            e10.clasa = "X";
            e10.nota1 = 8;
            e10.nota2 = 7;
            e10.nota3 = 9;

            List<Elev> elevi = new List<Elev>();

            elevi.Add(e1);
            elevi.Add(e2);
            elevi.Add(e3);
            elevi.Add(e4);
            elevi.Add(e5);
            elevi.Add(e6);
            elevi.Add(e7);
            elevi.Add(e8);
            elevi.Add(e9);
            elevi.Add(e10);


            for (int i = 0; i < elevi.Count; i++)
            {
                Console.WriteLine(elevi[i].DescriereElev());
                Console.WriteLine(elevi[i].promovalabilitate());
                Console.WriteLine("Nota maxima " + elevi[i].notaMax());
                Console.WriteLine("Nota minima " + elevi[i].notaMin());
                Console.WriteLine();
            }
        }

        //ex 8
        public static void carte()
        {
            Carte ca1 = new Carte();
            ca1.autor = "Tatiana Tibuleac";
            ca1.titlu = "Vara in care mama a avut ochii verzi";
            ca1.anAparitie = 2016;
            ca1.pret = 45; // int
            ca1.disponibila = "Da"; // string




            Carte ca2 = new Carte();
            ca2.autor = "Mihai Eminescu";
            ca2.titlu = "Poezii";
            ca2.anAparitie = 1883;
            ca2.pret = 35;
            ca2.disponibila = "Da";



            Carte ca3 = new Carte();
            ca3.autor = "Ion Creanga";
            ca3.titlu = "Amintiri din copilarie";
            ca3.anAparitie = 1892;
            ca3.pret = 25;
            ca3.disponibila = "Nu";


            Carte ca4 = new Carte();
            ca4.autor = "Liviu Rebreanu";
            ca4.titlu = "Ion";
            ca4.anAparitie = 1920;
            ca4.pret = 40;
            ca4.disponibila = "Da";


            Carte ca5 = new Carte();
            ca5.autor = "Mircea Eliade";
            ca5.titlu = "Maitreyi";
            ca5.anAparitie = 1933;
            ca5.pret = 38;
            ca5.disponibila = "Da";


            Carte ca6 = new Carte();
            ca6.autor = "George Orwell";
            ca6.titlu = "1984";
            ca6.anAparitie = 1949;
            ca6.pret = 42;
            ca6.disponibila = "Nu";


            Carte ca7 = new Carte();
            ca7.autor = "Antoine de Saint-Exupery";
            ca7.titlu = "Micul Print";
            ca7.anAparitie = 1943;
            ca7.pret = 30;
            ca7.disponibila = "Da";

            Carte ca8 = new Carte();
            ca8.autor = "Gabriel Garcia Marquez";
            ca8.titlu = "Un veac de singuratate";
            ca8.anAparitie = 1967;
            ca8.pret = 55;
            ca8.disponibila = "Da";


            List<Carte> carti2 = new List<Carte>();

            carti2.Add(ca1);
            carti2.Add(ca2);
            carti2.Add(ca3);
            carti2.Add(ca4);
            carti2.Add(ca5);
            carti2.Add(ca6);
            carti2.Add(ca7);
            carti2.Add(ca8);
            Console.WriteLine("----------TOATE CARTILE--------");
            for (int i = 0; i < carti2.Count; i++)
            {
                Console.WriteLine(carti2[i].Descrierecarte());
                Console.WriteLine();
            }
            Console.WriteLine("----------DISPONIBILE----------");
            for (int i = 0; i < carti2.Count; i++)
            {
                if (carti2[i].disponibila == "Da")
                {
                    Console.WriteLine(carti2[i].Descrierecarte());
                }
            }
            //Ex 9
            if (carti2.Count == 0)
            {
                Console.WriteLine("Lista e goala.");
            }
            else
            {
                string titluScump = carti2[0].titlu;
                double pretMax = carti2[0].pret;

                string titluVechi = carti2[0].titlu;
                int anMinim = carti2[0].anAparitie;

                for (int i = 0; i < carti2.Count; i++)
                {
                    if (carti2[i].pret > pretMax)
                    {
                        pretMax = carti2[i].pret;
                        titluScump = carti2[i].titlu;
                    }
                    if (carti2[i].anAparitie < anMinim)
                    {
                        anMinim = carti2[i].anAparitie;
                        titluVechi = carti2[i].titlu;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Cea mai scumpa " + titluScump);
                Console.WriteLine("Cea mai veche " + titluVechi);
                Console.WriteLine();
            }
            //ex 10
            int suma = 0;
            for (int i = 0; i < carti2.Count; i++)
            {
                suma = suma + carti2[i].pret;
            }

            double medie = suma / carti2.Count;
            Console.WriteLine("Pretul mediu " + medie);

            int ct = 0;
            for (int i = 0; i < carti2.Count; i++)
            {
                if (carti2[i].pret < medie)
                {
                    ct++;
                    Console.WriteLine(carti2[i].titlu);
                }
            }
            Console.WriteLine("Cate sub medie " + ct);
            Console.WriteLine();
            //Ex 11
            App app = new App();
            Console.WriteLine(app.CautaDupaTitlu(carti2, "Maitreyi"));
            Console.WriteLine();
            Console.WriteLine(app.CautaDupaTitlu(carti2, "Cismigiu & Comp"));
            Console.WriteLine();
            //Ex 12
            Console.WriteLine(app.NumaraCartiAutor(carti2, "Mircea Eliade"));

            List<Carte> aleLui = app.CartileAutorului(carti2, "Mircea Eliade");
            for (int i = 0; i < aleLui.Count; i++)
            {
                Console.WriteLine(aleLui[i].DescriereCarte());
            }

            //Ex 13
            app.SorteazaDupaPret(carti2);

            for (int i = 0; i < carti2.Count; i++)
            {
                Console.WriteLine(carti2[i].DescriereCarte());
                Console.WriteLine();
            }



        }
        //Ex 11
        public string CautaDupaTitlu(List<Carte> lista, string titlu)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].titlu == titlu)
                {
                    return lista[i].DescriereCarte();
                }
            }
            return "Nu exista nicio carte cu titlul asta.";


        }
        //Ex 12
        public int NumaraCartiAutor(List<Carte> lista, string autor)
        {
            int ct = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].autor == autor)
                {
                    ct++;
                }
            }
            return ct;
        }
        public List<Carte> CartileAutorului(List<Carte> lista, string autor)
        {
            List<Carte> CartiGasite = new List<Carte>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].autor == autor)
                {
                    CartiGasite.Add(lista[i]);
                }
            }
            return CartiGasite;
        }

        //Ex 13
        public void SorteazaDupaPret(List<Carte> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].pret > lista[j].pret)
                    {
                        Carte aux = lista[i];
                        lista[i] = lista[j];
                        lista[j] = aux;
                    }
                }
            }
        }

        //Ex 14
        public static void elev()
        {
            Elev el1 = new Elev();
            el1.nume = "Popescu Ana";
            el1.clasa = "IX";
            el1.nota1 = 10;
            el1.nota2 = 8;
            el1.nota3 = 9;

            Elev el2 = new Elev();
            el2.nume = "Ionescu Vlad";
            el2.clasa = "X";
            el2.nota1 = 9;
            el2.nota2 = 7;
            el2.nota3 = 8;

            Elev el3 = new Elev();
            el3.nume = "Marinescu Elena";
            el3.clasa = "XI";
            el3.nota1 = 4;
            el3.nota2 = 4;
            el3.nota3 = 5;

            Elev el4 = new Elev();
            el4.nume = "Dumitrescu Andrei";
            el4.clasa = "XII";
            el4.nota1 = 6;
            el4.nota2 = 5;
            el4.nota3 = 2;

            Elev el5 = new Elev();
            el5.nume = "Vasilescu Maria";
            el5.clasa = "IX";
            el5.nota1 = 8;
            el5.nota2 = 9;
            el5.nota3 = 8;

            Elev el6 = new Elev();
            el6.nume = "Radu Mihai";
            el6.clasa = "X";
            el6.nota1 = 3;
            el6.nota2 = 2;
            el6.nota3 = 6;

            List<Elev> elevi2 = new List<Elev>();

            elevi2.Add(el1);
            elevi2.Add(el2);
            elevi2.Add(el3);
            elevi2.Add(el4);
            elevi2.Add(el5);
            elevi2.Add(el6);
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(elevi2[i].DescriereElev());
                Console.WriteLine();
            }

            double suma = 0;
            for (int i = 0; i < 6; i++)
            {
                suma += elevi2[i].media();
            }

            double mediaClasei = suma / 6;
            Console.WriteLine("Media clasei " + Math.Round(mediaClasei, 2));

            Elev max = elevi2[0];
            for (int i = 1; i < 6; i++)
            {
                if (elevi2[i].media() > max.media())
                {
                    max = elevi2[i];
                }

            }

            Console.WriteLine("Cea mai mare medie " + max.nume + " " + max.media());

            int promovati = 0;
            for (int i = 0; i < 6; i++)
            {
                if (elevi2[i].media() >= 5)
                {
                    promovati++;
                }
            }
            Console.WriteLine("Numar elevi promovati " + promovati);
            Console.WriteLine("Numar elevi nepromovati " + (6 - promovati));


        }
        //Ex 15
        public static void carteEx15()
        {
            Carte c = new Carte();
            c.titlu = "Maitreyi";
            c.pret = 42;

            List<Carte> l1 = new List<Carte>();
            List<Carte> l2 = new List<Carte>();
            l1.Add(c);
            l2.Add(c);

            l1[0].pret = 100;
            Console.WriteLine(l2[0].pret);

            // Am văzut că prețul schimbat prin l1 apare și în l2, pentru că ambele liste țin referință spre același obiect din heap.
            // În C++ cu obiect pe stivă s-ar fi făcut o copie în fiecare listă, deci schimbarea din prima listă nu s - ar fi văzut în a doua.
        }
        //Ex 16
        //public static void Autor()
        // {
        // Autor a1 = new Autor();
        /// a1.nume="Mircea Eliade";
        // a1.anNastere = 1907;
        // a1.tara = "Romania";

        // List<Autor> autori = new List<Autor>();
        // autori.Add(a1);
        //Console.WriteLine(a1.DescriereAutor());
        // }
        // }


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

        
         
        

        



 
         
       

        

        

 

 



