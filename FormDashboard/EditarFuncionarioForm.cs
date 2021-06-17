using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class EditarFuncionarioForm : Form
    {
        Usuario _editado;

        UC_Funcionario _Funcionarios;

        public EditarFuncionarioForm(UC_Funcionario funcionarios, Usuario editado)
        {
            InitializeComponent();

            _editado = editado;
            _Funcionarios = funcionarios;


            tb_id.Text = editado.Id_Usuario.ToString();
            tb_nomeUser.Text = editado.Nome;
            tb_apelidoUser.Text = editado.Apelido;
            cb_departamento.Text = editado.Departamento;
            tb_morada.Text = editado.Morada;
            tb_localidade.Text = editado.Localidade;
            tb_cp.Text = editado.CodPostal;
            tb_nif.Text = editado.Nif.ToString();
            tb_telemovel.Text = editado.Telemovel.ToString();
            tb_email.Text = editado.Email;
            tb_pw.Text = editado.Password;
            tb_confEmail.Text = editado.ConfirmacaoEmail;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                _editado.Nome = tb_nomeUser.Text;
                _editado.Apelido = tb_apelidoUser.Text;
                _editado.Departamento = cb_departamento.Text;
                _editado.Morada = tb_morada.Text;
                _editado.Localidade = tb_localidade.Text;
                _editado.CodPostal = tb_cp.Text;
                _editado.Nif = Convert.ToInt32(tb_nif.Text);
                _editado.Telemovel = Convert.ToInt32(tb_telemovel.Text);
                _editado.Email = tb_email.Text;
                _editado.Password = tb_pw.Text;
                _editado.ConfirmacaoEmail = tb_confEmail.Text;
                UsuarioLista.GravarFicheiro();
                _Funcionarios.InitList();


                this.Close();
            }
        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_nomeUser.Text))
            {
                MessageBox.Show("Insira nome do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_apelidoUser.Text))
            {
                MessageBox.Show("Insira apelido do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_departamento.Text))
            {
                MessageBox.Show("Insira o departamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_morada.Text))
            {
                MessageBox.Show("Insira a morada do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_localidade.Text))
            {
                MessageBox.Show("Insira a localidade do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_cp.Text))
            {
                MessageBox.Show("Insira o código postal do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_nif.Text))
            {
                MessageBox.Show("Insira o NIF do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_telemovel.Text))
            {
                MessageBox.Show("Insira o telemóvel do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_pw.Text))
            {
                MessageBox.Show("Insira a password", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_confEmail.Text))
            {
                MessageBox.Show("Insira a confirmação de email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
