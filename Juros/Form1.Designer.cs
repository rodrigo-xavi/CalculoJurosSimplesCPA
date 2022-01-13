
namespace Juros
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottonCalc = new System.Windows.Forms.Button();
            this.V_P = new System.Windows.Forms.Label();
            this.taxaJuros = new System.Windows.Forms.Label();
            this.TaxaMulta = new System.Windows.Forms.Label();
            this.DiasAtrasado = new System.Windows.Forms.Label();
            this.V_pagar = new System.Windows.Forms.Label();
            this.TJ = new System.Windows.Forms.Label();
            this.TM = new System.Windows.Forms.Label();
            this.D_A = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textData1 = new System.Windows.Forms.MaskedTextBox();
            this.textData2 = new System.Windows.Forms.MaskedTextBox();
            this.textParcela = new System.Windows.Forms.TextBox();
            this.TotalTaxas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(84, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data do Vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(84, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Data do Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(251, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 79);
            this.label3.TabIndex = 14;
            this.label3.Text = "Comercial Ponte Azul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 14);
            this.label2.TabIndex = 15;
            this.label2.Text = "Taxa de Juros:  8% a.m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taxa da Multa por Atraso:  2%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da Promissória:  R$";
            // 
            // BottonCalc
            // 
            this.BottonCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BottonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottonCalc.Location = new System.Drawing.Point(450, 486);
            this.BottonCalc.Name = "BottonCalc";
            this.BottonCalc.Size = new System.Drawing.Size(101, 40);
            this.BottonCalc.TabIndex = 2;
            this.BottonCalc.Text = "Calcular";
            this.BottonCalc.UseVisualStyleBackColor = true;
            this.BottonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // V_P
            // 
            this.V_P.AutoSize = true;
            this.V_P.BackColor = System.Drawing.SystemColors.ControlLight;
            this.V_P.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.V_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_P.ForeColor = System.Drawing.SystemColors.Desktop;
            this.V_P.Location = new System.Drawing.Point(708, 379);
            this.V_P.Name = "V_P";
            this.V_P.Size = new System.Drawing.Size(2, 41);
            this.V_P.TabIndex = 24;
            this.V_P.Click += new System.EventHandler(this.V_P_Click);
            // 
            // taxaJuros
            // 
            this.taxaJuros.AutoSize = true;
            this.taxaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxaJuros.ForeColor = System.Drawing.SystemColors.Control;
            this.taxaJuros.Location = new System.Drawing.Point(736, 220);
            this.taxaJuros.Name = "taxaJuros";
            this.taxaJuros.Size = new System.Drawing.Size(88, 15);
            this.taxaJuros.TabIndex = 17;
            this.taxaJuros.Text = "Valor do Juros:";
            // 
            // TaxaMulta
            // 
            this.TaxaMulta.AutoSize = true;
            this.TaxaMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxaMulta.ForeColor = System.Drawing.SystemColors.Control;
            this.TaxaMulta.Location = new System.Drawing.Point(736, 247);
            this.TaxaMulta.Name = "TaxaMulta";
            this.TaxaMulta.Size = new System.Drawing.Size(89, 15);
            this.TaxaMulta.TabIndex = 18;
            this.TaxaMulta.Text = "Valor da Multa:";
            // 
            // DiasAtrasado
            // 
            this.DiasAtrasado.AutoSize = true;
            this.DiasAtrasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasAtrasado.ForeColor = System.Drawing.SystemColors.Control;
            this.DiasAtrasado.Location = new System.Drawing.Point(736, 193);
            this.DiasAtrasado.Name = "DiasAtrasado";
            this.DiasAtrasado.Size = new System.Drawing.Size(93, 15);
            this.DiasAtrasado.TabIndex = 19;
            this.DiasAtrasado.Text = "Dias em Atraso:";
            // 
            // V_pagar
            // 
            this.V_pagar.AutoSize = true;
            this.V_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.V_pagar.ForeColor = System.Drawing.SystemColors.Control;
            this.V_pagar.Location = new System.Drawing.Point(560, 386);
            this.V_pagar.Name = "V_pagar";
            this.V_pagar.Size = new System.Drawing.Size(142, 24);
            this.V_pagar.TabIndex = 20;
            this.V_pagar.Text = "Valor a Pagar:";
            // 
            // TJ
            // 
            this.TJ.AutoSize = true;
            this.TJ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TJ.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TJ.Location = new System.Drawing.Point(837, 220);
            this.TJ.Name = "TJ";
            this.TJ.Size = new System.Drawing.Size(2, 20);
            this.TJ.TabIndex = 21;
            // 
            // TM
            // 
            this.TM.AutoSize = true;
            this.TM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TM.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TM.Location = new System.Drawing.Point(837, 248);
            this.TM.Name = "TM";
            this.TM.Size = new System.Drawing.Size(2, 20);
            this.TM.TabIndex = 22;
            // 
            // D_A
            // 
            this.D_A.AutoSize = true;
            this.D_A.BackColor = System.Drawing.SystemColors.ControlLight;
            this.D_A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.D_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_A.ForeColor = System.Drawing.SystemColors.Desktop;
            this.D_A.Location = new System.Drawing.Point(837, 192);
            this.D_A.Name = "D_A";
            this.D_A.Size = new System.Drawing.Size(2, 20);
            this.D_A.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Calculo de Promissórias em Atraso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textData1
            // 
            this.textData1.Location = new System.Drawing.Point(273, 246);
            this.textData1.Mask = "00/00/0000";
            this.textData1.Name = "textData1";
            this.textData1.Size = new System.Drawing.Size(111, 20);
            this.textData1.TabIndex = 1;
            this.textData1.ValidatingType = typeof(System.DateTime);
            this.textData1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textData1_MaskInputRejected);
            // 
            // textData2
            // 
            this.textData2.Location = new System.Drawing.Point(273, 302);
            this.textData2.Mask = "00/00/0000";
            this.textData2.Name = "textData2";
            this.textData2.Size = new System.Drawing.Size(111, 20);
            this.textData2.TabIndex = 2;
            this.textData2.ValidatingType = typeof(System.DateTime);
            this.textData2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textData2_MaskInputRejected);
            // 
            // textParcela
            // 
            this.textParcela.Location = new System.Drawing.Point(273, 190);
            this.textParcela.Name = "textParcela";
            this.textParcela.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textParcela.Size = new System.Drawing.Size(111, 20);
            this.textParcela.TabIndex = 0;
            this.textParcela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TotalTaxas
            // 
            this.TotalTaxas.AutoSize = true;
            this.TotalTaxas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TotalTaxas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalTaxas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxas.ForeColor = System.Drawing.Color.Red;
            this.TotalTaxas.Location = new System.Drawing.Point(835, 294);
            this.TotalTaxas.Name = "TotalTaxas";
            this.TotalTaxas.Size = new System.Drawing.Size(2, 27);
            this.TotalTaxas.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(705, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Total de Taxas:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1016, 578);
            this.Controls.Add(this.TotalTaxas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textData2);
            this.Controls.Add(this.textData1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.V_P);
            this.Controls.Add(this.D_A);
            this.Controls.Add(this.TM);
            this.Controls.Add(this.TJ);
            this.Controls.Add(this.V_pagar);
            this.Controls.Add(this.DiasAtrasado);
            this.Controls.Add(this.TaxaMulta);
            this.Controls.Add(this.taxaJuros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BottonCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textParcela);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Juros CPA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox textData1;
        private System.Windows.Forms.MaskedTextBox textData2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BottonCalc;
        private System.Windows.Forms.Label V_P;
        private System.Windows.Forms.Label taxaJuros;
        private System.Windows.Forms.Label TaxaMulta;
        private System.Windows.Forms.Label DiasAtrasado;
        private System.Windows.Forms.Label V_pagar;
        private System.Windows.Forms.Label TJ;
        private System.Windows.Forms.Label TM;
        private System.Windows.Forms.Label D_A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textParcela;
        private System.Windows.Forms.Label TotalTaxas;
        private System.Windows.Forms.Label label9;
    }
}

