using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        string num1 = "";
        string num2 = "";
        string operacao = "";
        public MainPage()
        {
            InitializeComponent();
            btn_vezes.Clicked += num_vezes;
            btn_nove.Clicked += num_nove;
            btn_oito.Clicked += num_oito;
            btn_sete.Clicked += num_sete;
            btn_menos.Clicked += num_menos;
            btn_seis.Clicked += num_seis;
            btn_cinco.Clicked += num_cinco;
            btn_quatro.Clicked += num_quatro;
            btn_mais.Clicked += num_mais;
            btn_tres.Clicked += num_tres;
            btn_dois.Clicked += num_dois;
            btn_um.Clicked += num_um;
            btn_igual.Clicked += num_igual;
            btn_dividir.Clicked += num_dividir;
            btn_zero.Clicked += num_zero;
        }
        private void num_um(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '1';
            if (operacao == "")
            {
                num1 = num1 + "1";
            }
            else
            {
                num2 = num2 + "1";
            }
        }
        private void num_dois(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '2';
            if (operacao == "")
            {
                num1 = num1 + "2";
            }
            else
            {
                num2 = num2 + "2";
            }
        }
        private void num_tres(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '3';
            if (operacao == "")
            {
                num1 = num1 + "3";
            }
            else
            {
                num2 = num2 + "3";
            }
        }
        private void num_quatro(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '4';
            if (operacao == "")
            {
                num1 = num1 + "4";
            }
            else
            {
                num2 = num2 + "4";
            }
        }
        private void num_cinco(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '5';
            if (operacao == "")
            {
                num1 = num1 + "5";
            }
            else
            {
                num2 = num2 + "5";
            }
        }
        private void num_seis(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '6';
            if (operacao == "")
            {
                num1 = num1 + "6";
            }
            else
            {
                num2 = num2 + "6";
            }
        }
        private void num_sete(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '7';
            if (operacao == "")
            {
                num1 = num1 + "7";
            }
            else
            {
                num2 = num2 + "7";
            }
        }
        private void num_oito(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '8';
            if (operacao == "")
            {
                num1 = num1 + "8";
            }
            else
            {
                num2 = num2 + "8";
            }
        }
        private void num_nove(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '9';
            if (operacao == "")
            {
                num1 = num1 + "9";
            }
            else
            {
                num2 = num2 + "9";
            }
        }
        private void num_zero(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '0';
            if (operacao == "")
            {
                num1 = num1 + "0";
            }
            else
            {
                num2 = num2 + "0";
            }
        }
        private void num_mais(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '+';
            if (operacao == "")
            {
                operacao = "+";
            }
            else
            {
                num1 = this.operar(num1, num2, operacao);
                operacao = "+";
                txt_operacao.Text = num1 + operacao;
                num2 = "";
            }
        }
        private void num_menos(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '-';
            if (operacao == "")
            {
                operacao = "-";
            }
            else
            {
                num1 = this.operar(num1, num2, operacao);
                operacao = "-";
                txt_operacao.Text = num1 + operacao;
                num2 = "";
            }
        }
        private void num_vezes(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '*';
            if (operacao == "")
            {
                operacao = "*";
            }
            else
            {
                num1 = this.operar(num1, num2, operacao);
                operacao = "*";
                txt_operacao.Text = num1 + operacao;
                num2 = "";
            }
        }
        private void num_dividir(object sender, EventArgs args)
        {
            txt_operacao.Text = txt_operacao.Text + '/';
            if (operacao == "")
            {
                operacao = "/";
            }
            else
            {
                num1 = this.operar(num1, num2, operacao);
                operacao = "/";
                txt_operacao.Text = num1 + operacao;
                num2 = "";
            }
        }

        private void num_igual(object sender, EventArgs args)
        {
            string resp = this.operar(num1, num2, operacao);
            txt_operacao.Text = resp;
            num1 = "";
            num2 = "";
            operacao = "";
        }
        private void limpar(object sender, EventArgs args)
        {
            num1 = "";
            num2 = "";
            operacao = "";
            txt_operacao.Text = "";
        }

        private string operar(string num1, string num2,
        string operacao)
        {
            double resp = 0;

            switch (operacao)
            {
                case "+":
                    resp = Convert.ToDouble(num1) +
                    Convert.ToDouble(num2);
                    break;
                case "-":
                    resp = Convert.ToDouble(num1) -
                    Convert.ToDouble(num2);
                    break;
                case "*":
                    resp = Convert.ToDouble(num1) *
                    Convert.ToDouble(num2);
                    break;
                case "/":
                    resp = Convert.ToDouble(num1) /
                    Convert.ToDouble(num2);
                    break;
            }
            return resp.ToString();
        }
    }
}