using System;

namespace Calculadora
{
    public partial class Calculadora : System.Windows.Forms.Form
    {

        public Calculadora()
        {
            InitializeComponent();

            // Iniciando campos

            lbl_operacao.Text = "";
            lbl_memoria.Text = "";
            txt_visor.Text = "";

            if (lbl_memoria.Text == "")
            {
                btn_mc.Enabled = false;
                btn_mr.Enabled = false;
            }
        }

        // Iniciando variáveis

        public string numero;
        public bool visorContemNumero, memoriaContemNumero;
        public double memoria;
        
        // Implementando botões numéricos [ 0 - 9 ]

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_0.Text;
            }
            else
            {
                txt_visor.Text = btn_0.Text;
                visorContemNumero = true;
            }

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_1.Text;
            }
            else
            {
                txt_visor.Text = btn_1.Text;
                visorContemNumero = true;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_2.Text;
            }
            else
            {
                txt_visor.Text = btn_2.Text;
                visorContemNumero = true;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_3.Text;
            }
            else
            {
                txt_visor.Text = btn_3.Text;
                visorContemNumero = true;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_4.Text;
            }
            else
            {
                txt_visor.Text = btn_4.Text;
                visorContemNumero = true;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_5.Text;
            }
            else
            {
                txt_visor.Text = btn_5.Text;
                visorContemNumero = true;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_6.Text;
            }
            else
            {
                txt_visor.Text = btn_6.Text;
                visorContemNumero = true;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_7.Text;
            }
            else
            {
                txt_visor.Text = btn_7.Text;
                visorContemNumero = true;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_8.Text;
            }
            else
            {
                txt_visor.Text = btn_8.Text;
                visorContemNumero = true;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_9.Text;
            }
            else
            {
                txt_visor.Text = btn_9.Text;
                visorContemNumero = true;
            }
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (visorContemNumero)
            {
                txt_visor.Text += btn_virgula.Text;
            }
            else
            {
                txt_visor.Text = btn_virgula.Text;
                visorContemNumero = true;
            }
        }

        // Implementando botões de reset [ CE / C ]

        private void btn_ce_Click(object sender, EventArgs e)
        {
            txt_visor.Text = "";
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            numero = "";
            lbl_operacao.Text = "";
            txt_visor.Text = "";
        }

        // Implementando operações básicas (soma, diminui, multiplica, divide)

        private void btn_soma_Click(object sender, EventArgs e)
        {
            ZeraVisor();
            lbl_operacao.Text = btn_soma.Text;
        }

        private void btn_diminui_Click(object sender, EventArgs e)
        {
            ZeraVisor();
            lbl_operacao.Text = btn_diminui.Text;
        }

        private void btn_multiplica_Click(object sender, EventArgs e)
        {
            ZeraVisor();
            lbl_operacao.Text = btn_multiplica.Text;
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            ZeraVisor();
            lbl_operacao.Text = btn_divide.Text;
        }

        // Implementando o backspace [ <-- ]

        private void btn_back_Click(object sender, EventArgs e)
        {
            txt_visor.Text = txt_visor.Text.Remove(txt_visor.Text.Length-1, 1);
        }

        // Implementando botão de igual [ = ]

        private void btn_igual_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                RealizaOperacao();
                lbl_operacao.Text = "";
                visorContemNumero = false;
            }
        }

        // Implementando operações avançadas [ log / x^2 / x^y / sen / cos / tan / raiz )

        private void btn_log_Click(object sender, EventArgs e)
        {
            txt_visor.Text = Convert.ToString(Math.Log10(Convert.ToDouble(txt_visor.Text)));
            visorContemNumero = false;
        }

        private void btn_exp2_Click(object sender, EventArgs e)
        {
            txt_visor.Text = Convert.ToString(Math.Pow(Convert.ToDouble(txt_visor.Text), 2));
            visorContemNumero = false;
        }

        private void btn_pot_Click(object sender, EventArgs e)
        {
            ZeraVisor();
            lbl_operacao.Text = btn_pot.Text;
        }

        private void btn_sen_Click(object sender, EventArgs e)
        {
            // Seno já convertido em graus
            txt_visor.Text = Convert.ToString(Math.Sin((Math.PI / 180) * (Convert.ToDouble(txt_visor.Text))));
            visorContemNumero = false;
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            // Cosseno já convertido em graus
            txt_visor.Text = Convert.ToString(Math.Cos((Math.PI / 180) * (Convert.ToDouble(txt_visor.Text))));
            visorContemNumero = false;
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            // Tangente já convertida em graus
            txt_visor.Text = Convert.ToString(Math.Tan((Math.PI / 180) * (Convert.ToDouble(txt_visor.Text))));
            visorContemNumero = false;
        }

        private void btn_raiz_Click(object sender, EventArgs e)
        {
            txt_visor.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(txt_visor.Text)));
            visorContemNumero = false;
        }

        // Implementando operações recursivas [ n! ]

        private void btn_fatorial_Click(object sender, EventArgs e)
        {
            txt_visor.Text = Convert.ToString(Fatorial(Convert.ToDouble(txt_visor.Text)));
            visorContemNumero = false;
        }

        // Implementando operações de repetição [ MC / MR / M+ / M- ]

        private void btn_mc_Click(object sender, EventArgs e)
        {
            memoria = 0;
            lbl_memoria.Text = "";

            btn_mr.Enabled = false;
            btn_mc.Enabled = false;
        }

        private void btn_mr_Click(object sender, EventArgs e)
        {
            txt_visor.Text = lbl_memoria.Text;
        }

        private void btn_mmais_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                memoria += Convert.ToDouble(txt_visor.Text);
                lbl_memoria.Text = Convert.ToString(memoria);

                txt_visor.Text = "";
                visorContemNumero = false;

                btn_mr.Enabled = true;
                btn_mc.Enabled = true; 
            }
        }

        private void btn_mmenos_Click(object sender, EventArgs e)
        {
            if (txt_visor.Text != "")
            {
                memoria -= Convert.ToDouble(txt_visor.Text);
                lbl_memoria.Text = Convert.ToString(memoria);

                txt_visor.Text = "";
                visorContemNumero = false;

                btn_mr.Enabled = true;
                btn_mc.Enabled = true; 
            }
        }

        // Implementando funções complementares

        private void ZeraVisor()
        {
            numero = txt_visor.Text;
            txt_visor.Text = "";
        }

        private void RealizaOperacao()
        {
            switch (lbl_operacao.Text)
            {
                case "+":
                    txt_visor.Text = Convert.ToString(Convert.ToDouble(numero) + Convert.ToDouble(txt_visor.Text));
                    break;
                case "-":
                    txt_visor.Text = Convert.ToString(Convert.ToDouble(numero) - Convert.ToDouble(txt_visor.Text));
                    break;
                case "*":
                    txt_visor.Text = Convert.ToString(Convert.ToDouble(numero) * Convert.ToDouble(txt_visor.Text));
                    break;
                case "/":
                    if (txt_visor.Text == "0")
                    {
                        txt_visor.Text = "Dividir por 0?";
                        break;
                    }
                    else
                    {
                        txt_visor.Text = Convert.ToString(Convert.ToDouble(numero) / Convert.ToDouble(txt_visor.Text));
                        break;
                    }
                case "x^y":
                    txt_visor.Text = Convert.ToString(Math.Pow(Convert.ToDouble(numero), Convert.ToDouble(txt_visor.Text)));
                    break;
                default:
                    break;
            }
        }

        private double Fatorial(double num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
        }
    }
}
