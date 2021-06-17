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
    public partial class UC_BuscarOrcamentos : UserControl
    {
        public UC_BuscarOrcamentos()
        {
            InitializeComponent();
            OrcamentosLista.LerInfo();
            ServicoLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            UsuarioLista.LerInfo();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            listBoxFiltro.DataSource = OrcamentosLista.orcamentos;
            listBoxFiltro.DisplayMember = "InfoCompleto";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Cliente")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Cliente).ToList();
                listBoxFiltro.DisplayMember = "ClienteOrcamento";
            }
            else if (cb_ordenar.Text == "Veiculo")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Veiculo).ToList();
                listBoxFiltro.DisplayMember = "VeiculoOrcamento";
            }
            else if (cb_ordenar.Text == "Servico")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Servico).ToList();
                listBoxFiltro.DisplayMember = "ServicoOrcamento";
            }
            else if (cb_ordenar.Text == "Funcionario")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Funcionario).ToList();
                listBoxFiltro.DisplayMember = "FuncionarioOrcamento";
            }
            else if (cb_ordenar.Text == "Data Emissao")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Data_Emissao).ToList();
                listBoxFiltro.DisplayMember = "EmissaoOrcamento";
            }
            else if (cb_ordenar.Text == "Validade")
            {
                listBoxFiltro.DataSource = OrcamentosLista.orcamentos.OrderBy(x => x.Validade).ToList();
                listBoxFiltro.DisplayMember = "ValidadeOrcamento";
            }
        }
    }
}
