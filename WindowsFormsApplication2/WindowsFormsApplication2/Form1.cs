using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Cuadrado(numDato1.Value);
            lblArea.Text = resultado + ""; 
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {

            CAreas a = new CAreas();
            decimal resultado = a.Triangulo(numDato3.Value, numDato2.Value);
            lblTriangulo.Text = resultado + "";
        
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {

            CAreas a = new CAreas();
            decimal resultado = a.Rectangulo(numdato4.Value, numDato5.Value);
            lblRectangulo.Text = resultado + ""; 
        }

        private void btnRombo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Rombo(numDato6.Value, numDato7.Value);
            lblRombo.Text = resultado + ""; 
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Circulo(numDato8.Value); 
            lblCirculo.Text = resultado + "";
        }
    }
}
