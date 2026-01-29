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
            Console.WriteLine("1. Ajouter un produit au catalogue");
            Console.WriteLine("2. Augmenter le prix HT d'un produit");
            Console.WriteLine("3. Baisser le prix HT d'un produit\r\n\r\n");
            Console.WriteLine("4. Modifier le taux de TVA d'un produit");
            Console.WriteLine("5. Augmenter tous les produits du catalogue");
            Console.WriteLine("6. Supprimer un produit du catalogue");
            Console.WriteLine("7. Afficher toutes les informations sur tous les produits (inc. Prix TTC)");
            Console.WriteLine("8. Afficher toutes les informations sur un produit (inc. Prix TTC)");
            Console.WriteLine("9. Vider le catalogue");
            Console.WriteLine("10. Quitter");
            choix = int.Parse(Console.ReadLine());
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
                    Console.WriteLine("pourcentage d'augmentation");
                    pourcentage=double.Parse(Console.ReadLine());
                    Console.WriteLine("reference produit a augmenter");
                    reference=Console.ReadLine();
                    foreach (string p in LesProduit.Keys)
                    {
                        if (p == reference)
                        {
                            LesProduit[p]
                        }
                    }



            }

        }
    }
}
