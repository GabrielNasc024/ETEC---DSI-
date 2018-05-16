using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculadoraD
{
    public partial class frmCalcu : Form
    {
        //criando uam classe publica do nome "frmCalcu"
        public frmCalcu()
        {
        //iniciar a janela 
            InitializeComponent();
        }
        //um metodo construtor cria um objeto e atribui propriedades de DataTable
        DataTable table = new DataTable();

        //declarando um metodo de click como vazio.
        private void botclick(object bot, EventArgs e)
        {
            //tenta executar o try.
            try
            {
                txbRESULT.Text = table.Compute(txbRESULT.Text, "") + "";
            }
            //caso alguma exceção aconteça, o catch é executado.
            catch
            {
                txbRESULT.Text = "Error";
            }
        }
        /*double resul = 0;
        double acumular = 0;
        double acumular1 = 0;
        string operacao = "";
        public frmCalcu()
        {
            InitializeComponent();
        }

        private void btnMENOS_Click(object sender, EventArgs e)
        {
            acumular -= double.Parse(lblRESULT.Text);
            lblRESULT.Text = "-";
            operacao = "-";
            acumular = 0;

        }
        private void btnMULT_Click(object sender, EventArgs e)
        {

            acumular *= double.Parse(lblRESULT.Text);
            lblRESULT.Text = "*";
            operacao = "*";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            acumular += double.Parse(lblRESULT.Text);
            lblRESULT.Text = "+";
            operacao = "+";
           

        }*/
        //executa o metodo escsaid, usando o objeto usado para clicar como argumento.
        private void cliquedobot(object bot, EventArgs e)
        {
            //pega o objeto, assume q é um botão, e pega o texto do objeto.
            escsaid(((Button)bot).Text);
        }

        //esse metodo vai escrever na caixa de texto
        private void escsaid(string args)
        {
            //verifica se o texto é 0, caso sim, ele substitui o texto atual com argumento String, do texto bottão 
            if (txbRESULT.Text == "0")
            {
                txbRESULT.Text = args + "";
            }
            //caso n, implementa o botão
            else
            {
                txbRESULT.Text += args;
            }
        }
    }
}
      /*  private void btn1_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            lblRESULT.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {

            lblRESULT.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            lblRESULT.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblRESULT.Text += "0";
        }
        
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                lblRESULT.Text = (acumular + double.Parse(lblRESULT.Text)).ToString();
    
            }
            else if (operacao == "-")
            {
              
                lblRESULT.Text = (acumular - double.Parse(lblRESULT.Text)).ToString();

            }
            else if (operacao == "*")
            {

                lblRESULT.Text = (acumular * double.Parse(lblRESULT.Text)).ToString();
      
               
            }

            else if (operacao == "/")
            {
                if (double.Parse(lblRESULT.Text) != 0)
                {
                    acumular /= double.Parse(lblRESULT.Text);
                    lblRESULT.Text = acumular.ToString();
                }
                else
                {
                    lblRESULT.Text = "Dividindo por zero";
                }
            }
        }
    }
}*/
