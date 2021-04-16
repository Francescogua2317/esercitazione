using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione_Ereditarietà_e_Polimorfismo
{
    public class Triangolo : IForma1
    {
        

        public double Area(double Lato, double Altezza)
        {
            double area = Lato * Altezza / 2;
            return area;
        }

       public double Perimetro(double Lato, double Altezza)
        {
            double perimetro = Lato * 3;
            return perimetro;
        }

        double IForma1.Area()
        {
            throw new NotImplementedException();
        }

        double IForma1.Perimetro()
        {
            throw new NotImplementedException();
        }
    }
}