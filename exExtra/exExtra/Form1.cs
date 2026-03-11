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
    }
}
