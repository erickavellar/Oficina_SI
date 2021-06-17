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
    public partial class ListaVeiculoForm : Form
    {
        UC_GestaoVeiculos _GestaoVeiculos;
        /// <summary>
        /// Aqui vou receber as informações do UC Gestao Veiculo e inicializar logo no form quqando carrega
        /// </summary>
        /// <param name="veiculo"></param>
        public ListaVeiculoForm(UC_GestaoVeiculos veiculo)
        {
            InitializeComponent();
            _GestaoVeiculos = veiculo;
            listBoxFiltro.DataSource = VeiculosLista.veiculos;
            listBoxFiltro.DisplayMember = "NomeCompleto";
        }
        /// <summary>
        /// Fecha o form
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
            if (cb_ordenar.Text == "Cliente")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Cliente).ToList();
                listBoxFiltro.DisplayMember = "ClienteVeiculo";
            }
            else if (cb_ordenar.Text == "Matricula")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Matricula).ToList();
                listBoxFiltro.DisplayMember = "Matricula";
            }
            else if (cb_ordenar.Text == "Categoria")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Categoria).ToList();
                listBoxFiltro.DisplayMember = "CategoriaVeiculo";
            }
            else if (cb_ordenar.Text == "Marca")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Marca).ToList();
                listBoxFiltro.DisplayMember = "MarcaVeiculo";
            }
            else if (cb_ordenar.Text == "Modelo")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Modelo).ToList();
                listBoxFiltro.DisplayMember = "ModeloVeiculo";
            }
            else if (cb_ordenar.Text == "Ano")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Ano).ToList();
                listBoxFiltro.DisplayMember = "AnoVeiculo";
            }
            else if (cb_ordenar.Text == "Cor")
            {
                listBoxFiltro.DataSource = VeiculosLista.veiculos.OrderBy(x => x.Cor).ToList();
                listBoxFiltro.DisplayMember = "CorVeiculo";
            }
        }
    }
}
