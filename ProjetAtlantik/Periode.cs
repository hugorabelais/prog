using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    public class Periode
    {
        private short noperiode;
        private string dateDebut;
        private string dateFin;

        public Periode (short noperiode, string dateDebut, string dateFin)
        {
            this.noperiode = noperiode;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public int getnoperiode () { return noperiode; }

        public override string ToString()
        {
            return dateDebut + "au" + dateFin;
        }
    }
}
