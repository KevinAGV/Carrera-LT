using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liebreT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bcorrer_Click(object sender, EventArgs e)
        {
            liebre l1 = new liebre(1);
            tortuga t1 = new tortuga(3);


            do
            {
                l1.correr();
                t1.correr();
                datos.Text += l1.ToString() + " y " + t1.ToString()+Environment.NewLine;


            } while (l1.posicion < 100 && t1.posicion < 100);

            if(l1.posicion>=100 && t1.posicion>=100)
            {
                resultado.Text = "EMPATE";
            }
            else if(l1.posicion>t1.posicion)
            {
                resultado.Text = "LIEBRE GANA";
            }
            else
            {
                resultado.Text = "TORTUGA GANA";
            }
        }
    }
}
