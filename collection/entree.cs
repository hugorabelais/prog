using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    internal class Entree
    {
        private string cle;
        private object valeur;

        public Entree(string pcle, object pvaleur)
        {
            cle = pcle;
            valeur = pvaleur;
        }

        public Entree() 
        {
            cle = "";
            valeur = "";
        }

        public string GetCle()
        {
            return cle;
        }

        public object GetValeur()
        {
            return valeur;
        }

        public override string ToString()
        {
            return "("+cle+ ","+ valeur+")";
        }


    }
}
