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
    public partial class EditarMarcacaoForm : Form
    {
        Marcacao _editado;
        UC_IncluirMarcacao _IncluirMarcacao;

        public EditarMarcacaoForm(UC_IncluirMarcacao incluirMarcacao, Marcacao editado)
        {
            InitializeComponent();

            InitListFuncionario();

            _editado = editado;
            _IncluirMarcacao = incluirMarcacao;

            tb_idMarcacao.Text = editado.Id_Marcacao.ToString();
            tb_nome.Text = editado.NomeCompleto;
            cb_funcionario.Text = editado.Usuario;
            dt_dataInicio.Text = editado.Data_Agendada.ToString();
            dt_hora.Text = editado.Hora.ToString();
            dt_dataFim.Text = editado.Data_Expira.ToString();
            dt_dataAlerta.Text = editado.Data_Alerta.ToString();
            tb_email.Text = editado.Email;
            tb_assunto.Text = editado.Assunto;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.NomeCompleto = tb_nome.Text;
                _editado.Usuario = cb_funcionario.Text.ToString();
                _editado.Data_Agendada = Convert.ToDateTime(dt_dataInicio.Text);
                _editado.Hora = Convert.ToDateTime(dt_hora.Text);
                _editado.Data_Expira = Convert.ToDateTime(dt_dataFim.Text);
                _editado.Data_Alerta = Convert.ToDateTime(dt_dataAlerta.Text);
                _editado.Email = tb_email.Text;
                _editado.Assunto = tb_assunto.Text;
                               
                MarcacaoLista.GravarFicheiro();
                _IncluirMarcacao.InitList();
                this.Close();
            }
        }

        public void InitListFuncionario()
        {

            cb_funcionario.DataSource = null;

            cb_funcionario.DataSource = UsuarioLista.usuarios;
            cb_funcionario.DisplayMember = "InfoUsuario2";
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_idMarcacao.Text))
            {
                MessageBox.Show("Insira o funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_nome.Text))
            {
                MessageBox.Show("Insira o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_dataInicio.Text))
            {
                MessageBox.Show("Insira a data de início", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_dataInicio.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_hora.Text))
            {
                MessageBox.Show("Insira a hora da marcação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_hora.Text) < DateTime.Now)
            {
                MessageBox.Show("Insira um horário igual ou superior de agora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_dataFim.Text))
            {
                MessageBox.Show("Insira a data de fim", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_dataFim.Text) <= DateTime.Today)
            {
                MessageBox.Show("Insira uma data final superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_dataAlerta.Text))
            {
                MessageBox.Show("Insira a data que está a criar o alerta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_dataAlerta.Text) < DateTime.Today)
            {
                MessageBox.Show("A data de alerta só é permitido ser igual a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_dataAlerta.Text) > DateTime.Today)
            {
                MessageBox.Show("A data de alerta só é permitido ser igual a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_email.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira uma formatação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_assunto.Text))
            {
                MessageBox.Show("Insira o assunto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
