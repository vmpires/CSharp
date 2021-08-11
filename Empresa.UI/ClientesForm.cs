using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.DB;
using Empresa.Models;

namespace Empresa.UI
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listadataGridView.Visible = true;
            listadataGridView.Dock = DockStyle.Fill;
            fichaPainel.Visible = false;
            novoButton.Visible = true;
            alterarButton.Visible = true;
            excluirButton.Visible = true;
            sairButton.Visible = true;
            confirmarNovoButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            voltarButton.Visible = false;

            var db = new ClienteDB();
            listadataGridView.DataSource = db.Pesquisar();
            listadataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listadataGridView.ReadOnly = false;
            listadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listadataGridView.RowHeadersVisible = false;
            listadataGridView.EnableHeadersVisualStyles = false;
            listadataGridView.Columns["Id"].Width = 50;


        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            confirmarNovoButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            LimparFicha();
        }

        private void LimparFicha()
        {
            idTextBox.Clear();
            emailTextBox.Clear();
            nomeTextBox.Clear();
            telefoneTextBox.Clear();
            idTextBox.Focus();
        }

        private void ExibirFicha()
        {
            fichaPainel.Visible = true;
            fichaPainel.Dock = DockStyle.Fill;
            novoButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            sairButton.Visible = false;
            confirmarNovoButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            voltarButton.Visible = true;

        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void confirmarNovoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDB();
            db.Incluir(cliente);
            ExibirGrid();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listadataGridView.CurrentRow.DataBoundItem;

            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;
            ExibirFicha();
            confirmarNovoButton.Visible = false;
            confirmarAlterarButton.Visible = true;
            confirmarExcluirButton.Visible = false;


        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDB();
            db.Alterar(cliente);
            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listadataGridView.CurrentRow.DataBoundItem;
            idTextBox.Text = cliente.Id.ToString();
            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;
            ExibirFicha();
            confirmarNovoButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = true;

        }

        private void confirmarExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(idTextBox.Text);
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;
            var db = new ClienteDB();
            db.Excluir(cliente.Id);
            ExibirGrid();
        }

        private void sairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
