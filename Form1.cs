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
            panel2.BackColor = Color.FromArgb(140, Color.Black);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, n;
            double p, resultcombinatoria;
            decimal resultprobabilidad;
            string[] aux;
            double resultado;

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

                if (txtValorP.Text.Contains("/"))
                {
                    aux = txtValorP.Text.Split(new char[] { '/' }, 2);
                    resultado = double.Parse(aux[0]) / double.Parse(aux[1]);
                    p = resultado;
                }
                else
                {
                    resultado = double.Parse(txtValorP.Text);
                    p = resultado;
                }
                
                //validacion si x mayor que n
                if (x > n)
                {
                    MessageBox.Show("X no puede ser mayor que N");
                }
                else if(p<0 || p>=1)
                {
                    MessageBox.Show("P debe estar entre 0 y 1 (Como Decimal y con coma, no con punto).");
                }
                else
                {

                    //Llamando metodo para calcular Combinatoria.
                    resultcombinatoria = Combinatoria(x, n);
                    //Fin llamado.
                    resultprobabilidad = Convert.ToDecimal(resultcombinatoria * Math.Pow(p,x) * Math.Pow((1-p),(n-x)));
                    lbresultcomb.Text = resultcombinatoria.ToString();
                    resultadototal.Text = resultprobabilidad.ToString("#0.00000");
                    //Mostrar resultados en ListBox.
                    listhistorial.Items.Add(" X= " + x.ToString() + " N= " + n.ToString() + " P= " + p.ToString() + " = " + resultprobabilidad.ToString("#0.00000"));
                    //Fin ListBox.

                    
                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            txtValorN.Text = " ";
            txtValorX.Text = " ";
            txtValorP.Text = " ";
        }

        private void listhistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           

        }

        private void fondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBorrarS_Click(object sender, EventArgs e)
        {
            listhistorial.Items.Remove(listhistorial.SelectedItem);
        }

        private void lbresultcomb_Click(object sender, EventArgs e)
        {

        }
    }
}
