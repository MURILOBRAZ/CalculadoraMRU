using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03_202873
{
    public partial class FrmGeral : Form
    {
        #region VARIAVEIS GLOBAIS
        string msg, título;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion

        #region FORM    
        public FrmGeral()
        {
            InitializeComponent();
        }
        #endregion

        #region SAIR    
        private void BtnSair_Click(object sender, EventArgs e)
        {
            msg = "Tem Certeza?";
            título = "Sair do Programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, título, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }

        }
        #endregion

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LblHora.Text = DateTime.Now.ToString();
        }
        #endregion

        #region CALCULAR    
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double So;
            double Vo;
            double a;
            double t;
            double S;
            double V;
            try
            {
                So = double.Parse(TxtSo.Text);
                Vo = double.Parse(TxtVo.Text);
                a = double.Parse(TxtA.Text);
                t = double.Parse(TxtT.Text);

                if (a < 0)
                {
                    MessageBox.Show("Erro na Aceleração");
                    a = 0;
                    TxtA.Clear();
                    TxtA.Focus();
                }
                else
                {
                    if (So < 0)
                    {
                        MessageBox.Show("Erro no Espaço Inicial");
                        So = 0;
                        TxtSo.Clear();
                        TxtSo.Focus();
                    }
                    else
                    {
                        if (Vo < 0)
                        {
                            MessageBox.Show("Erro no Velocidade Inicial");
                            Vo = 0;
                            TxtVo.Clear();
                            TxtVo.Focus();
                        }
                        else
                        {
                            if (t < 0)
                            {
                                MessageBox.Show("Erro no Tempo");
                                t = 0;
                                TxtT.Clear();
                                TxtT.Focus();
                            }
                            else
                            {
                                if(a == 0)
                                {
                                    S = So + (Vo * t);
                                    V = Vo;

                                    TxtPos.Text = S.ToString();
                                    TxtVelo.Text = V.ToString();
                                }
                                else
                                {
                                    S = So + (Vo * t) + ((a * (t * t)) / 2);
                                    V = Vo + (a * t);

                                    TxtPos.Text = S.ToString();
                                    TxtVelo.Text = V.ToString();
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro nos Calculos!!");
                return;
            }
        }
#endregion

        #region LIXO
        private void LblHora_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region LIMPAR
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            msg = "Tem Certeza?";
            título = "Limpar Tudo...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, título, botoes, icone, definido) == DialogResult.Yes)
            {
                TxtA.Text = "";
                TxtSo.Text = "";
                TxtT.Text = "";
                TxtVo.Text = "";
                TxtPos.Text = "";
                TxtVelo.Text = "";
            }

        }
        #endregion
    }
}
