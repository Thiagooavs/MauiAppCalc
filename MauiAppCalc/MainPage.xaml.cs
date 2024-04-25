using Microsoft.Extensions.Options;

namespace MauiAppCalc
{

    public partial class MainPage : ContentPage
    {
        String? operacao = null;

        double memoria_calc_pre_operacao = 0;
        double memoria_calc_pos_operacao = 0;
       

        string para_apárecer_no_visor = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void remover_sinais_visor()
        {
            if(para_apárecer_no_visor == "+" ||
               para_apárecer_no_visor == "-" ||
               para_apárecer_no_visor == "*" ||
               para_apárecer_no_visor == "/" ||
               para_apárecer_no_visor == "%" )
            {
                para_apárecer_no_visor = "";
            }
        }

        private void zerar_Cliked (object sender, EventArgs e)
        {
            Visor.Text = "0";
            para_apárecer_no_visor = "";
            memoria_calc_pos_operacao = 0;
            memoria_calc_pre_operacao = 0;
            operacao = null;

        }
        private void maismenos_Cliked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(Visor.Text);
            valor = valor * -1;
            Visor.Text = valor.ToString();
        }
        private void porcento_Cliked(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(para_apárecer_no_visor);
            double lindo = valor;
            valor = valor / 100;
            memoria_calc_pre_operacao += valor;
            para_apárecer_no_visor = "%";
            Visor.Text = para_apárecer_no_visor;
            operacao ="%";
            
        }
        private void dividir_Cliked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(Visor.Text);
            para_apárecer_no_visor = "/";
            operacao = "/";
            Visor.Text = para_apárecer_no_visor;
        }
        private void num7_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num7.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num8_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num8.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num9_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num9.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void multiplicar_Cliked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(Visor.Text);
            para_apárecer_no_visor = "*";
            operacao = "*";
            Visor.Text = para_apárecer_no_visor;
        }
        private void num4_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num4.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num5_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num5.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num6_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num6.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void subtrair_Cliked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(Visor.Text);
            para_apárecer_no_visor = "-";
            operacao = "-";
            Visor.Text = para_apárecer_no_visor;
        }
        private void num1_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num1.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num2_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num2.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void num3_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num3.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void somar_Cliked(object sender, EventArgs e)
        {
            memoria_calc_pre_operacao = Convert.ToDouble(Visor.Text);
            para_apárecer_no_visor = "+";
            operacao = "+";
            Visor.Text = para_apárecer_no_visor;
        }
        private void num0_Cliked(object sender, EventArgs e)
        {
            remover_sinais_visor();
            para_apárecer_no_visor += num0.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void ponto_Cliked(object sender, EventArgs e)
        {
            para_apárecer_no_visor += ponto.Text;
            Visor.Text = para_apárecer_no_visor;
        }
        private void igual_Cliked(object sender, EventArgs e)
        {
            try
            {
                memoria_calc_pos_operacao = Convert.ToDouble(Visor.Text);
                double resultado = 0;

                switch (operacao)
                {
                    case "/":
                        resultado = memoria_calc_pre_operacao / memoria_calc_pos_operacao;
                        break;

                    case "+":
                        resultado = memoria_calc_pre_operacao + memoria_calc_pos_operacao;
                        break;

                    case "-":
                        resultado = memoria_calc_pre_operacao - memoria_calc_pos_operacao;
                        break;

                    case "*":
                        resultado = memoria_calc_pre_operacao * memoria_calc_pos_operacao;
                        break;

                    case "%":
                        resultado = memoria_calc_pre_operacao * memoria_calc_pos_operacao;
                        break;

                }
                Visor.Text = resultado.ToString();
                operacao = "";
            }
            catch (Exception ex)
            {
                Visor.Text = ex.Message;
            }

        }
    }

}
