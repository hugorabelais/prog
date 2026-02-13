using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    internal class Program
    {
        public static void Main()
        {
            Vehicule nouvvehicule;
            nouvvehicule = new Vehicule("VU01", "DS", 50);
            VehiculeTourisme tourisme;
            tourisme = new VehiculeTourisme("VU22", "simca aronde", 50, 5, 4, false);

            Console.WriteLine("///TEST VEHICULE///");
            Console.WriteLine(nouvvehicule.ToString());
            Console.WriteLine("///TEST VEHICULE UTILITAIRE///");
            Console.WriteLine(
        }
    }
}
