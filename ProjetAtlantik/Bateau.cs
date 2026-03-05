using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Bateau
    {
        private int nobateau;
        private string nom;

        public Bateau(int nobateau, string nom)
        {
            this.nobateau = nobateau;
            this.nom = nom;
        }

        public int getnobateau() { return nobateau; }

        public override string ToString() { return nom; }

    }
}
