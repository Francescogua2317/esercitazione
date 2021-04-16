using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione_Ereditarietà_e_Polimorfismo
{
    public class Rettangolo : IForma1
    {
        public double Lato;
        public double Altezza;

        public double Area(double Lato, double Altezza)
        {
            double area = Lato * Altezza;
            return area;
        }

         public double Perimetro(double Lato,double Altezza)
        {
            double perimetro = (Lato + Altezza) * 2;
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