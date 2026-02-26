using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace f5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AtualizarTextoNo(TreeNode no)
        {
            string nomeOriginal = no.Name;

            if (!no.IsExpanded)
            {
                no.Text = nomeOriginal + " (" + no.Nodes.Count + " inscrições)";
            }
            else
            {
                no.Text = nomeOriginal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbCursos.SelectedIndex = 0;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            btnInscrever.Enabled = (txtNum.Text != "" && cbbCursos.Text != "");
        }

        private void btnInscrever_Click(object sender, EventArgs e)
        {
            string nomeCurso = cbbCursos.Text;
            string numAluno = txtNum.Text;
            TreeNode paiExistente = null;

            foreach (TreeNode node in trvInscricoes.Nodes)
            {
                if (node.Name == nomeCurso)
                {
                    paiExistente = node;
                    break;
                }
            }

            if (paiExistente == null)
            {
                paiExistente = new TreeNode(nomeCurso);
                paiExistente.Name = nomeCurso;
                trvInscricoes.Nodes.Add(paiExistente);
            }

            int contador = 0;
            foreach (TreeNode filho in paiExistente.Nodes)
            {
                if (filho.Text == numAluno) contador++;
            }

            if (contador >= 3)
            {
                MessageBox.Show("O aluno " + numAluno + " já atingiu o limite de 3 inscrições no curso de " + nomeCurso);
            }
            else
            {
                paiExistente.Nodes.Add(numAluno);
                AtualizarTextoNo(paiExistente);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (trvInscricoes.SelectedNode != null)
            {
                if (trvInscricoes.SelectedNode.Parent == null)
                {
                    MessageBox.Show("Não pode eliminar um nó raiz!");
                }
                else
                {
                    TreeNode noRaiz = trvInscricoes.SelectedNode.Parent;
                    trvInscricoes.SelectedNode.Remove();

                    if (noRaiz.Nodes.Count == 0)
                    {
                        noRaiz.Remove();
                    }
                    else
                    {
                        AtualizarTextoNo(noRaiz);
                    }
                }
            }
            trvInscricoes.SelectedNode = null;
            btnEliminar.Enabled = false;
        }

        private void trvInscricoes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btnEliminar.Enabled = (trvInscricoes.SelectedNode != null && trvInscricoes.SelectedNode.Parent != null);
        }

        private void trvInscricoes_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            AtualizarTextoNo(e.Node);
        }

        private void trvInscricoes_AfterExpand(object sender, TreeViewEventArgs e)
        {
            AtualizarTextoNo(e.Node);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            string relatorio = "Relatório de Inscrições:\n\n";
            int totalGlobal = 0;

            foreach (TreeNode curso in trvInscricoes.Nodes)
            {
               
                relatorio += "Curso: " + curso.Name + " - " + curso.Nodes.Count + " inscrições\n";
                totalGlobal += curso.Nodes.Count;
            }

            relatorio += "\nTotal Global: " + totalGlobal + " inscrições.";

            MessageBox.Show(relatorio, "Estatísticas de Inscrições", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

    }
}



