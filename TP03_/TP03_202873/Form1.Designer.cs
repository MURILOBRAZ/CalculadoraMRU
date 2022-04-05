namespace TP03_202873
{
    partial class FrmGeral
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeral));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.LblResultado = new System.Windows.Forms.Label();
            this.lblINFO = new System.Windows.Forms.Label();
            this.LblPos = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.LblVelo = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.TxtVelo = new System.Windows.Forms.TextBox();
            this.TxtPos = new System.Windows.Forms.TextBox();
            this.TxtT = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtVo = new System.Windows.Forms.TextBox();
            this.TxtSo = new System.Windows.Forms.TextBox();
            this.Lblt = new System.Windows.Forms.Label();
            this.LblAce = new System.Windows.Forms.Label();
            this.LblVo = new System.Windows.Forms.Label();
            this.LblSO = new System.Windows.Forms.Label();
            this.LblM = new System.Windows.Forms.Label();
            this.LblMS = new System.Windows.Forms.Label();
            this.LblMS2 = new System.Windows.Forms.Label();
            this.LblS = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnLimpar);
            this.panel1.Controls.Add(this.LblResultado);
            this.panel1.Controls.Add(this.lblINFO);
            this.panel1.Controls.Add(this.LblPos);
            this.panel1.Controls.Add(this.BtnCalc);
            this.panel1.Controls.Add(this.LblVelo);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.TxtVelo);
            this.panel1.Controls.Add(this.TxtPos);
            this.panel1.Controls.Add(this.TxtT);
            this.panel1.Controls.Add(this.TxtA);
            this.panel1.Controls.Add(this.TxtVo);
            this.panel1.Controls.Add(this.TxtSo);
            this.panel1.Controls.Add(this.Lblt);
            this.panel1.Controls.Add(this.LblAce);
            this.panel1.Controls.Add(this.LblVo);
            this.panel1.Controls.Add(this.LblSO);
            this.panel1.Controls.Add(this.LblM);
            this.panel1.Controls.Add(this.LblMS);
            this.panel1.Controls.Add(this.LblMS2);
            this.panel1.Controls.Add(this.LblS);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 298);
            this.panel1.TabIndex = 0;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.White;
            this.BtnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpar.BackgroundImage")));
            this.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpar.Location = new System.Drawing.Point(413, 233);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(65, 62);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResultado.Location = new System.Drawing.Point(355, 13);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(123, 42);
            this.LblResultado.TabIndex = 21;
            this.LblResultado.Text = "Resultado";
            // 
            // lblINFO
            // 
            this.lblINFO.AutoSize = true;
            this.lblINFO.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINFO.Location = new System.Drawing.Point(24, 13);
            this.lblINFO.Name = "lblINFO";
            this.lblINFO.Size = new System.Drawing.Size(153, 42);
            this.lblINFO.TabIndex = 20;
            this.lblINFO.Text = "Informações";
            // 
            // LblPos
            // 
            this.LblPos.AutoSize = true;
            this.LblPos.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPos.Location = new System.Drawing.Point(268, 67);
            this.LblPos.Name = "LblPos";
            this.LblPos.Size = new System.Drawing.Size(169, 42);
            this.LblPos.TabIndex = 17;
            this.LblPos.Text = "Deslocamento";
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.Color.White;
            this.BtnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalc.BackgroundImage")));
            this.BtnCalc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalc.Location = new System.Drawing.Point(343, 233);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(64, 62);
            this.BtnCalc.TabIndex = 4;
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // LblVelo
            // 
            this.LblVelo.AutoSize = true;
            this.LblVelo.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVelo.Location = new System.Drawing.Point(304, 124);
            this.LblVelo.Name = "LblVelo";
            this.LblVelo.Size = new System.Drawing.Size(133, 42);
            this.LblVelo.TabIndex = 18;
            this.LblVelo.Text = "Velocidade";
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.White;
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSair.Location = new System.Drawing.Point(484, 233);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(55, 62);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TxtVelo
            // 
            this.TxtVelo.Location = new System.Drawing.Point(439, 146);
            this.TxtVelo.Name = "TxtVelo";
            this.TxtVelo.Size = new System.Drawing.Size(100, 20);
            this.TxtVelo.TabIndex = 16;
            // 
            // TxtPos
            // 
            this.TxtPos.Location = new System.Drawing.Point(439, 88);
            this.TxtPos.Name = "TxtPos";
            this.TxtPos.Size = new System.Drawing.Size(100, 20);
            this.TxtPos.TabIndex = 15;
            // 
            // TxtT
            // 
            this.TxtT.Location = new System.Drawing.Point(56, 263);
            this.TxtT.Name = "TxtT";
            this.TxtT.Size = new System.Drawing.Size(100, 20);
            this.TxtT.TabIndex = 10;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(56, 198);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(100, 20);
            this.TxtA.TabIndex = 9;
            // 
            // TxtVo
            // 
            this.TxtVo.Location = new System.Drawing.Point(56, 134);
            this.TxtVo.Name = "TxtVo";
            this.TxtVo.Size = new System.Drawing.Size(100, 20);
            this.TxtVo.TabIndex = 8;
            // 
            // TxtSo
            // 
            this.TxtSo.Location = new System.Drawing.Point(56, 76);
            this.TxtSo.Name = "TxtSo";
            this.TxtSo.Size = new System.Drawing.Size(100, 20);
            this.TxtSo.TabIndex = 7;
            // 
            // Lblt
            // 
            this.Lblt.AutoSize = true;
            this.Lblt.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblt.Location = new System.Drawing.Point(11, 241);
            this.Lblt.Name = "Lblt";
            this.Lblt.Size = new System.Drawing.Size(25, 42);
            this.Lblt.TabIndex = 3;
            this.Lblt.Text = "t";
            // 
            // LblAce
            // 
            this.LblAce.AutoSize = true;
            this.LblAce.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAce.Location = new System.Drawing.Point(11, 177);
            this.LblAce.Name = "LblAce";
            this.LblAce.Size = new System.Drawing.Size(31, 42);
            this.LblAce.TabIndex = 2;
            this.LblAce.Text = "a";
            // 
            // LblVo
            // 
            this.LblVo.AutoSize = true;
            this.LblVo.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVo.Location = new System.Drawing.Point(5, 113);
            this.LblVo.Name = "LblVo";
            this.LblVo.Size = new System.Drawing.Size(43, 42);
            this.LblVo.TabIndex = 1;
            this.LblVo.Text = "Vo";
            // 
            // LblSO
            // 
            this.LblSO.AutoSize = true;
            this.LblSO.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSO.Location = new System.Drawing.Point(5, 55);
            this.LblSO.Name = "LblSO";
            this.LblSO.Size = new System.Drawing.Size(45, 42);
            this.LblSO.TabIndex = 0;
            this.LblSO.Text = "So";
            // 
            // LblM
            // 
            this.LblM.AutoSize = true;
            this.LblM.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblM.Location = new System.Drawing.Point(153, 55);
            this.LblM.Name = "LblM";
            this.LblM.Size = new System.Drawing.Size(38, 42);
            this.LblM.TabIndex = 11;
            this.LblM.Text = "m";
            // 
            // LblMS
            // 
            this.LblMS.AutoSize = true;
            this.LblMS.BackColor = System.Drawing.Color.Transparent;
            this.LblMS.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMS.Location = new System.Drawing.Point(153, 113);
            this.LblMS.Name = "LblMS";
            this.LblMS.Size = new System.Drawing.Size(66, 42);
            this.LblMS.TabIndex = 12;
            this.LblMS.Text = "m/s";
            // 
            // LblMS2
            // 
            this.LblMS2.AutoSize = true;
            this.LblMS2.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMS2.Location = new System.Drawing.Point(153, 177);
            this.LblMS2.Name = "LblMS2";
            this.LblMS2.Size = new System.Drawing.Size(78, 42);
            this.LblMS2.TabIndex = 13;
            this.LblMS2.Text = "m/s²";
            // 
            // LblS
            // 
            this.LblS.AutoSize = true;
            this.LblS.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblS.Location = new System.Drawing.Point(153, 241);
            this.LblS.Name = "LblS";
            this.LblS.Size = new System.Drawing.Size(31, 42);
            this.LblS.TabIndex = 14;
            this.LblS.Text = "s";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LblHora);
            this.panel2.Location = new System.Drawing.Point(12, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 46);
            this.panel2.TabIndex = 1;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(136, 0);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(83, 45);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "HORA";
            this.LblHora.Click += new System.EventHandler(this.LblHora_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TP03_202873.Properties.Resources.Papel_velho41;
            this.ClientSize = new System.Drawing.Size(565, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:CalculadoraMRU:.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblS;
        private System.Windows.Forms.Label LblMS2;
        private System.Windows.Forms.Label LblMS;
        private System.Windows.Forms.Label LblM;
        private System.Windows.Forms.TextBox TxtT;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtVo;
        private System.Windows.Forms.TextBox TxtSo;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Label Lblt;
        private System.Windows.Forms.Label LblAce;
        private System.Windows.Forms.Label LblVo;
        private System.Windows.Forms.Label LblSO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblVelo;
        private System.Windows.Forms.Label LblPos;
        private System.Windows.Forms.TextBox TxtVelo;
        private System.Windows.Forms.TextBox TxtPos;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label lblINFO;
    }
}

