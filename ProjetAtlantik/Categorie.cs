using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Categorie
    {
        private string lettrecategorie;
        private string libelle;

        public Categorie(string lettrecategorie,string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.libelle = libelle;
        }

        public string getlettrecategorie()
        {
            return lettrecategorie;
        }

        public override string ToString()
        {
            return lettrecategorie + " (" + libelle+") :";
        }
    }
}
