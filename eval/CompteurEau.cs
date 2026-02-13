using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eval
{
    public class CompteurEau
    {
        private string _numeroSerie;
        private double _indexM3;
        private const double PRIX8M3 = 4;

        public CompteurEau(string numeroSerie)
        {
            _numeroSerie = numeroSerie;
        }

        public string GetNumeroSerie()
        {

        return _numeroSerie; 
        }
    

    }

}
