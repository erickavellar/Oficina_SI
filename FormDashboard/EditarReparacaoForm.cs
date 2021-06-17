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
    public partial class EditarReparacaoForm : Form
    {
        Reparacao _editado;
        UC_Reparacao _Reparacao;
        public EditarReparacaoForm(UC_Reparacao reparacao, Reparacao editado)
        {
            InitializeComponent();

            InitListCliente();
            InitListVeiculo();
            InitListServico();
            InitListFuncionario();
            InitListServico2();

            _editado = editado;
            _Reparacao = reparacao;

            tb_id.Text = editado.Id.ToString();
            cb_cliente.Text = editado.Cliente;
            cb_veiculo.Text = editado.Veiculo;
            cb_funcionario.Text = editado.Funcionario;
            cb_servico.Text = editado.Servico;
            dt_inicio.Text = editado.Inicio.ToString();
            dt_fim.Text = editado.Final.ToString();
        }

        public void InitListCliente()
        {
            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ClientesLista.clientes;
            cb_cliente.DisplayMember = "NomeCompleto2";
        }

        public void InitListVeiculo()
        {
            cb_veiculo.DataSource = VeiculosLista.veiculos.Where(x => x.Cliente == cb_cliente.Text).ToList();
            cb_veiculo.DisplayMember = "InfoVeiculo";
        }

        public void InitListFuncionario()
        {

            cb_funcionario.DataSource = null;

            cb_funcionario.DataSource = UsuarioLista.usuarios;
            cb_funcionario.DisplayMember = "InfoUsuario3";
        }

        public void InitListServico()
        {

            cb_servico.DataSource = null;

            cb_servico.DataSource = ServicoLista.reparacoes;
            cb_servico.DisplayMember = "InfoServico";
        }

        public void InitListServico2()
        {

            cb_precoCusto.DataSource = null;

            cb_precoCusto.DataSource = ServicoLista.reparacoes;
            cb_precoCusto.DisplayMember = "PrecoVenda";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Cliente = cb_cliente.Text.ToString();
                _editado.Veiculo = cb_veiculo.Text;
                _editado.Servico = cb_servico.Text;
                _editado.Funcionario = cb_funcionario.Text;
                _editado.PrecoVenda = Convert.ToDecimal(cb_precoCusto.Text);
                _editado.Inicio = Convert.ToDateTime(dt_inicio.Text);
                _editado.Final = Convert.ToDateTime(dt_fim.Text);
                ReparacaoLista.GravarFicheiro();
                _Reparacao.InitList();
                this.Close();
            }
        }

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
                MessageBox.Show("Selecione o serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListVeiculo();
        }
    }
}
