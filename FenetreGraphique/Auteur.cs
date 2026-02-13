using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FenetreGraphique
{
    public class Auteur
    {
        private int au_id;
        private string name;

        public Auteur(int au_id, string name)
        {
            this.au_id = au_id;
            this.name = name;
        }

        public int get_au_id() { return au_id; }

        public override string ToString() { return name; }
    }
}
