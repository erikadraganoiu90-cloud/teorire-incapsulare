using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Car
    {
        //atribute si metode
        public string color;

        public string size;

        public int yearofproduction;

        public bool damaged;

        public int horsepower;

        public string Descriere()
        {
            string text = "";
            text += "Color " + color + "\n";
            text += "Size " + size + "\n";
            text += "Yearofproduction " + yearofproduction + "\n";
            text += "Damaged " + damaged + "\n";
            text += "Horsepower " + horsepower + "\n";

            return text;
        }
    }
}
