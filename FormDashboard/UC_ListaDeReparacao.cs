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
    public partial class UC_ListaDeReparacao : UserControl
    {
        public UC_ListaDeReparacao()
        {
            InitializeComponent();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Cliente")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Cliente).ToList();
                listBoxFiltro.DisplayMember = "ClienteReparacao";
            }
            else if (cb_ordenar.Text == "Veiculo")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Veiculo).ToList();
                listBoxFiltro.DisplayMember = "VeiculoReparacao";
            }
            else if (cb_ordenar.Text == "Funcionario")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Funcionario).ToList();
                listBoxFiltro.DisplayMember = "FuncionarioReparacao";
            }
            else if (cb_ordenar.Text == "Servico")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Servico).ToList();
                listBoxFiltro.DisplayMember = "ServicoReparacao";
            }
            else if (cb_ordenar.Text == "Data de Inicio")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Inicio).ToList();
                listBoxFiltro.DisplayMember = "DataInicio";
            }
            else if (cb_ordenar.Text == "Data de Fim")
            {
                listBoxFiltro.DataSource = ReparacaoLista.reparacoes.OrderBy(x => x.Final).ToList();
                listBoxFiltro.DisplayMember = "DataFim";
            }

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            listBoxFiltro.DataSource = ReparacaoLista.reparacoes;
            listBoxFiltro.DisplayMember = "InfoReparacao";
        }
    }
}
