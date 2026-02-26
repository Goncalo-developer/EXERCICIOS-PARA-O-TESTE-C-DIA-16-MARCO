using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbb_curso.SelectedIndex = 0;
        }

        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            if (txt_num.Text != "" && txt_num.Text != "")
                btn_inscrever.Enabled = true;
            else
                btn_inscrever.Enabled = false;
        }

        private void btn_inscrever_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(cbb_curso.Text);
            node.Nodes.Add(txt_num.Text);
            trv_insc.Nodes.Add(node);
        }
    }
}
