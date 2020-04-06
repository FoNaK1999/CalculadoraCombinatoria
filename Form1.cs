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
            int x, n, resultcombinatoria, factN=0,factX=0;

            x = int.Parse(txtValorX.Text);
            n = int.Parse(txtValorN.Text);

            if (x!=null || n != null)
            {

                factN = Factorial(n);
                factX = Factorial(x);

                resultadototal.Text = factX.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese numeros");
            }
        }

        private int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
