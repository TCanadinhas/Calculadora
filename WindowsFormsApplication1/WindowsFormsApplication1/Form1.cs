using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool digit1 = true;
        bool digit2 = false;
        public bool concatenar = true;
        double n1, n2;
        int conta;

        public Form1()
        {
            InitializeComponent();
        }
        private void Soma(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 0;
            }
        }

        private void Subtrai(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 1;
                
            }
        }

        private void multiplica(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 2;
            }
        }

        private void Dividi(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 3;
                
            }
        }

        private void resto(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 4;
               
            }
        }

       
        private void raiz(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "------------";
                digit1 = false;
                digit2 = false;
                conta = 5;
            }
        }

        private void porcentagem(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 6;

            }
        }

        private void seno(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "------------";
                digit1 = false;
                digit2 = false;
                conta = 7;

            }
        }

        private void cosseno(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "------------";
                digit1 = false;
                digit2 = false;
                conta = 8;

            }
        }


        private void tangente(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "------------";
                digit1 = false;
                digit2 = false;
                conta = 9;

            }
        }


        private void potencia(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length > 0)
            {
                txtNumber2.Text = "";
                digit1 = false;
                digit2 = true;
                conta = 10;

            }
        }

        private void digitar(object sender, EventArgs e)
        {
            Button foiClicado = sender as Button;

            if (digit1)
            {
                if (concatenar)
                {
                    txtNumber.Text += foiClicado.Text;
                }
            }

            if (digit2)
            {
                if (concatenar)
                {
                    txtNumber2.Text += foiClicado.Text;
                }
            }

        }

        private void Resultado(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtNumber.Text);
            if (txtNumber2.Text != "------------")
            {
                n2 = Convert.ToDouble(txtNumber2.Text);
            }
            switch (conta)
            {
                case 0:
                    txtResultado2.Text += n1 + n2;
                    break;

                case 1:
                    txtResultado2.Text += n1 - n2;
                    break;

                case 2:
                    txtResultado2.Text += n1 * n2;
                    break;

                case 3:
                    txtResultado2.Text += n1 / n2;
                    break;

                case 4:
                    txtResultado2.Text += n1 % n2;
                    break;

                case 5:
                    txtResultado2.Text += Math.Sqrt(n1);
                    break;

                case 6:
                    txtResultado2.Text +=(n1 * n2)/100;
                    break;

                case 7:
                    txtResultado2.Text += Math.Sin(n1);
                    break;

                case 8:
                    txtResultado2.Text += Math.Cos(n1);
                    break;

                case 9:
                    txtResultado2.Text += Math.Tan(n1);
                    break;

                case 10:
                    txtResultado2.Text += Math.Pow(n1,n2);
                    break;
            }
            
        }

        private void Apagar(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtNumber2.Text = "";
            txtResultado2.Text = "";
            digit1 = true;
            digit2 = false;
        }

    }
}
