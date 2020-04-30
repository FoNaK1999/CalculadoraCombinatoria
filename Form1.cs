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
            panelCalculadoraBinominal.BackColor = Color.FromArgb(140, Color.Black);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double x, n;
            double p, resultcombinatoria;
            decimal resultprobabilidad;
            string[] aux;
            double resultado;
            double ini, fin;
            



            //Validacion de campos vacios
            if (string.IsNullOrEmpty(txtValorX.Text) || string.IsNullOrEmpty(txtValorN.Text) || string.IsNullOrEmpty(txtValorP.Text) && checkBox1.Checked == false)
            {
                MessageBox.Show("Ingrese numeros en todas las casillas");
                
            }
            else
            {
                //Declaracion variable de textbox

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

                if (checkBox1.Checked)
                {
                    //Validacion rangos inicio y fin
                    if (string.IsNullOrEmpty(txtrangoin.Text) || string.IsNullOrEmpty(txtrangofin.Text))
                    {
                        MessageBox.Show("Ingresa un rango.");
                    }
                    else if (txtrangoin.Text.Contains(",") || txtrangofin.Text.Contains(",") || txtrangoin.Text.Contains(".") || txtrangofin.Text.Contains("."))
                    {
                        MessageBox.Show("X no puede ser decimal.");
                    }
                    else
                    {
                        
                        ini = double.Parse(txtrangoin.Text);
                        fin = double.Parse(txtrangofin.Text);
                        decimal suma = 0;

                        for (double i = ini; i <= fin; i++)
                        {
                            
                            //validacion si x mayor que n
                            if (i > n)
                            {
                                MessageBox.Show("X no puede ser mayor que N");
                            }
                            else if (p < 0 || p >= 1)
                            {
                                MessageBox.Show("P debe estar entre 0 y 1 (Como Decimal y con coma, no con punto).");
                            }
                            else
                            {

                                //Llamando metodo para calcular Combinatoria.
                                resultcombinatoria = Combinatoria(i, n);
                                //Fin llamado.
                                resultprobabilidad = Convert.ToDecimal(resultcombinatoria * Math.Pow(p, i) * Math.Pow((1 - p), (n - i)));
                                suma += resultprobabilidad;
                                resultadototal.Text = resultprobabilidad.ToString("#0.00000");
                                //Mostrar resultados en ListBox.
                                listhistorial.Items.Add(" X= " + i.ToString() + " N= " + n.ToString() + " P= " + p.ToString("#0.00000") + " = " + resultprobabilidad.ToString("#0.00000"));
                         
                                //Fin ListBox.



                            }

                            


                        }
                        listhistorial.Items.Add("SUMA TOTAL :" + suma.ToString("#0.00000"));
                    }


                                              
                }
                else
                {
                    x = double.Parse(txtValorX.Text);
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
                        
                        resultadototal.Text = resultprobabilidad.ToString("#0.00000");
                        //Mostrar resultados en ListBox.
                        listhistorial.Items.Add(" X= " + x.ToString() + " N= " + n.ToString() + " P= " + p.ToString("#0.00000") + " = " + resultprobabilidad.ToString("#0.00000"));
                        //Fin ListBox.

                    
                    
                    }
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
            txtValorN.Text = "0";
            txtValorX.Text = "0";
            txtValorP.Text = "0";
            txtrangofin.Text = "0";
            txtrangoin.Text = "0";
            resultadototal.Text = "0";
            checkBox1.Checked = false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtrangoin.Visible = true;
                lbrangohasta.Visible = true;
                txtrangofin.Visible = true;
                txtValorX.Text = "0";

            }
            else
            {
                txtrangoin.Visible = false;
                lbrangohasta.Visible = false;
                txtrangofin.Visible = false;
                txtValorX.Text = "0";
                txtrangofin.Text = "0";
                txtrangoin.Text = "0";
            }
        }

        private void btnRemoveList_Click(object sender, EventArgs e)
        {
            listhistorial.Items.Clear();
        }

        private void txtValorX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(txtValorX.Text);
            }
            catch(Exception ex)
            {
                txtValorX.Text = "0";
                txtValorX.Select(0, txtValorX.Text.Length);
                
            }
        }

        private void txtValorN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(txtValorN.Text);
                if (d>170)
                {
                    MessageBox.Show("El numero maximo para N es 170.");
                    txtValorN.Text = "0";
                }
            }
            catch (Exception ex)
            {
                txtValorN.Text = "0";
                txtValorN.Select(0, txtValorN.Text.Length);


            }


        }

        private void txtrangoin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(txtrangoin.Text);
            }
            catch (Exception ex)
            {
                txtrangoin.Text = "0";
                txtrangoin.Select(0, txtrangoin.Text.Length);

            }
        }

        private void txtrangofin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int d = Convert.ToInt32(txtrangofin.Text);
            }
            catch (Exception ex)
            {
                txtrangofin.Text = "0";
                txtrangofin.Select(0, txtrangofin.Text.Length);

            }
        }

        private void txtValorP_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            char slash = Convert.ToChar("/");
            char coma = Convert.ToChar(",");
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar) || e.KeyChar==slash || e.KeyChar == coma) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
            if (txtValorP.Text.Contains(',') && (e.KeyChar == coma))
            {
                e.Handled = true;
            }
            if (txtValorP.Text.Contains('/') && (e.KeyChar == slash))
            {
                e.Handled = true;
            }



        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelCalculadoraBinominal.Visible = true;
            PanelCalcuNormal.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelCalculadoraBinominal.Visible = false;
            PanelCalcuNormal.Visible = true;
        }
    }
}
