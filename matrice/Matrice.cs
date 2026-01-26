using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrice
{
    internal class Matrice
    {
        private int[,] tabMatrice;
        private int ordre;

        public Matrice(int pOrdre, int pMin, int pMax)
        {
            Random rand = new Random();
            tabMatrice = new int[pOrdre,pOrdre];
            int coefficient;
            for (int i = 0; i < pOrdre; i++)
            {
                for (int j = 0; j < pOrdre; j++)
                {
                    coefficient = rand.Next(pMin, pMax);
                    tabMatrice[i,j] = coefficient ;
                }
            }
            ordre = pOrdre;
        }

        public Matrice(int[,] pTableau) 
        {
            tabMatrice = pTableau;
            ordre = tabMatrice.GetLength(0);
        }

        public Matrice MultiplierParScalaire (int scalaire)
        {
            for (int i = 0; i < ordre ; i++)
            {
                for (int j = 0; j <= ordre ; j++)
                {
                    tabMatrice [i,j] *= scalaire ;
                }
            }
            return this;
        }

        public override string ToString()
        {
            string resultat = string.Empty;
            for (int i = 0; i < ordre; i++)
            {
                for (int j = 0; j < ordre; j++)
                {
                    resultat += tabMatrice[i,j].ToString()+ " ";
                }
                resultat += "\n";
            }
            return resultat;
        }



    }
}
