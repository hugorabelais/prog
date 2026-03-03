using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Liaison
    {
        private int noLiaison;
        private int noPort_Depart;
        private int noSecteur;
        private int noPort_Arrivee;
        private double distance;
        private string pd;
        private string pa;

        public Liaison(int noLiaison, int noPort_Depart, int noSecteur, int noPort_Arrivee, double distance, string pd, string pa) 
        {
            this.noLiaison = noLiaison;
            this.noPort_Depart = noPort_Depart;
            this.noSecteur = noSecteur;
            this.noPort_Arrivee = noPort_Arrivee;
            this.distance = distance;
            this.pd = pd;
            this.pa = pa;
        }

        public int getNoLiaison() 
        { 
            return noLiaison;
        }

        public int getNoPort_Depart() 
        { 
            return noPort_Depart;
        }

        public int getNoSecteur()
        {
            return noSecteur;
        }

        public double getDistance()
        {
            return distance;
        }

        public int getNoPort_Arrivee()
        {
            return noPort_Arrivee;
        }

        public override string ToString()
        {
            return pd + "-" + pa;
        }



    }
}
