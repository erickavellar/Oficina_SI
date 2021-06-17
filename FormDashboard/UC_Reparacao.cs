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
    public partial class UC_Reparacao : UserControl
    {
        //variavel para contar a reparação que for criada
        int contaReparacao = 1;
        public UC_Reparacao()
        {
            InitializeComponent();
            //Inicializo minhas listas que foram gravadas
            ReparacaoLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();

            InitList();
            InitListCliente();
            InitListVeiculo();
            InitListServico();
            InitListFuncionario();
            InitListServico2();

            tb_id.Text = contaReparacao.ToString();
            dt_inicio.MinDate = dt_inicio.MinDate;
            dt_fim.MinDate = dt_fim.MinDate;
        }
        /// <summary>
        /// Busco minha reparaçãqo na lista classe e conto e depois mostro
        /// </summary>
        public void InitList()
        {
            int count = 0;
            foreach (Reparacao reparacao in ReparacaoLista.reparacoes)
            {
                if (reparacao.Id >= count)
                {
                    count = reparacao.Id;
                }
            }
            contaReparacao = count + 1;

            listBoxReparacao.DataSource = null;

            listBoxReparacao.DataSource = ReparacaoLista.reparacoes;
            listBoxReparacao.DisplayMember = "InfoReparacao";
        }
        /// <summary>
        /// apresento a informação que quero da minha lista cliente
        /// </summary>
        public void InitListCliente()
        {
            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ClientesLista.clientes;
            cb_cliente.DisplayMember = "NomeCompleto2";
        }
        /// <summary>
        /// apresento a informação que quero da minha lista veiculo
        /// </summary>
        public void InitListVeiculo()
        {
            cb_veiculo.DataSource = VeiculosLista.veiculos.Where(x => x.Cliente == cb_cliente.Text).ToList();
            cb_veiculo.DisplayMember = "InfoVeiculo";
        }
        /// <summary>
        /// apresento a informação que quero da minha lista funcionario
        /// </summary>
        public void InitListFuncionario()
        {

            cb_funcionario.DataSource = null;

            cb_funcionario.DataSource = UsuarioLista.usuarios;
            cb_funcionario.DisplayMember = "InfoUsuario3";
        }
        /// <summary>
        /// apresento a informação que quero da minha lista de serviços
        /// </summary>
        public void InitListServico()
        {

            cb_servico.DataSource = null;

            cb_servico.DataSource = ServicoLista.reparacoes;
            cb_servico.DisplayMember = "InfoServico";
        }
        /// <summary>
        /// apresento a informação que quero da minha lista de serviços que será somente o valor 
        /// </summary>
        public void InitListServico2()
        {
            cb_precoCusto.DataSource = null;
            cb_precoCusto.DataSource = ServicoLista.reparacoes;
            cb_precoCusto.DisplayMember = "PrecoVenda";
        }
        /// <summary>
        /// Cancelo as informações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cb_cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            cb_precoCusto.Text = string.Empty;
            cb_servico.Text = string.Empty;
            dt_inicio.Text = string.Empty;
            dt_fim.Text = string.Empty;
        }
        /// <summary>
        /// Salvo o que for inserido de informação no form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                ReparacaoLista.GravarInfo(contaReparacao, cb_cliente.Text, cb_veiculo.Text, cb_funcionario.Text, Convert.ToDecimal(cb_precoCusto.Text), cb_servico.Text, Convert.ToDateTime(dt_inicio.Text), Convert.ToDateTime(dt_fim.Text));
                InitList();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_id.Text = contaReparacao.ToString();
            cb_cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            cb_precoCusto.Text = string.Empty;
            cb_servico.Text = string.Empty;  
            dt_inicio.Text = string.Empty;
            dt_fim.Text = string.Empty;
        }
        /// <summary>
        /// Onde faço as validações do que for inserido em cada campo do form
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cb_cliente.Text))
            {
                MessageBox.Show("Selecione o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_veiculo.Text))
            {
                MessageBox.Show("Selecione o veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_funcionario.Text))
            {
                MessageBox.Show("Selecione o funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_precoCusto.Text))
            {
                MessageBox.Show("Selecione o valor do serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_servico.Text))
            {
                MessageBox.Show("Insira o serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
                        
            if (string.IsNullOrEmpty(dt_inicio.Text))
            {
                MessageBox.Show("Insira a data de início do serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_inicio.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_fim.Text))
            {
                MessageBox.Show("Insira a data final do serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_fim.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Apaga as informações que eu salvei não desejadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Reparacao reparacaoAApagar = (Reparacao)listBoxReparacao.SelectedItem;

            Reparacao apagado = null;

            if (reparacaoAApagar != null)
            {
                foreach (Reparacao reparacao in ReparacaoLista.reparacoes)
                {
                    if (reparacaoAApagar.Id == reparacao.Id)
                    {
                        apagado = reparacao;
                    }
                }


                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.InfoReparacao}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        ReparacaoLista.reparacoes.Remove(apagado);
                        ReparacaoLista.GravarFicheiro();
                        InitList();
                    }
                }
            }
        }
        /// <summary>
        /// Busco primeiro se o item selecionado é nulo e depois busco ele na lista e por fim faço a passagem do selecionado para o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Reparacao reparacaoAEditar = (Reparacao)listBoxReparacao.SelectedItem;

            Reparacao editado = null;

            if (reparacaoAEditar != null)
            {

                foreach (Reparacao reparacao in ReparacaoLista.reparacoes)
                {
                    if (reparacaoAEditar.Id == reparacao.Id)
                    {
                        editado = reparacao;
                    }
                }

                EditarReparacaoForm editarReparacaoForm = new EditarReparacaoForm(this, editado);
                editarReparacaoForm.Show();
            }
        }
        /// <summary>
        /// Inicializa a combobox ao selecionar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListVeiculo();
        }

        private void cb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_servico_SelectedValueChanged(object sender, EventArgs e)
        {
            InitListServico2();
        }
    }
}
