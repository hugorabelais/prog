namespace nbComplexe

{

    public class Complexe
    {
        private double x;
        private double y;

        public Complexe(double nouvX, double nouvY)
        // ! ! CONSTRUCTEUR ! !
        {
            x = nouvX;
            y = nouvY;
        }

        public Complexe() // ! ! CONSTRUCTEUR ! !
        {
            x = 0;
            y = 0;
        }


        public double GetpartieReelle()
        {
            return x;
        }
        public double GetpartieImaginaire()
        {
            return y;
        }


        public Complexe Addition(Complexe nombre)
        {
            return new Complexe(x + nombre.x , y + nombre.y);
        }


        public Complexe Soustraction(Complexe nombre)
        {
            return new Complexe(x - nombre.x, y - nombre.y);
        }


        public Complexe Produit(Complexe nombre)
        {
            return new Complexe(x * nombre.x - y * nombre.y, x * nombre.y + nombre.x * y);

        }

        public Complexe Inverse()
        {
            return new Complexe(x / (Math.Pow(x, 2) + Math.Pow(y, 2)), -y / (Math.Pow(x, 2) + Math.Pow(y, 2)));
        }

        public double GetModule()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public Complexe ComparerModule(Complexe nombre)
        {
            if (GetModule() > nombre.GetModule()) 
            {
                return this;
            }
            return nombre;
        }

        public override string ToString()
        {
            return "Partie Reelle : " + x + " "+
                "Partie Immaginaire : " + y;
        }
    }
}