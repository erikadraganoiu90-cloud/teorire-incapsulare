using System;
using System.Collections.Generic;
using System.Text;

namespace teorie_incapsulare
{
    internal class Biblioteca
    {
        public string nume;
        public List<Carte> carti = new List<Carte>();


        public void Load()

        {
            Carte carte1 = new Carte();
            carte1.titlu = "Amintiri din copilarie";
            carte1.anAparitie = 1892;
            carte1.pret = 25;
            carte1.disponibila = "Da";
            carte1.autor = new Autor();
            carte1.autor.nume = "Ion Creanga";
            carte1.autor.anNastere = 1837;
            carte1.autor.tara = "Romania";


            Carte carte2 = new Carte();
            carte2.titlu = "Poezii";
            carte2.anAparitie = 1883;
            carte2.pret = 30;
            carte2.disponibila = "Da";
            carte2.autor = new Autor();
            carte2.autor.nume = "Mihai Eminescu";
            carte2.autor.anNastere = 1850;
            carte2.autor.tara = "Romania";


            Carte carte3 = new Carte();
            carte3.titlu = "Baltagul";
            carte3.anAparitie = 1930;
            carte3.pret = 22;
            carte3.disponibila = "Nu";
            carte3.autor = new Autor();
            carte3.autor.nume = "Mihail Sadoveanu";
            carte3.autor.anNastere = 1880;
            carte3.autor.tara = "Romania";


            Carte carte4 = new Carte();
            carte4.titlu = "Enigma Otiliei";
            carte4.anAparitie = 1938;
            carte4.pret = 35;
            carte4.disponibila = "Da";
            carte4.autor = new Autor();
            carte4.autor.nume = "George Calinescu";
            carte4.autor.anNastere = 1899;
            carte4.autor.tara = "Romania";


            Carte carte5 = new Carte();
            carte5.titlu = "Ion";
            carte5.anAparitie = 1920;
            carte5.pret = 28;
            carte5.disponibila = "Da";
            carte5.autor = new Autor();
            carte5.autor.nume = "Liviu Rebreanu";
            carte5.autor.anNastere = 1885;
            carte5.autor.tara = "Romania";


            Carte carte6 = new Carte();
            carte6.titlu = "Maitreyi";
            carte6.anAparitie = 1933;
            carte6.pret = 40;
            carte6.disponibila = "Nu";
            carte6.autor = new Autor();
            carte6.autor.nume = "Mircea Eliade";
            carte6.autor.anNastere = 1907;
            carte6.autor.tara = "Romania";


            Carte carte7 = new Carte();
            carte7.titlu = "Morometii";
            carte7.anAparitie = 1955;
            carte7.pret = 45;
            carte7.disponibila = "Da";
            carte7.autor = new Autor();
            carte7.autor.nume = "Marin Preda";
            carte7.autor.anNastere = 1922;
            carte7.autor.tara = "Romania";


            Carte carte8 = new Carte();
            carte8.titlu = "Hamlet";
            carte8.anAparitie = 1603;
            carte8.pret = 50;
            carte8.disponibila = "Da";
            carte8.autor = new Autor();
            carte8.autor.nume = "William Shakespeare";
            carte8.autor.anNastere = 1564;
            carte8.autor.tara = "Marea Britanie";


            Carte carte9 = new Carte();
            carte9.titlu = "Crima si pedeapsa";
            carte9.anAparitie = 1866;
            carte9.pret = 55;
            carte9.disponibila = "Nu";
            carte9.autor = new Autor();
            carte9.autor.nume = "Fyodor Dostoevsky";
            carte9.autor.anNastere = 1821;
            carte9.autor.tara = "Rusia";


            Carte carte10 = new Carte();
            carte10.titlu = "Marele Gatsby";
            carte10.anAparitie = 1925;
            carte10.pret = 38;
            carte10.disponibila = "Da";
            carte10.autor = new Autor();
            carte10.autor.nume = "F. Scott Fitzgerald";
            carte10.autor.anNastere = 1896;
            carte10.autor.tara = "SUA";

            Carte carte11 = new Carte();
            carte11.titlu = "Luceafarul";
            carte11.anAparitie = 1883;
            carte11.pret = 32;
            carte11.disponibila = "Da";
            carte11.autor = new Autor();
            carte11.autor.nume = "Mihai Eminescu";
            carte11.autor.anNastere = 1850;
            carte11.autor.tara = "Romania";

            Carte carte12 = new Carte();
            carte12.titlu = "Scrisoarea III";
            carte12.anAparitie = 1881;
            carte12.pret = 28;
            carte11.disponibila = "Da";
            carte12.autor = new Autor();
            carte12.autor.nume = "Mihai Eminescu";
            carte12.autor.anNastere = 1850;
            carte12.autor.tara = "Romania";

            carti.Add(carte1);
            carti.Add(carte2);
            carti.Add(carte3);
            carti.Add(carte4);
            carti.Add(carte5);
            carti.Add(carte6);
            carti.Add(carte7);
            carti.Add(carte8);
            carti.Add(carte9);
            carti.Add(carte10);
            carti.Add(carte11);
            carti.Add(carte12);

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
                if (carti[i].pret > cartePretMaxim.pret)
                {
                    cartePretMaxim = carti[i];
                }

            }

            return cartePretMaxim;

        }


        //functie de afisare carti

        public void afisareCartiBiblioteca()
        {
            for (int i = 0; i < carti.Count; i++) {
                Console.WriteLine(carti[i].DescriereCarte());
            }

        }

        public Carte ceaMaiVeche()
        {
            Carte anMinim = carti[0];
            for (int i = 1; i < carti.Count; i++)
            {
                if (carti[i].anAparitie < anMinim.anAparitie)
                {
                    anMinim = carti[i];
                }
            }
            return anMinim;
        }

        public double pretMediu()
        {
            int suma = 0;
            for (int i = 0; i < carti.Count; i++)
            {
                suma = suma + carti[i].pret;
            }

            return suma / carti.Count;
        }


        public int CateSubMedie()
        {
            int ct = 0;
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].pret < pretMediu())
                {
                    ct++;

                }
            }
            return ct;
        }


     
    public List<imprumut> imprumuturi = new List<imprumut>();

        // 1. Cauta o carte dupa titlu
        public Carte CautaDupaTitlu(string titlu)
        {
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].titlu == titlu)
                {
                    return carti[i];
                }
            }
            return null;
        }

        // 2. Toate cartile unui autor
        public List<Carte> CartileAutorului(string numeAutor)
        {
            List<Carte> lista = new List<Carte>();
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].autor.nume == numeAutor)
                {
                    lista.Add(carti[i]);
                }
            }
            return lista;
        }

        // 3. Imprumutul schimba starea cartii
        public bool Imprumuta(string titlu)
        {
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].titlu == titlu)
                {
                    if (carti[i].disponibila == "Da")
                    {
                        carti[i].disponibila = "Nu";
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        // 4. Cate carti are fiecare tara
        public void AfiseazaCartiPeTari()
        {
            List<string> tari = new List<string>();
            for (int i = 0; i < carti.Count; i++)
            {
                string t = carti[i].autor.tara;
                bool exista = false;
                for (int j = 0; j < tari.Count; j++)
                {
                    if (tari[j] == t) { 
                        exista = true; 
                    }
                }
                if (exista == false) { 
                    tari.Add(t);
                }
            }

            for (int i = 0; i < tari.Count; i++)
            {
                int ct = 0;
                for (int j = 0; j < carti.Count; j++)
                {
                    if (carti[j].autor.tara == tari[i]) {
                        ct++;
                    }
                }
                Console.WriteLine(tari[i] + " " + ct);
            }
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