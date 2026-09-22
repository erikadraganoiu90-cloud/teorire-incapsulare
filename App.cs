using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace teorie_incapsulare
{
    internal class App
    {
        static void Main(string[] args)
        {
            Carte();
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

            for(int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i].Descriere());
            }
        }


        public static void Carte()
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

            for(int i = 0; i < carti.Count; i++)
            {
                Console.WriteLine(carti[i].Descriere());
            }

            Console.WriteLine(ca1.AnideDeLaAparitie());
        }

    }


}
