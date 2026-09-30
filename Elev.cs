using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Elev
    {
        public string nume;
        public string clasa;
        public int nota1;
        public int nota2;
        public int nota3;

        public string DescriereElev()
        {
            string text = "";
            text += "Nume " + nume + "\n";
            text += "Clasa " + clasa + "\n";
            text += "Note " + nota1 + " " + nota2 + " " + nota3;
            return text;
        }
        public double media()
        {
            return (nota1 + nota2 + nota3) / 3.00;
        }

        public string promovalabilitate()
        {
            if (media() >= 5)
            {
                return "promovat/a";
            }
            else
            {
                return "nepromovat/a";
            }
        }
        //ex 7
        public int notaMax()
        {
            int max = nota1;
            if (nota2 > max)
            {
                max = nota2;
            }
            if (nota3 > max)
            {
                max = nota3;
            }
            return max;
        }
        public int notaMin()
        {
            int min = nota1;
            if (nota2 < min)
            {
                min = nota2;
            }
            if (nota3 < min)
            {
                min = nota3;
            }
            return min;
        }


    }

     
}

