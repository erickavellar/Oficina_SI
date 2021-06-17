using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class ListaClienteForm : Form
    {
        UC_GestaoClientes _GestaoClientes;
        /// <summary>
        /// Aqui vou receber as informações do UC Gestao Cliente e inicializar logo no form quqando carrega
        /// </summary>
        /// <param name="cliente"></param>
        public ListaClienteForm(UC_GestaoClientes cliente)
        {
            InitializeComponent();
            _GestaoClientes = cliente;
            listBoxFiltro.DataSource = ClientesLista.clientes;
            listBoxFiltro.DisplayMember = "NomeCompleto";
        }
        /// <summary>
        /// Para fechar o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Onde eu faço o filtro dos cliente por nome, morada, codigo postal...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Nome")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Nome).ToList();
                listBoxFiltro.DisplayMember = "NomeCompleto2";
            }
            else if (cb_ordenar.Text == "Morada")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Morada).ToList();
                listBoxFiltro.DisplayMember = "MoradaCliente";
            }
            else if (cb_ordenar.Text == "Codigo Postal")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.CodPostal).ToList();
                listBoxFiltro.DisplayMember = "CodigoPostal";
            }
            else if (cb_ordenar.Text == "Localidade")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Localidade).ToList();
                listBoxFiltro.DisplayMember = "LocalidadeCliente";
            }
            else if (cb_ordenar.Text == "Telemovel")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Telemovel).ToList();
                listBoxFiltro.DisplayMember = "TelemovelCliente";
            }
            else if (cb_ordenar.Text == "Email")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Email).ToList();
                listBoxFiltro.DisplayMember = "EmailCliente";
            }
            else if (cb_ordenar.Text == "NIF")
            {
                listBoxFiltro.DataSource = ClientesLista.clientes.OrderBy(x => x.Nif).ToList();
                listBoxFiltro.DisplayMember = "NifCliente";
            }
        }

        
    }
}
