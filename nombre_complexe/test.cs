using nbComplexe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombre_complexe
{
    static class TestCompte
    {
        static Complexe SaisirComplexe()
        {
            double x;
            double y;
            Console.WriteLine("entre partie réelle premier nombre complexe");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entre partie immaginaire premier nombre complexe");
            y = Convert.ToInt32(Console.ReadLine());
            return new Complexe(x, y);

        }
        public static void Main()
        {
            Complexe complexe1;
            Complexe complexe2;
            Complexe resultat;
            int choix;
            Complexe[] tabcomplexe = new Complexe[10];
            int poslibre = 0;
            do
            {
                do
                {
                    Console.WriteLine("1-Afficher la somme de deux nombres complexes saisis par l’utilisateur");
                    Console.WriteLine("2-Afficher la soustraction de deux nombres complexes saisis par l’utilisateur");
                    Console.WriteLine("3-Afficher le produit de deux nombres complexes saisis par l’utilisateur");
                    Console.WriteLine("4-Afficher l’inverse d’un nombre complexe saisi par l’utilisateur");
                    Console.WriteLine("5-Afficher le module d’un nombre complexe saisi par l’utilisateur");
                    Console.WriteLine("6-Ajouter un Complexe dans un tableau");
                    Console.WriteLine("7-Faire la somme des nombres complexes du tableau.");
                    Console.WriteLine("8-Quitter");
                    choix = Convert.ToInt32(Console.ReadLine());
                } while ((0 > choix) & (choix > 9) );
                switch (choix)
                {
                    case 1:
                        complexe1 = SaisirComplexe();
                        complexe2 = SaisirComplexe();
                        resultat = complexe1.Addition(complexe2);
                        Console.WriteLine(resultat.ToString());
                        break;
                    case 2:
                        complexe1 = SaisirComplexe();
                        complexe2 = SaisirComplexe();
                        resultat = complexe1.Soustraction(complexe2);
                        Console.WriteLine(resultat.ToString());
                        break;
                    case 3:
                        complexe1 = SaisirComplexe();
                        complexe2 = SaisirComplexe();
                        resultat = complexe1.Produit(complexe2);
                        Console.WriteLine(resultat.ToString());
                        break;
                    case 4:
                        complexe1 = SaisirComplexe();
                        resultat=complexe1.Inverse();
                        Console.WriteLine(resultat.ToString());
                        break;
                    case 5:
                        complexe1 = SaisirComplexe();
                        complexe1.GetModule();
                        Console.WriteLine("le module est " + complexe1.GetModule().ToString());
                        break;
                    case 6:
                        complexe1 = SaisirComplexe();
                        tabcomplexe[poslibre] = complexe1;
                        poslibre++;
                        break;
                    case 7:
                        resultat = new Complexe();
                        for (int i = 0; i < poslibre; i++)

                        {
                            resultat=resultat.Addition(tabcomplexe[i]);

                        }
                        Console.WriteLine(resultat.ToString());
                        break;
                    case 8:
                        Console.WriteLine("au revoir");
                        break;
                }

            } while (choix != 8);
        }
    }
}
