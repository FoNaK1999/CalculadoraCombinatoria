﻿using System;
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
            int x, n, resultcombinatoria,resta,multidenom;
            int factN = 0, factX = 0;

            //Validacion de campos vacios
            if (string.IsNullOrEmpty(txtValorX.Text)|| string.IsNullOrEmpty(txtValorN.Text))
            {
                MessageBox.Show("Ingrese numeros en las casillas");

            }
            else
            {
                //Declaracion variable de textbox
                x = int.Parse(txtValorX.Text);
                n = int.Parse(txtValorN.Text);
                //validacion si x mayor que n
                if (x > n)
                {
                    MessageBox.Show("X no puede ser mayor que N");
                }
                else
                {

                    //Combinatoria
                    factN = Factorial(n);
                    factX = Factorial(x);
                    resta = Factorial((n - x));
                    multidenom = factX * resta;
                    resultcombinatoria = factN / multidenom;
                    //Fin Combinatoria
                    //Mostrar Resultado de prueba
                    resultadototal.Text = resultcombinatoria.ToString();
                }                                          
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
