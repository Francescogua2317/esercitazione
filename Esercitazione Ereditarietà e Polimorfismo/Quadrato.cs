using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione_Ereditarietà_e_Polimorfismo
{
    public class Quadrato : Rettangolo , IForma1
    {
      public new double Area(double Lato, double Altezza)
        {
            double area = Lato * Lato;
            return area;
        }

         public new double Perimetro(double Lato,double Altezza)
        {
            double perimetro = Lato * 4;
            return perimetro;
        }
    }

}