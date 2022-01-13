using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Juros
{
    public partial class Form1 : Form
    {
        DateTime data1, data2;

        TimeSpan D_atraso;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textData1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textData1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void textData2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if ((!DateTime.TryParse(textData1.Text, out data1) || !DateTime.TryParse(textData2.Text, out data2)) || textBoxVazias())
            {
                if (!DateTime.TryParse(textData1.Text, out data1))
                    MessageBox.Show("Data do vencimento invalida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!DateTime.TryParse(textData2.Text, out data2))
                    MessageBox.Show("Data do pagamento invalida!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (textBoxVazias())
                    MessageBox.Show("Digite o valor da promissória!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
                Botão();

        }

        public void Botão()
        {
            double mon;
            double jur;
            double mul;
            double t_Taxas;
            double par = Convert.ToDouble(textParcela.Text);


            data1 = Convert.ToDateTime(textData1.Text);
            data2 = Convert.ToDateTime(textData2.Text);


            D_atraso = data2 - data1;
            mul = par * 0.02;
            jur = par * (0.08 * D_atraso.Days / 30);
            t_Taxas = mul + jur;
            mon = par + t_Taxas;




            if (D_atraso.Days <= 0 || par <= 0)
            {
                if (D_atraso.Days <= 0)
                    MessageBox.Show("Data do pagamento igual ou menor que a data do vencimento! Confira as datas e digite novamente. Caso as datas estejam corretas, a promissória do cliente não está em atraso.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (par <= 0)
                    MessageBox.Show("Valor da promissória invalido!",
                   "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);




            }
            else
            {
                TJ.Text = jur.ToString("R$ 0.00");
                TM.Text = mul.ToString("R$ 0.00");
                D_A.Text = D_atraso.Days.ToString();
                V_P.Text = mon.ToString("R$ 0.00");
                TotalTaxas.Text = t_Taxas.ToString("R$ 0.00");
            }
        }
        private bool textBoxVazias()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            return false;
        }

        private void V_P_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
       
        

    }
}
