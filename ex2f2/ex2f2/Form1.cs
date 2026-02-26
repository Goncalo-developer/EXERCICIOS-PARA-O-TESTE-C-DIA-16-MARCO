using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2f2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOk.Enabled = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNumero.Text != "")
                btnAdicionar.Enabled = true;
            else
                btnAdicionar.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNumero.Text != "")
                btnAdicionar.Enabled = true;
            else
                btnAdicionar.Enabled = false;
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            string strInsc = txtNumero.Text + "-" + txtNome.Text + "-" + grbDisciplina.Text + "-" + grbEpoca;
            string disciplina = "";
            string nome = txtNome.Text;
            string num = txtNumero.Text;
            string epoca = "";
            string preco = "";
            if (!ckb1vez.Checked && !rdbOutra.Checked && !rdbPascoa.Checked && !rdbNatal.Checked && !rdbVerao.Checked)
            {
                MessageBox.Show("Seleciona uma epoca");
                return;
            }

            if (ckb1vez.Checked && rdbNatal.Checked || rdbPascoa.Checked || rdbVerao.Checked) preco = "isento";
            else if (!ckb1vez.Checked && rdbOutra.Checked) preco = "50 euros";
            else if (ckb1vez.Checked && rdbOutra.Checked) preco = "35 euros";
            else if (!ckb1vez.Checked && rdbNatal.Checked || rdbPascoa.Checked || rdbVerao.Checked) preco = "25 euros";

                foreach (RadioButton discp in grbDisciplina.Controls)
                {
                    if (discp.Checked)
                    {
                        disciplina = discp.Text;
                    }
                }
            foreach (RadioButton epc in grbEpoca.Controls)
            {
                if (epc.Checked)
                {
                    epoca = epc.Text;
                }
            }



                string linha = $"{nome},{num} :{disciplina},{epoca}:{preco}";
                if(!string.IsNullOrWhiteSpace(txtInscricoesScrollBar.Text))
            {
               
            }
            txtInscricoesScrollBar.AppendText(linha+Environment.NewLine);   
            txtNome.Text = "";
            txtNumero.Text = "";
            txtNumero.Focus();
            txtNumero.Focus();
            rdbPSI.Focus();
            rdbPascoa.Checked = false;
            rdbVerao.Checked = false;
            rdbNatal.Checked = false;
            rdbOutra.Checked = false;
            ckb1vez.Checked = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Tem a certeza que quer terminar a aplicação ?", " Inscrições em AEs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            { }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblInscPsi_TextChanged(object sender, EventArgs e)
        {

        }
private void txtInscricoesScrollBar_TextChanged(object sender, EventArgs e)
        {
            {
                int cntpsi = 0, cntother = 0;
                foreach (string lin in txtInscricoesScrollBar.Lines)
                {
                    if (string.IsNullOrWhiteSpace(lin))
                        continue;
                    if (lin.Contains(":PSI"))
                        cntpsi++;
                    else
                        cntother++;
                }
                lblInscPsi.Text = cntpsi.ToString() + " Inscrições em PSI ";
                lblInscOutras.Text = cntother.ToString() + " Inscrições em Outras disciplinas";

                lblInscPsi.ForeColor = Color.Black;
                lblInscOutras.ForeColor = Color.Black;

                if (cntpsi > cntother && cntpsi > 12) lblInscPsi.ForeColor = Color.Green;
                else if (cntother > cntpsi && cntother > 12) lblInscOutras.ForeColor = Color.Green;

                if (cntpsi < cntother && cntpsi >= 1 && cntpsi <= 6) lblInscPsi.ForeColor = Color.Red;
                else if (cntother < cntpsi && cntother >= 1 && cntother <= 6) lblInscOutras.ForeColor = Color.Red;
            


            }
        }
    }
}
       