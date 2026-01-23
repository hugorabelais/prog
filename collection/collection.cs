using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    
    public class Collection
    {
        private const int MAX = 10;
        private Entree[] tableau = new Entree[MAX];
        private int positionlibre;

        private int Getindice(string clé)
        {
            for (int i = 0; i < positionlibre; i++)
            {
                if (tableau[i].GetCle() == clé){
                    return i;
                }
            }
            return -1;
        }
        public Collection()
        {
            positionlibre = 0;
        }

        public bool Ajouter (string clé,object valeur)
        {
            Entree nouventree;
            nouventree = new Entree(clé,valeur);
            bool possible = true;
            for (int i = 0; (i < positionlibre); i++)
            { 
                if (tableau[i].GetCle() == clé){
                    possible = false;
                }
            }
            if ((positionlibre < MAX) & (possible == true))
            {
                tableau[positionlibre] = nouventree;
                positionlibre++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Retourner(string cle)
        {
            int indice = Getindice(cle);
            if (indice != -1)
            {
                return tableau[indice].GetValeur();
            }
            else
            {
                return null;
            }
        }   

        public bool Suprimmer(string cle)
        {
            
            if ((Getindice(cle) == -1) || (positionlibre <= 0))
            {
                return false ;
            }
            else
            {
                for (int i = Getindice(cle); i < positionlibre; i++)
                {
                    tableau[i] = tableau[i + 1];
                    positionlibre--;
                    
                }
                return true;
            }
        }

        public bool Existe (string cle)
        {
            if (Getindice(cle) == -1){
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Vider()
        {
            positionlibre = 0;
        }

        public int NombreDElement()
        {
            return positionlibre;
        }

        public override string ToString()
        {
            string resultat ="";
            for (int i = 0; i < positionlibre; i++)
            {
                resultat = resultat + tableau[i].GetCle() + " : " + tableau[i].GetValeur() + "\n";
            }
            return resultat;
        }


    }
}
