using System;
using System.Windows.Forms;

namespace Inter240083
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Data + 7 dias
            dtpData.Value = DateTime.Now.AddDays(7);

            // Títulos da ListBox
            lstInscPInsc.Items.Clear();
            lstInscPInsc.Items.Add("Programação");
            lstInscPInsc.Items.Add("Redes");

            // Separador Inscrições visível
            tbcInsc.SelectedIndex = 2;

            // ProgressBar
            prbInsc.Minimum = 0;
            prbInsc.Maximum = 6;
            prbInsc.Value = 0;

            lblInscPIsnc.Text = "0 inscrições";
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnInscreverPEmpresa_Click(object sender, EventArgs e)
        {
            string numero = txtNum.Text;
            string nome = txtNome.Text;
            string genero = rdbMasc.Checked ? "M" : "F";
            string data = dtpData.Value.ToString("dd-MM-yyyy");

            if (numero == "" || nome == "")
            {
                MessageBox.Show("Preencha Número e Nome.");
                return;
            }

            if ((dtpData.Value - DateTime.Now).TotalDays < 7)
            {
                MessageBox.Show("Data deve ter pelo menos 7 dias.");
                return;
            }

            if (chkempresas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos uma empresa.");
                return;
            }

            string area = "";

            if (chkprog.Checked)
                area = "Programação";
            else if (chkRedes.Checked)
                area = "Redes";

            if (area == "")
            {
                MessageBox.Show("Escolha Programação ou Redes.");
                return;
            }

            foreach (var empresa in chkempresas.CheckedItems)
            {
                string emp = empresa.ToString();

                int totalAluno = 0;
                int totalArea = 0;

                foreach (var item in lstInscPInsc.Items)
                {
                    string linhaExistente = item.ToString();

                    if (linhaExistente.StartsWith(numero + ","))
                        totalAluno++;

                    if (linhaExistente.StartsWith(numero + ",") &&
                        linhaExistente.Contains(" - " + area))
                        totalArea++;

                    if (linhaExistente == $"{numero}, {nome}, {genero}, {data} - {emp} ({area})")
                    {
                        MessageBox.Show("Inscrição já existe.");
                        return;
                    }
                }

                if (totalAluno >= 6)
                {
                    MessageBox.Show("Máximo 6 inscrições por aluno.");
                    return;
                }

                if (totalArea >= 3)
                {
                    MessageBox.Show("Máximo 3 por área.");
                    return;
                }

                string nova = $"{numero}, {nome}, {genero}, {data} - {emp} ({area})";

                int pos = lstInscPInsc.Items.IndexOf(area);

                if (pos >= 0)
                {
                    int i = pos + 1;

                    while (i < lstInscPInsc.Items.Count &&
                           lstInscPInsc.Items[i].ToString() != "Programação" &&
                           lstInscPInsc.Items[i].ToString() != "Redes")
                    {
                        i++;
                    }

                    lstInscPInsc.Items.Insert(i, nova);
                }
            }

            lblInscPIsnc.Text = (lstInscPInsc.Items.Count - 2) + " inscrições";

            chkprog.Checked = false;
            chkRedes.Checked = false;

            for (int i = 0; i < chkempresas.Items.Count; i++)
                chkempresas.SetItemChecked(i, false);
            int count = 0;

            foreach (var item in lstInscPInsc.Items)
                if (item.ToString().StartsWith(txtNum.Text + ","))
                    count++;

            prbInsc.Value = count;
            AtualizarProgressBar();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var item in lstInscPInsc.Items)
                if (item.ToString().StartsWith(txtNum.Text + ","))
                    count++;

            if (count <= prbInsc.Maximum)
                prbInsc.Value = count;
            AtualizarProgressBar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtNome.Clear();
            rdbMasc.Checked = true;
            dtpData.Value = DateTime.Now.AddDays(7);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (lstInscPInsc.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione algo para eliminar.");
                return;
            }

            for (int i = lstInscPInsc.SelectedIndices.Count - 1; i >= 0; i--)
            {
                string item = lstInscPInsc.SelectedItems[i].ToString();

                if (item == "Programação" || item == "Redes")
                    continue;

                lstInscPInsc.Items.Remove(item);
            }

            lblInscPIsnc.Text = (lstInscPInsc.Items.Count - 2) + " inscrições";
        }

        private void btnNempresa_Click(object sender, EventArgs e)
        {
            if (btnNempresa.Text == "Nova Empresa")
            {
                txtNovaempresa.Visible = true;
                btnNempresa.Text = "Inserir";
            }
            else
            {
                if (txtNovaempresa.Text == "")
                {
                    txtNovaempresa.Visible = false;
                    btnNempresa.Text = "Nova Empresa";
                    return;
                }

                if (chkempresas.Items.Contains(txtNovaempresa.Text))
                {
                    MessageBox.Show("Empresa já existe.");
                }
                else
                {
                    chkempresas.Items.Add(txtNovaempresa.Text);
                }

                txtNovaempresa.Visible = false;
                btnNempresa.Text = "Nova Empresa";
                txtNovaempresa.Clear();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int prog = 0;
            int redes = 0;

            foreach (var item in lstInscPInsc.Items)
            {
                if (item.ToString().Contains("(Programação)"))
                    prog++;

                if (item.ToString().Contains("(Redes)"))
                    redes++;
            }

            MessageBox.Show($"Programação: {prog}\nRedes: {redes}");
            Close();
        }
    
    private void AtualizarProgressBar()
        {
            int count = 0;

            foreach (var item in lstInscPInsc.Items)
            {
                if (item.ToString().StartsWith(txtNum.Text + ","))
                    count++;
            }

            if (count <= prbInsc.Maximum)
                prbInsc.Value = count;

            lblInsc.Text = count.ToString() + "  Inscriçoes"; // <-- nome da label da barra
        }
    }

}