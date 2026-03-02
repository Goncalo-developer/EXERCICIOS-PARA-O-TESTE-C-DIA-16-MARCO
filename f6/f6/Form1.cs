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

            ListViewItem novoItem = new ListViewItem(txtNum.Text, imgindex);
             

            lstvInsc.Items.Add(novoItem);


            ListViewItem novoItem1 = new ListViewItem(grpGenero.Text, imgindex);
            if (rdbMasc.Checked)
                novoItem.SubItems.Add("M");
            else
                novoItem.SubItems.Add("F");

            ListViewItem novoItem2 = new ListViewItem(cbbCurso.Text, imgindex);
            lstvInsc.Items.Add(novoItem2);


        }
    }
}
