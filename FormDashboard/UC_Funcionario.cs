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
    public partial class UC_Funcionario : UserControl
    {
        int contaFuncionarios = 1;

        public UC_Funcionario()
        {
            InitializeComponent();

            UsuarioLista.LerInfo();
            InitList();
            tb_id.Text = contaFuncionarios.ToString();
        }

        public void InitList()
        {
            int count = 0;
            foreach (Usuario usuario in UsuarioLista.usuarios)
            {
                if (usuario.Id_Usuario >= count)
                {
                    count = usuario.Id_Usuario;
                }
            }
            contaFuncionarios = count + 1;

            FuncionarioListBox.DataSource = null;
            FuncionarioListBox.DataSource = UsuarioLista.usuarios;
            FuncionarioListBox.DisplayMember = "InfoUsuario";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                UsuarioLista.GravarInfo(contaFuncionarios, tb_nomeUser.Text, tb_apelidoUser.Text, cb_departamento.Text, tb_morada.Text, tb_localidade.Text, tb_cp.Text, Convert.ToInt32(tb_nif.Text), Convert.ToInt32(tb_telemovel.Text),tb_email.Text, tb_pw.Text, tb_confEmail.Text);
                InitList();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_id.Text = contaFuncionarios.ToString();
            tb_nomeUser.Text = string.Empty;
            tb_apelidoUser.Text = string.Empty;
            cb_departamento.Text = string.Empty;
            tb_morada.Text = string.Empty;
            tb_localidade.Text = string.Empty;
            tb_cp.Text = string.Empty;
            tb_nif.Text = string.Empty;
            tb_telemovel.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_pw.Text = string.Empty;
            tb_confEmail.Text = string.Empty;
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
            else if (!Regex.IsMatch(tb_nif.Text, @"\d{9}$"))
            {
                MessageBox.Show("NIF com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_telemovel.Text))
            {
                MessageBox.Show("Insira o telemóvel do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_telemovel.Text, @"^(91|92|93|96)\d{7}$"))
            {
                MessageBox.Show("Telemóvel com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_email.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (!Regex.IsMatch(tb_confEmail.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nomeUser.Text = string.Empty;
            tb_apelidoUser.Text = string.Empty;
            cb_departamento.Text = string.Empty;
            tb_morada.Text = string.Empty;
            tb_localidade.Text = string.Empty;
            tb_cp.Text = string.Empty;
            tb_nif.Text = string.Empty;
            tb_telemovel.Text = string.Empty;            
            tb_email.Text = string.Empty;
            tb_pw.Text = string.Empty;
            tb_confEmail.Text = string.Empty;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Usuario usuarioAApagar = (Usuario)FuncionarioListBox.SelectedItem;

            Usuario apagado = null;

            if (usuarioAApagar != null)
            {
                foreach (Usuario usuario in UsuarioLista.usuarios)
                {
                    if (usuarioAApagar.Id_Usuario == usuario.Id_Usuario)
                    {
                        apagado = usuario;
                    }
                }

                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.InfoUsuario}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        UsuarioLista.usuarios.Remove(apagado);
                        UsuarioLista.GravarFicheiro();
                        InitList();
                    }
                }
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Usuario usuarioAEditar = (Usuario)FuncionarioListBox.SelectedItem;

            Usuario editado = null;

            if (usuarioAEditar != null)
            {

                foreach (Usuario usuario in UsuarioLista.usuarios)
                {
                    if (usuarioAEditar.Id_Usuario == usuario.Id_Usuario)
                    {
                        editado = usuario;
                    }
                }

                EditarFuncionarioForm editarFuncionarioForm = new EditarFuncionarioForm(this, editado);
                editarFuncionarioForm.Show();
            }
        }
    }
}
