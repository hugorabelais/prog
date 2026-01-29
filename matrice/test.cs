using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrice
{
    static class TestCompte
    {
        public static void Main()
        {
            Matrice matrice1;
            Matrice matrice2;
            matrice1 = new Matrice (3, 0,9);
            matrice2 = new Matrice(3, 0, 9);
            Console.WriteLine("matrice1 \n" +matrice1);
            Console.WriteLine("matrice2 \n" + matrice2);
            Console.WriteLine("////////////////////////");
            Console.WriteLine("matrice 1 par 10 \n" + matrice1.MultiplierParScalaire(10));
            Console.WriteLine("matrice 1 + matrice 2 \n" + matrice1.Addition(matrice2));
            Console.WriteLine("matrice 1 - matrice 2 \n" + matrice1.Soustraction(matrice2));
            Console.WriteLine("matrice 1 * matrice 2 \n" + matrice1.Multiplication(matrice2));
            Console.WriteLine("////////////////////////");
            Console.WriteLine("matrice 1\n" + matrice1.ToString());
            matrice1.Transposer();
            Console.WriteLine("transposé de 1\n" + matrice1.ToString());
        }
    }
}