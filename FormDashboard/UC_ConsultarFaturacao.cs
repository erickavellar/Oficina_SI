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
    public partial class UC_ConsultarFaturacao : UserControl
    {
        public UC_ConsultarFaturacao()
        {
            InitializeComponent();
            FaturacaoLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Cliente")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Cliente).ToList();
                listBoxFiltro.DisplayMember = "ClienteFatura";
            }
            else if (cb_ordenar.Text == "Veiculo")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Veiculo).ToList();
                listBoxFiltro.DisplayMember = "VeiculoFatura";
            }
            else if (cb_ordenar.Text == "Serviço")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Servico).ToList();
                listBoxFiltro.DisplayMember = "ServicoFatura";
            }
            else if (cb_ordenar.Text == "Funcionário")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Funcionario).ToList();
                listBoxFiltro.DisplayMember = "FuncionarioFatura";
            }
            else if (cb_ordenar.Text == "Tipo de Pagamento")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.TipoPagamento).ToList();
                listBoxFiltro.DisplayMember = "TipoPagFatura";
            }
            else if (cb_ordenar.Text == "Preço de Custo")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.PrecoCusto).ToList();
                listBoxFiltro.DisplayMember = "PrecoCustoFatura";
            }
            else if (cb_ordenar.Text == "Total a Pagar")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.TotalAPagar).ToList();
                listBoxFiltro.DisplayMember = "TotalPagar";
            }
            else if (cb_ordenar.Text == "Data de Emissão")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Emissao).ToList();
                listBoxFiltro.DisplayMember = "DataEmissao";
            }
            else if (cb_ordenar.Text == "Data de Vencimento")
            {
                listBoxFiltro.DataSource = FaturacaoLista.faturacoes.OrderBy(x => x.Vencimento).ToList();
                listBoxFiltro.DisplayMember = "DataVencimento";
            }
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            listBoxFiltro.DataSource = FaturacaoLista.faturacoes;
            listBoxFiltro.DisplayMember = "InfoFaturacao2";
        }
    }
}
