using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace exExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbAutonomia.SelectedIndex = 3;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtModelo.Text != "")

                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void btnInserir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string linhaFinal = "";
            string nome = txtModelo.Text;
            string autonomia = cbbAutonomia.Text;

            if (rdbS.Checked)
            {
                linhaFinal = $"{nome}.HD, ({autonomia})";

            }
            else
            {
                linhaFinal = $"{nome}, ({autonomia})";

            }
            lstbInsc.Items.Add(linhaFinal);
            txtModelo.Text = "";
            rdbS.Checked = true;
            cbbAutonomia.SelectedIndex = 3;


        }


        private void lstbInsc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbInsc.SelectedItems.Count > 0)
                btnElim.Enabled = true;
            else
                btnElim.Enabled = false;

        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            foreach (object item in lstbInsc.SelectedItems.Cast<object>().ToList())
            {
                
                if (!item.ToString().Contains(".HD"))
                {
                    lstbInsc.Items.Remove(item);
                }
            }
            btnElim.Enabled= false;




        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double somaHD = 0, somaSemHD = 0, somaGlobal = 0;
            int contHD = 0, contSemHD = 0, contGlobal = 0;

            foreach (object item in lstbInsc.Items)
            {
                string linha = item.ToString();

                // Extrai o valor entre os parênteses (ex: "20min" -> "20")
                int inicio = linha.IndexOf('(') + 1;
                int fim = linha.IndexOf(')');
                string valorTexto = linha.Substring(inicio, fim - inicio).Replace("min", "");
                double autonomia = double.Parse(valorTexto);

                // Soma para a média global
                somaGlobal += autonomia;
                contGlobal++;

                // Separa por tipo (HD ou não)
                if (linha.Contains(".HD"))
                {
                    somaHD += autonomia;
                    contHD++;
                }
                else
                {
                    somaSemHD += autonomia;
                    contSemHD++;
                }
            }

            // Calcula as médias (evitando divisão por zero)
            double mediaGlobal = contGlobal > 0 ? somaGlobal / contGlobal : 0;
            double mediaHD = contHD > 0 ? somaHD / contHD : 0;
            double mediaSemHD = contSemHD > 0 ? somaSemHD / contSemHD : 0;

            // Exibe os resultados
            MessageBox.Show($"Média Global: {mediaGlobal:F2} min\n" +
                            $"Média com HD: {mediaHD:F2} min\n" +
                            $"Média sem HD: {mediaSemHD:F2} min");
            Application.Exit();
        }
    }
}
