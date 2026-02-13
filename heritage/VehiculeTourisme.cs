using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace heritage
{
    internal class VehiculeTourisme : Vehicule
    {
        private int nombreDePortes;
        private int nombreDePassager;
        private bool climatisation;

        public VehiculeTourisme(string code, string libelle, double prixJour, int nombreDePortes, int nombreDePassager, bool climatisation)
            :base(code, libelle,prixJour)
        {
            this.nombreDePortes = nombreDePortes;
            this.nombreDePassager = nombreDePassager;
            this.climatisation = climatisation;
        }

        public int GetNombreDePorte() { return nombreDePortes; }

        public int GetNombreDePassager() { return nombreDePassager; }

        public bool GetClimatisation() {return climatisation;}

        public override string ToString()
        {
            return base.ToString() + "\n Nombre de portes : " + nombreDePortes + "\n Nombre de passagers : "+ nombreDePassager+ "\n Climatisation : " + "\n Cout location : "+ this.CoutLocation(5);
        }



    }
}
