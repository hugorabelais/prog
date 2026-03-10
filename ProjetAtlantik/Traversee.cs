using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Traversee
    {
        private int noTraversee;
        private string time;
        private string nom;

        public Traversee(int noTraversee, string time, string nom)
        {
            this.noTraversee = noTraversee;

            this.time = time;
            this.nom = nom;
        }

        public int getnoTraversee() {return noTraversee;}
        public string getTime() {return time;}
        public string getNom() {return nom;}
    }
}
