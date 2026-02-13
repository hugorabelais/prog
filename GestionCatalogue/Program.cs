using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCatalogue
{
    internal class Program
    {
        public static void Main()
        {
            Hashtable LesProduit = new Hashtable();
            int choix;
            string designation;
            double prixHT;
            double TVA;
            string reference;
            double pourcentage;
            string var;
            do
            {
                do
                {
                    Console.WriteLine("1. Ajouter un produit au catalogue");
                    Console.WriteLine("2. Augmenter le prix HT d'un produit");
                    Console.WriteLine("3. Baisser le prix HT d'un produit");
                    Console.WriteLine("4. Modifier le taux de TVA d'un produit");
                    Console.WriteLine("5. Augmenter tous les produits du catalogue");
                    Console.WriteLine("6. Supprimer un produit du catalogue");
                    Console.WriteLine("7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)");
                    Console.WriteLine("8. Afficher toutes les informations sur un produit (inc. Prix TTC)");
                    Console.WriteLine("9. Vider le catalogue");
                    Console.WriteLine("10. Quitter");
                    choix = int.Parse(Console.ReadLine());
                } while (choix > 11 & choix < 0);
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Saisir la désignation du produit.");
                        designation = Console.ReadLine();
                        Console.WriteLine("Saisir le prix HT du produit.");
                        prixHT = double.Parse(Console.ReadLine());
                        Console.WriteLine("Saisir le taux de TVA du produit.");
                        TVA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Saisir la référence du produit.");
                        reference = Console.ReadLine();
                        Produit produit1 = new Produit(designation, prixHT, TVA);
                        LesProduit.Add(reference, produit1);
                        break;
                    case 2:
                        Console.WriteLine("reference produit a augmenter");
                        reference = Console.ReadLine();
                        Console.WriteLine("pourcentage d'augmentation");
                        pourcentage = double.Parse(Console.ReadLine());
                        foreach (DictionaryEntry p in LesProduit)
                        {
                            if ((string)p.Key == reference)
                            {
                                ((Produit)p.Value).AugmenterPrix(pourcentage);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("reference produit a baisser");
                        reference = Console.ReadLine();
                        Console.WriteLine("pourcentage de diminution");
                        pourcentage = double.Parse(Console.ReadLine());
                        foreach (DictionaryEntry p in LesProduit)
                        {
                            if ((string)p.Key == reference)
                            {
                                ((Produit)p.Value).BaisserPrix(pourcentage);
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("reference produit modifié TVA");
                        reference = Console.ReadLine();
                        Console.WriteLine("nouvelle TVA");
                        TVA = double.Parse(Console.ReadLine());
                        foreach (DictionaryEntry p in LesProduit)
                        {
                            if ((string)p.Key == reference)
                            {
                                ((Produit)p.Value).SetTauxTVA(TVA);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("pourcentage d'augmentation");
                        pourcentage = double.Parse(Console.ReadLine());
                        foreach (DictionaryEntry p in LesProduit)
                        {
                                ((Produit)p.Value).AugmenterPrix(pourcentage);
                        }
                        break;

                    case 6:
                        Console.WriteLine("reference produit a supprimer");
                        reference = Console.ReadLine();
                        foreach (DictionaryEntry p in LesProduit)
                        {
                            if ((string)p.Key == reference)
                            {
                                LesProduit.Remove(reference);
                                break;
                            }
                        }
                        
                        break;

                    case 7:
                        foreach (string p in LesProduit.Keys)
                        {
                            Console.WriteLine("reference du produit : " + p + "\n"+ LesProduit[p].ToString());
                        }
                        break;
                    case 8:
                        Console.WriteLine("reference produit a afficher");
                        reference = Console.ReadLine();
                        Console.WriteLine("reference du produit : " + reference + "\n" + LesProduit[reference].ToString());
                        break;

                    case 9:
                        LesProduit.Clear();
                        break;
                    case 10:
                        Console.WriteLine("au revoir");
                        Console.ReadLine();
                        break;
                }

            } while (choix != 10) ;
        }
    }
}
