using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
     class User
    {
        //atribute
        public string username;
        public string password;

        public int age;
        public double salary;

        public bool activated;

        public string email;

        //metode
        //"Ana" +" are mre"=>" Ana are mere"
        public string Descriere()
        {
            string text = "";
            text += "Username " + username + "\n";
            text += "Password " + password + "\n";
            text += "Age " + age + "\n";
            text += "Salary " + salary + "\n";
            text += "Activated " + activated + "\n";
            text += "Email " + email + "\n";

            return text;


        }

    }
}
