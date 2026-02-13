using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FenetreGraphique
{
    public class Publisher
    {
        private int pubid;
        private string name;

        public Publisher(int puid, string name) 
        {
            this.pubid = puid;
            this.name = name;

        }

        public int Getpuid() { return pubid;}
        public override string ToString() { return name; }
    }
}
