using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCurso.SelectedIndex = 0;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            btnInsc.Enabled = (txtNum.Text != "" && cbbCurso.Text != "");
        }

        private void btnInsc_Click(object sender, EventArgs e)
        {
            int imgindex = 0;
            if (cbbCurso.Text == "TGPSI")
                imgindex = 2;
            else if (cbbCurso.Text == "TOO")
                imgindex = 3;
            else if (cbbCurso.Text == "TER")
                imgindex = 4;
            else if (cbbCurso.Text == "TEAC")
                imgindex = 5;
            else if (cbbCurso.Text == "TOSP")
                imgindex = 6;

            int contador = 0;

            foreach (ListViewItem item in lstvInsc.Items)
            {
                if (item.Text == txtNum.Text)
                {
                    contador++;

                    if (item.SubItems[2].Text == cbbCurso.Text)
                    {
                        MessageBox.Show("Este número já está inscrito neste curso!");
                        return;
                    }
                }
            }

            if (contador >= 3)
            {
                MessageBox.Show("Este número já tem 3 inscrições!");
                return;
            }

            ListViewItem novoItem = new ListViewItem(txtNum.Text, imgindex);

            if (rdbMasc.Checked)
                novoItem.SubItems.Add("M");
            else
                novoItem.SubItems.Add("F");

            novoItem.SubItems.Add(cbbCurso.Text);

            lstvInsc.Items.Add(novoItem);
          
        }

        private void lstvInsc_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnElim.Enabled = lstvInsc.SelectedItems.Count > 0;

        }

        private void btnElim_Click(object sender, EventArgs e)
        {

            if (lstvInsc.SelectedItems.Count != 0)
            {
                ListViewItem item = lstvInsc.SelectedItems[0];

                if (item.SubItems[2].Text == cbbCurso.Text)
                    lstvInsc.Items.Remove(item);
            }

            btnElim.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string relatorio = "Relatório de Inscrições:\n\n";
            int totalGlobal = 0;

            string[] cursos = { "TGPSI", "TOO", "TER", "TEAC", "TOSP" };

            foreach (string cursoAtual in cursos)
            {
                int totalCurso = 0;
                int rapazes = 0;
                int raparigas = 0;

                foreach (ListViewItem item in lstvInsc.Items)
                {
                    if (item.SubItems[2].Text == cursoAtual)
                    {
                        totalCurso++;

                        if (item.SubItems[1].Text == "M")
                            rapazes++;
                        else
                            raparigas++;
                    }
                }

                relatorio += "Curso: " + cursoAtual + " - " + totalCurso +
                             " inscrições (" + rapazes + " rapazes, " +
                             raparigas + " raparigas)\n";

                totalGlobal += totalCurso;
            }

            relatorio += "\nTotal Global: " + totalGlobal + " inscrições.";

            MessageBox.Show(relatorio, "Estatísticas de Inscrições",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }
    }
    }
    

