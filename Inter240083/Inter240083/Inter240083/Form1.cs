using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dtpData.Value = DateTime.Now.AddDays(7);
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            tbcInsc.SelectedIndex = 2;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bloqueia a tecla
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }
    }
}
