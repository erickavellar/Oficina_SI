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

    public partial class UC_ListaDeMarcacoes : UserControl
    {
        public UC_ListaDeMarcacoes()
        {
            InitializeComponent();
            MarcacaoLista.LerInfo();
            UsuarioLista.LerInfo();

            
        }

        /// <summary>
        /// Onde eu faço o filtro das marcações por nome, funcionario e email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (cb_ordenar.Text == "Nome")
            {
                listBoxFiltro.DataSource = MarcacaoLista.marcacoes.OrderBy(x => x.Nome).ToList();
                listBoxFiltro.DisplayMember = "Nome";
            }
            else if (cb_ordenar.Text == "Funcionario")
            {
                listBoxFiltro.DataSource = MarcacaoLista.marcacoes.OrderBy(x => x.Funcionario).ToList();
                listBoxFiltro.DisplayMember = "Funcionario";
            }
            else if (cb_ordenar.Text == "Email")
            {
                listBoxFiltro.DataSource = MarcacaoLista.marcacoes.OrderBy(x => x.email).ToList();
                listBoxFiltro.DisplayMember = "email";
            }
        }
        /// <summary>
        /// Aqui é onde busco todas as marcações criadas no form de marcação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxFiltro.DataSource = MarcacaoLista.marcacoes;
            listBoxFiltro.DisplayMember = "DescricaoCompleta";
        }
    }
}
