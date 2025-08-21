using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // VARIAVEIS GLOBAIS:
        bool operadorClicado =true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            //implementar depois..
        }
        private void numero_click(object sender, EventArgs e)
        {
            //obter o botao que esta chamando esse evento:
            Button botaoClicado =(Button)sender;

            //adicionar o text do botao clicado no textbox;
            txbTela.Text += botaoClicado.Text;
            //abaixar bandeirinha
            operadorClicado = false;
        }
        private void operadro_Click(object sender, EventArgs e)
        {
            // verificar se o operador ainda nao foi clicado:
            if(operadorClicado==false)
            {
                //obter o botao que esta chamando esse evento:
                Button botaoClicado = (Button)sender;

                //adicionar o text do botao clicado no textbox;
                txbTela.Text += botaoClicado.Text;

                //mudar o operador clicado para true
                operadorClicado = true;

            }

            
        }
    }

}
