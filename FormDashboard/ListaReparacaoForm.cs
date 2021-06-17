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
    public partial class ListaReparacaoForm : Form
    {
        UC_GestaoReparacao _GestaoReparacao;

        public ListaReparacaoForm(UC_GestaoReparacao reparacao)
        {
            InitializeComponent();
            _GestaoReparacao = reparacao;
            listBoxFiltro.DataSource = ServicoLista.reparacoes;
            listBoxFiltro.DisplayMember = "NomeCompleto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// Busco as informações geradas na Reparação e faço o filtro para cada informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Descricao")
            {
                listBoxFiltro.DataSource = ServicoLista.reparacoes.OrderBy(x => x.Descricao).ToList();
                listBoxFiltro.DisplayMember = "DescricaoServico";
            }
            else if (cb_ordenar.Text == "Preco Custo")
            {
                listBoxFiltro.DataSource = ServicoLista.reparacoes.OrderBy(x => x.Preco_Custo).ToList();
                listBoxFiltro.DisplayMember = "PrecoCustoServico";
            }
            else if (cb_ordenar.Text == "Preco Venda")
            {
                listBoxFiltro.DataSource = ServicoLista.reparacoes.OrderBy(x => x.Preco_Venda).ToList();
                listBoxFiltro.DisplayMember = "PrecoVenda";
            }
        }
    }
}
