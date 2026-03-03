
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Type
    {
        private string lettre;
        private short notype;
        private string libelle;

        public Type(string lettre, short notype, string libelle)
        {
            this.lettre = lettre;
            this.notype = notype;
            this.libelle = libelle;
        }

        public string getlettre()
        {
            return lettre;
        }

        public short getnotype()
        {
            return notype;
        }


        public override string ToString()
        {
            return lettre.ToString()+notype.ToString() + " - " + libelle+ " :";
        }
    }
}
