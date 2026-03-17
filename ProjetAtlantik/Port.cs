using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAtlantik
{
    internal class Port
    {
        private int idPort;
        private string name;

        public Port(int idport , string name)
        {
            this.name = name;
            this.idPort = idport;
        }

        public int getidPort()
        {
            return idPort;
        }

        public override string ToString()
        {
            return idPort.ToString() +"-"+ name;
        }
    }
}
