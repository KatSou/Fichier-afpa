using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeux du Pendu.");            
            Console.WriteLine("Le premier joueur doit entrer un mot");            
            Console.WriteLine("Le deuxième joueur doit trouver ce mot, il y a 7 fautes possibles.\n \n \n \n \n ");            
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("                                                         5");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                         4");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                         3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                         2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                         1");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("                                                         GOOOOOOOO");
            System.Threading.Thread.Sleep(2000);
            
            Console.Clear();
            string res = "1";
            while (res == "1")
            {
                string mot = GetString("Entrez le mot a chercher : (soit en majuscule, soit en minuscule)"), saisie = "";
                Console.Clear();
                string[] Mot = new string[mot.Length];
                string[] Saisie = new string[mot.Length];
                int i = 0, a = 0, b = 0, erreur = 0;                
                while (i < mot.Length)
                {
                    Mot[i] = mot.Substring(i, 1);
                    Saisie[i] = "_";
                    i++;
                }
                i = 0;
                while (b != Mot.Length & erreur < 7)
                {
                    saisie = GetString("Entrez une lettre");
                    while (i < mot.Length)
                    {
                        if (saisie == Mot[i] & Saisie[i] != Mot[i])
                        {
                            Saisie[i] = Mot[i];
                            a++;
                        }
                        i++;
                    }
                                   
                    a = 0;
                    b = CompTab(Saisie, Mot);
                    i = 0;
                    AffTab(Saisie);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0} / 7 erreurs", erreur);
                    Console.ResetColor();
                }
                Console.Clear();
                if (erreur == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tu as perdu");
                    Console.ResetColor();
                }
                if (b == mot.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("BRAVOOOOOO");
                    Console.ResetColor();
                }
                Console.WriteLine("Pour recommencer appuie sur 1\nSinon appuie 2 fois sur entrer  ");
                res = Console.ReadLine();
            }           

       }

        static void AffTab(string[] Tab)
        {
            int i = 0;
            while (i < Tab.Length)
            {
                Console.Write(Tab[i] + " ");

                i++;
            }
            Console.WriteLine();
        }
        static int CompTab(string[] Saisie, string[] Mot)
        {
            int i = 0;
            int c = 0;
            while (i < Mot.Length)
            {
                if (Saisie[i] == Mot[i])
                {
                    c = c + 1;
                }
                i++;
            }
            return c;
        }
        static int GetInteger(string message)
        {
            string saisie;
            int nombre;
            Console.WriteLine(message);
            saisie = Console.ReadLine();
            nombre = Convert.ToInt32(saisie);
            return nombre;
        }
        static string GetString(string message)
        {
            string saisie;
            Console.WriteLine(message);
            saisie = Console.ReadLine();
            return saisie;
        }
    }
}
