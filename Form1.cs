using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraProb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, n;
            double p,resultprobabilidad, resultcombinatoria;



            //Validacion de campos vacios
            if (string.IsNullOrEmpty(txtValorX.Text) || string.IsNullOrEmpty(txtValorN.Text) || string.IsNullOrEmpty(txtValorP.Text))
            {
                MessageBox.Show("Ingrese numeros en todas las casillas");

            }
            else
            {
                //Declaracion variable de textbox
                x = double.Parse(txtValorX.Text);
                n = double.Parse(txtValorN.Text);
                p = double.Parse(txtValorP.Text);
                //validacion si x mayor que n
                if (x > n)
                {
                    MessageBox.Show("X no puede ser mayor que N");
                }
                else if(p<0 || p>1)
                {
                    MessageBox.Show("P debe estar entre 0 y 1 (Como Decimal y con coma, no con punto).");
                }
                else
                {

                    //Llamando metodo para calcular Combinatoria.
                    resultcombinatoria = Combinatoria(x, n);
                    //Fin llamado.
                    resultprobabilidad = resultcombinatoria * Math.Pow(p,x) * Math.Pow((1-p),(n-x));
                    //5.005
                    resultadototal.Text = resultprobabilidad.ToString();
                }                                          
            }

        }

        private double Factorial(double n)
        {
            double fact = 1;
            while (n != 0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }

        private double Combinatoria(double x,double n)
        {
            double result,resta,multidenom;
            double factN, factX;
            factN = Factorial(n);
            factX = Factorial(x);
            resta = Factorial((n - x));
            multidenom = factX * resta;
            result = factN / multidenom;

            return result;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
