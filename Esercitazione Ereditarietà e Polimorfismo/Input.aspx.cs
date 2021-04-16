using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esercitazione_Ereditarietà_e_Polimorfismo
{
    public partial class Input : System.Web.UI.Page
    {
       
       
      
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void BtnRettangolo_Click(object sender, EventArgs e)
        {
            Rettangolo r = new Rettangolo();
            double Lato = Convert.ToDouble(LatoInserimento.Text);
            double Altezza = Convert.ToDouble(AltezzaInserimento.Text);
            double area =r.Area(Lato,Altezza);
            double perimetro = r.Perimetro(Lato, Altezza);
            lbl_Rettangolo.Text = "L'area e il perimetro del Rettangolo sono " + area + "e" + perimetro;
        }

        protected void BtnCerchio_Click(object sender, EventArgs e)
        {
            Cerchio c = new Cerchio();
            double raggio = Convert.ToDouble(RaggioInserimento.Text);
            double area = c.Area( raggio );
            double perimetro = c.Perimetro( raggio );
            lbl_Cerchio.Text = "L'area e il perimetro del Cerchio sono " + area + "e" + perimetro;
        }

        protected void BtnTriangolo_Click(object sender, EventArgs e)
        {
            Triangolo t = new Triangolo();
            double Lato = Convert.ToDouble(LatoInserimento.Text);
            double Altezza = Convert.ToDouble(AltezzaInserimento.Text);
            double area = t.Area(Lato, Altezza);
            double perimetro = t.Perimetro(Lato, Altezza);
            lbl_Triangolo.Text = "L'area e il perimetro del Triangolo sono " + area + "e" + perimetro;
        }

        protected void BtnQuadrato_Click(object sender, EventArgs e)
        {

            Quadrato q = new Quadrato();
            double Lato = Convert.ToDouble(LatoInserimento.Text);
            double Altezza = Convert.ToDouble(AltezzaInserimento.Text);
            double area = q.Area(Lato, Altezza);
            double perimetro = q.Perimetro(Lato, Altezza);
            lbl_Quadrato.Text = "L'area e il perimetro del Quadrato sono " + area + "e" + perimetro;
        }
    }
}