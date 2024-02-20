namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtResultado = new TextBox();
            BtnUm = new Button();
            BtnDois = new Button();
            BtnTres = new Button();
            BtnQuatro = new Button();
            BtnCinco = new Button();
            BtnSeis = new Button();
            BtnSete = new Button();
            BtnOito = new Button();
            BtnNove = new Button();
            BtnZero = new Button();
            BtnIgual = new Button();
            BtnVirgula = new Button();
            BtnAdicao = new Button();
            BtnSubtracao = new Button();
            BtnMultiplicacao = new Button();
            BtnDivisao = new Button();
            BtnLimpar = new Button();
            LblOperacao = new Label();
            SuspendLayout();
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(26, 30);
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(305, 27);
            TxtResultado.TabIndex = 0;
            // 
            // BtnUm
            // 
            BtnUm.Location = new Point(26, 259);
            BtnUm.Name = "BtnUm";
            BtnUm.Size = new Size(69, 51);
            BtnUm.TabIndex = 1;
            BtnUm.Text = "1";
            BtnUm.UseVisualStyleBackColor = true;
            BtnUm.Click += BtnUm_Click;
            // 
            // BtnDois
            // 
            BtnDois.Location = new Point(101, 259);
            BtnDois.Name = "BtnDois";
            BtnDois.Size = new Size(69, 51);
            BtnDois.TabIndex = 2;
            BtnDois.Text = "2";
            BtnDois.UseVisualStyleBackColor = true;
            BtnDois.Click += BtnDois_Click;
            // 
            // BtnTres
            // 
            BtnTres.Location = new Point(176, 259);
            BtnTres.Name = "BtnTres";
            BtnTres.Size = new Size(69, 51);
            BtnTres.TabIndex = 3;
            BtnTres.Text = "3";
            BtnTres.UseVisualStyleBackColor = true;
            BtnTres.Click += BtnTres_Click;
            // 
            // BtnQuatro
            // 
            BtnQuatro.Location = new Point(26, 202);
            BtnQuatro.Name = "BtnQuatro";
            BtnQuatro.Size = new Size(69, 51);
            BtnQuatro.TabIndex = 4;
            BtnQuatro.Text = "4";
            BtnQuatro.UseVisualStyleBackColor = true;
            BtnQuatro.Click += BtnQuatro_Click;
            // 
            // BtnCinco
            // 
            BtnCinco.Location = new Point(101, 202);
            BtnCinco.Name = "BtnCinco";
            BtnCinco.Size = new Size(69, 51);
            BtnCinco.TabIndex = 5;
            BtnCinco.Text = "5";
            BtnCinco.UseVisualStyleBackColor = true;
            BtnCinco.Click += BtnCinco_Click;
            // 
            // BtnSeis
            // 
            BtnSeis.Location = new Point(176, 202);
            BtnSeis.Name = "BtnSeis";
            BtnSeis.Size = new Size(69, 51);
            BtnSeis.TabIndex = 6;
            BtnSeis.Text = "6";
            BtnSeis.UseVisualStyleBackColor = true;
            BtnSeis.Click += BtnSeis_Click;
            // 
            // BtnSete
            // 
            BtnSete.Location = new Point(26, 145);
            BtnSete.Name = "BtnSete";
            BtnSete.Size = new Size(69, 51);
            BtnSete.TabIndex = 7;
            BtnSete.Text = "7";
            BtnSete.UseVisualStyleBackColor = true;
            BtnSete.Click += BtnSete_Click;
            // 
            // BtnOito
            // 
            BtnOito.Location = new Point(101, 145);
            BtnOito.Name = "BtnOito";
            BtnOito.Size = new Size(69, 51);
            BtnOito.TabIndex = 8;
            BtnOito.Text = "8";
            BtnOito.UseVisualStyleBackColor = true;
            BtnOito.Click += BtnOito_Click;
            // 
            // BtnNove
            // 
            BtnNove.Location = new Point(176, 145);
            BtnNove.Name = "BtnNove";
            BtnNove.Size = new Size(69, 51);
            BtnNove.TabIndex = 9;
            BtnNove.Text = "9";
            BtnNove.UseVisualStyleBackColor = true;
            BtnNove.Click += BtnNove_Click;
            // 
            // BtnZero
            // 
            BtnZero.Location = new Point(101, 316);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(69, 51);
            BtnZero.TabIndex = 10;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = true;
            BtnZero.Click += BtnZero_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.Location = new Point(176, 316);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(69, 51);
            BtnIgual.TabIndex = 11;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = true;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnVirgula
            // 
            BtnVirgula.Location = new Point(26, 316);
            BtnVirgula.Name = "BtnVirgula";
            BtnVirgula.Size = new Size(69, 51);
            BtnVirgula.TabIndex = 12;
            BtnVirgula.Text = ",";
            BtnVirgula.UseVisualStyleBackColor = true;
            BtnVirgula.Click += BtnVirgula_Click;
            // 
            // BtnAdicao
            // 
            BtnAdicao.Location = new Point(251, 316);
            BtnAdicao.Name = "BtnAdicao";
            BtnAdicao.Size = new Size(69, 51);
            BtnAdicao.TabIndex = 13;
            BtnAdicao.Text = "+";
            BtnAdicao.UseVisualStyleBackColor = true;
            BtnAdicao.Click += BtnAdicao_Click;
            // 
            // BtnSubtracao
            // 
            BtnSubtracao.Location = new Point(251, 259);
            BtnSubtracao.Name = "BtnSubtracao";
            BtnSubtracao.Size = new Size(69, 51);
            BtnSubtracao.TabIndex = 14;
            BtnSubtracao.Text = "-";
            BtnSubtracao.UseVisualStyleBackColor = true;
            BtnSubtracao.Click += BtnSubtracao_Click;
            // 
            // BtnMultiplicacao
            // 
            BtnMultiplicacao.Location = new Point(251, 202);
            BtnMultiplicacao.Name = "BtnMultiplicacao";
            BtnMultiplicacao.Size = new Size(69, 51);
            BtnMultiplicacao.TabIndex = 15;
            BtnMultiplicacao.Text = "x";
            BtnMultiplicacao.UseVisualStyleBackColor = true;
            BtnMultiplicacao.Click += BtnMultiplicacao_Click;
            // 
            // BtnDivisao
            // 
            BtnDivisao.Location = new Point(251, 145);
            BtnDivisao.Name = "BtnDivisao";
            BtnDivisao.Size = new Size(69, 51);
            BtnDivisao.TabIndex = 16;
            BtnDivisao.Text = "/";
            BtnDivisao.UseVisualStyleBackColor = true;
            BtnDivisao.Click += BtnDivisao_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(251, 88);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(69, 51);
            BtnLimpar.TabIndex = 17;
            BtnLimpar.Text = "C";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // LblOperacao
            // 
            LblOperacao.AutoSize = true;
            LblOperacao.Location = new Point(310, 33);
            LblOperacao.Name = "LblOperacao";
            LblOperacao.Size = new Size(0, 20);
            LblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 397);
            Controls.Add(LblOperacao);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnDivisao);
            Controls.Add(BtnMultiplicacao);
            Controls.Add(BtnSubtracao);
            Controls.Add(BtnAdicao);
            Controls.Add(BtnVirgula);
            Controls.Add(BtnIgual);
            Controls.Add(BtnZero);
            Controls.Add(BtnNove);
            Controls.Add(BtnOito);
            Controls.Add(BtnSete);
            Controls.Add(BtnSeis);
            Controls.Add(BtnCinco);
            Controls.Add(BtnQuatro);
            Controls.Add(BtnTres);
            Controls.Add(BtnDois);
            Controls.Add(BtnUm);
            Controls.Add(TxtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResultado;
        private Button BtnUm;
        private Button BtnDois;
        private Button BtnTres;
        private Button BtnQuatro;
        private Button BtnCinco;
        private Button BtnSeis;
        private Button BtnSete;
        private Button BtnOito;
        private Button BtnNove;
        private Button BtnZero;
        private Button BtnIgual;
        private Button BtnVirgula;
        private Button BtnAdicao;
        private Button BtnSubtracao;
        private Button BtnMultiplicacao;
        private Button BtnDivisao;
        private Button BtnLimpar;
        private Label LblOperacao;
    }
}
