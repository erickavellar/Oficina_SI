using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class UC_GestaoReparacao : UserControl
    {

        //variavel para contar o serviço
        int contaReparacoes = 1;

        public UC_GestaoReparacao()
        {
            
            InitializeComponent();
            ServicoLista.LerInfo();
            InitLista();
            tb_codReparacao.Text = contaReparacoes.ToString();
        }
        /// <summary>
        /// Inicializa a lista
        /// </summary>
        public void InitLista()
        {
            int count = 0;
            foreach (Servico reparacao in ServicoLista.reparacoes)
            {
                if (reparacao.Cod_reparacao >= count)
                {
                    count = reparacao.Cod_reparacao;
                }
            }
            contaReparacoes = count + 1;
            ServicosListBox.DataSource = null;
            ServicosListBox.DataSource = ServicoLista.reparacoes;
            ServicosListBox.DisplayMember = "NomeCompleto";
        }

        /// <summary>
        /// Salva as informaçoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            if (ValidaForm())
            {
                ServicoLista.GravarInfo(contaReparacoes, tb_descricao.Text, Convert.ToDecimal(tb_precoCusto.Text), Convert.ToDecimal(tb_precoVenda.Text));
                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_codReparacao.Text = contaReparacoes.ToString();
            tb_descricao.Text = string.Empty;
            tb_precoCusto.Text = string.Empty;
            tb_precoVenda.Text = string.Empty;
            
        }

        /// <summary>
        /// Validar informações no form
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_descricao.Text))
            {
                MessageBox.Show("Insira a descrição do serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_precoCusto.Text))
            {
                MessageBox.Show("Insira o preço de custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_precoCusto.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("O preço de custo está com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_precoVenda.Text))
            {
                MessageBox.Show("Insira o preço de venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_precoVenda.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("O preço de venda está com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_descricao.Text = string.Empty;
            tb_precoCusto.Text = string.Empty;
            tb_precoVenda.Text = string.Empty;
        }
        /// <summary>
        /// Apagar o serviço salvo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Servico reparacaoAApagar = (Servico)ServicosListBox.SelectedItem;

            Servico apagado = null;

            if (reparacaoAApagar != null)
            {
                foreach (Servico reparacao in ServicoLista.reparacoes)
                {
                    if (reparacaoAApagar.Cod_reparacao == reparacao.Cod_reparacao)
                    {
                        apagado = reparacao;
                    }
                }


                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.NomeCompleto}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        ServicoLista.reparacoes.Remove(apagado);
                        ServicoLista.GravarFicheiro();
                        InitLista();
                    }
                }
            }
        }
        /// <summary>
        /// Passa a informação selecionada para o form editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Servico reparacaoAEditar = (Servico)ServicosListBox.SelectedItem;

            Servico editado = null;

            if (reparacaoAEditar != null)
            {

                foreach (Servico reparacao in ServicoLista.reparacoes)
                {
                    if (reparacaoAEditar.Cod_reparacao == reparacao.Cod_reparacao)
                    {
                        editado = reparacao;
                    }
                }

                EditarServicoForm editarReparacaoForm = new EditarServicoForm(this, editado);
                editarReparacaoForm.Show();
            }
        }
        /// <summary>
        /// Passagem para um form de listar dos serviços
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaReparacaoForm listaReparacaoForm = new ListaReparacaoForm(this);
            listaReparacaoForm.Show();
        }
    }
}
