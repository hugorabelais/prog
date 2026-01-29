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
            int[,] tabmatriceRetourne = new int[ordre, ordre];
            for (int i = 0; i < ordre ; i++)
            {
                for (int j = 0; j < ordre ; j++)
                {
                    tabmatriceRetourne [i,j] = tabMatrice[i, j] * scalaire ;
                }
            }
            return new Matrice(tabmatriceRetourne);
        }

        public Matrice Addition(Matrice m)
        {
            int[,] tabmatriceRetourne = new int[ordre,ordre];
            
            for (int i = 0;i < ordre ; i++)
            {
                for(int j = 0;j < ordre ; j++)
                {
                    tabmatriceRetourne[i,j] = tabMatrice[i, j] + m.tabMatrice[i,j];
                }
            }
            return new Matrice(tabmatriceRetourne);
        }

        public Matrice Soustraction(Matrice m)
        {
            int[,] tabmatriceRetourne = new int[ordre, ordre];

            for (int i = 0; i < ordre; i++)
            {
                for (int j = 0; j < ordre; j++)
                {
                    tabmatriceRetourne[i, j] = tabMatrice[i, j] - m.tabMatrice[i, j];
                }
            }
            return new Matrice(tabmatriceRetourne);
        }

        public Matrice Multiplication (Matrice m)
        {
            int somme = 0;
            int[,] tabmatriceRetourne = new int[ordre, ordre];
            for (int i = 0;i < ordre; i++)
            {

                for (int j = 0;j < ordre; j++)
                {
                    for (int k = 0; k < ordre; k++)
                    {
                        somme += tabMatrice[i, k] * m.tabMatrice[k, j];
                    }
                    tabmatriceRetourne[i, j] = somme;
                    somme = 0;
                }
            }
            return new Matrice (tabmatriceRetourne);
        }

        public void Transposer()
        {
            int var = 0;
            int a;
            int b;
            for (int i = 0; i < ordre; i++) 
            { 
                for(int j = var; j < ordre; j++)
                {
                    a = tabMatrice[i,j];
                    b= tabMatrice[j,i];
                    echanger(ref a, ref b);
                    tabMatrice[i,j] = a; 
                    tabMatrice[j,i] = b;
                }
                var++;
            }

        }

        private void echanger(ref int a,ref int b)
        {
            int var;
            var = a;
            a = b;
            b = var;
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
