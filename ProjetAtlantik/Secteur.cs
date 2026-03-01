using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Secteur
    {
        private int idSecteur;
        private string name;

        public Secteur(int idSecteur, string name)
        {
            this.name = name;
            this.idSecteur = idSecteur;
        }

        public int getidSecteur()
        {
            return idSecteur;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
