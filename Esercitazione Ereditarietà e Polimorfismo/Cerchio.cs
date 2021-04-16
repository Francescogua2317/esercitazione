using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione_Ereditarietà_e_Polimorfismo
{
    public class Cerchio : IForma1
    {
       
        public double Raggio { get; set; }
        public double Area(double Raggio)

        {
            
            double area= Raggio*Raggio*Math.PI;
            return area;
        }

        public double Perimetro(double Raggio)
        {
            
            double perimetro = 2 * Raggio * Math.PI;
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