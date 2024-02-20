namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            adicao,
            multiplicacao,
            subtracao,
            divisao

        }
        private void BtnZero_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0";
        }

        private void BtnUm_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void BtnSeis_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }

        private void BtnSete_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }

        private void BtnOito_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }

        private void BtnNove_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void BtnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.adicao;
            LblOperacao.Text = "+";
            Valor = decimal.Parse(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtracao;
            LblOperacao.Text = "-";
            Valor = decimal.Parse(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void BtnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicacao;
            LblOperacao.Text = "x";
            Valor = decimal.Parse(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.divisao;
            LblOperacao.Text = "/";
            Valor = decimal.Parse(TxtResultado.Text);
            TxtResultado.Text = "";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.adicao:
                    Resultado = Valor + decimal.Parse(TxtResultado.Text);
                    break;
                case Operacao.multiplicacao:
                    Resultado = Valor * decimal.Parse(TxtResultado.Text);
                    break;
                case Operacao.subtracao:
                    Resultado = Valor - decimal.Parse(TxtResultado.Text);
                    break;
                case Operacao.divisao:
                    Resultado = Valor / decimal.Parse(TxtResultado.Text);
                    break;

            }
            TxtResultado.Text = Convert.ToString(Resultado);
            LblOperacao.Text = "=";
   
        }

        private void BtnVirgula_Click(object sender, EventArgs e)
        {
            if (!TxtResultado.Text.Contains(","))
            {
                TxtResultado.Text += ",";
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
            LblOperacao.Text = "";
        }
    }
}
