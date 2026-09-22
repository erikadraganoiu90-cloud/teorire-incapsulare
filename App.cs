using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class App
    {
        static void Main(string[] args)
        {
            Useri();
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
    }
}
