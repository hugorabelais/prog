using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    static class Test
    {
        
        public static void Main() {
            string? CleUser;
            object ValeurUser;
            Collection testcollection;
            bool resultat;
            testcollection = new Collection();
            int choix;
            object valeurResultat;
            do
            {
                do
                {
                    Console.WriteLine("1-ajouter element");
                    Console.WriteLine("2-retourner la valeur pour une cle donner");
                    Console.WriteLine("3-supprimer une case pour une clé donner");
                    Console.WriteLine("4-est ce que la cle est presente dans le tableau");
                    Console.WriteLine("5-vider la collection");
                    Console.WriteLine("6-nombre d'element dans la collection");
                    Console.WriteLine("7-afficher la collection");
                    Console.WriteLine("8-sortir");
                    choix = int.Parse(Console.ReadLine());
                } while ((choix < 1) & (choix < 9));
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("cle a entree");
                        CleUser = Console.ReadLine();
                        Console.WriteLine("valeur a entree");
                        ValeurUser = Console.ReadLine();
                        resultat = testcollection.Ajouter(CleUser, ValeurUser);
                        if (resultat)
                        {
                            Console.WriteLine("ajout reussi");
                        }
                        else
                        {
                            Console.WriteLine("ajout impossible");

                        }
                        break;
                    case 2:
                        Console.WriteLine("cle a entree");
                        CleUser = Console.ReadLine();
                        valeurResultat = testcollection.Retourner(CleUser);
                        Console.WriteLine(valeurResultat);
                        break;
                    case 3:
                        Console.WriteLine("cle a entree");
                        CleUser = Console.ReadLine();
                        resultat = testcollection.Suprimmer(CleUser);
                        if (resultat)
                        {
                            Console.WriteLine("supression reussi");
                        }
                        else
                        {
                            Console.WriteLine("supression impossible");
                        }
                        break;
                    case 4:
                        Console.WriteLine("cle a entree");
                        CleUser = Console.ReadLine();
                        resultat = testcollection.Existe(CleUser);
                        if (resultat)
                        {
                            Console.WriteLine("la valeur existe");
                        }
                        else
                        {
                            Console.WriteLine("la valeur n'existe pas");
                        }
                        break;
                    case 5:
                        testcollection.Vider();
                        break;
                    case 6:
                        Console.WriteLine("le nombre d'element est " + testcollection.NombreDElement());
                        break;
                    case 7:
                        Console.WriteLine(testcollection.ToString());
                        break;
                    case 8:
                        Console.WriteLine("au revoir");
                        break;
                }
            } while (choix != 8);

        
        
        }
    }
}
