using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void incluirClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteIncluirForm f = new ClienteIncluirForm();
            f.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ClientesForm();
            f.ShowDialog();
        }
    }
}
