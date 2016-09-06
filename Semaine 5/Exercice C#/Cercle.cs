
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPCSharp
{
    class Cercle
    {
        static void Main()
        {
            Console.WriteLine("*** Perimètre et surface du Cercle V1.0,04/07/2016 ***");
            Console.WriteLine();

            //Declaration de variables. 
            string saisie; // variable recevant la saisie
            double rayon; // rayon
            double perimetre; // périmètre
            double surface; // surface 

            // Etape 1 : lecture du rayon

            Console.WriteLine("Entrez la valeur du rayon : ");
            saisie = Console.ReadLine();

            // Etape 2 : calcul et affichage du périmètre

            rayon = Convert.ToDouble(saisie);

            //Calcul du perimetre

            perimetre = 2 * Math.PI * rayon;
            surface = Math.PI * (rayon * rayon);
            Console.Write("Le cercle de rayon " + rayon);
            Console.WriteLine();
            Console.Write("Il a pour périmetre : " + perimetre);
            Console.WriteLine();
            Console.Write("Il a une surface de : " + surface);
            Console.WriteLine();

            // Permet de conserver l'affichage de la console

            Console.ReadLine();
        }
    }
}