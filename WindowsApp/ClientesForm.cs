using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.Db;
using Models;

namespace Empresa.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid ()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            fichaPanel.Visible = false;

            incluirButton.Visible = true;
            alterarButton.Visible = true; 
            excluirButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = false;
            voltarButton.Visible = false;

            var clienteController = new ClienteDb();
            listaDataGridView.DataSource = clienteController.Listar();


            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.Columns["Id"].Width = 50;
            listaDataGridView.ReadOnly = true;
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            int clientes = listaDataGridView.Rows.Count;

            if (clientes == 0)
            {
                alterarButton.Visible = false;
            }
        }

        private void ExibirFicha()
        {
            listaDataGridView.Visible = false;
            fichaPanel.Visible = true;

            incluirButton.Visible = false;
            alterarButton.Visible = false;
            excluirButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            confirmarExcluirButton.Visible = false;
            confirmarIncluirButton.Visible = true;
            voltarButton.Visible = true;
        }

        private void LimparFicha ()
        {
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
        }

        private void confirmarIncluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDb();
            db.Incluir(cliente);
            ExibirGrid();
            LimparFicha();
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
            LimparFicha();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();

            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            nomeTextBox.Text = cliente.Nome;
            emailTextBox.Text = cliente.Email;
            telefoneTextBox.Text = cliente.Telefone;

            confirmarIncluirButton.Visible = false;
            confirmarAlterarButton.Visible = true;
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {

            var tabelaDados = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            int id = tabelaDados.Id;
            var cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = telefoneTextBox.Text;

            var db = new ClienteDb();
            db.Alterar(cliente);
            ExibirGrid();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;

            var db = new ClienteDb();
            db.Excluir(cliente.Id);
            ExibirGrid();
        }

        private void confirmarExcluirButton_Click(object sender, EventArgs e)
        {

        }
    }
}
