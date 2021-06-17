using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Biblioteca;

namespace FormLogin
{
    public partial class FormCriarUser : Form
    {
        int contaFuncionarios = 1;

        public FormCriarUser()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                UsuarioLista.GravarInfo(contaFuncionarios, tb_nomeUser.Text, tb_apelidoUser.Text, cb_departamento.Text, tb_morada.Text, tb_localidade.Text, tb_cp.Text, Convert.ToInt32(tb_nif.Text), Convert.ToInt32(tb_telemovel.Text), tb_email.Text, tb_pw.Text, tb_confEmail.Text);
                InitList();
                using (SmtpClient usuario = new SmtpClient("usuario.dominio.com"))
                {
                    MailMessage Message = new MailMessage();
                    Message.From = new MailAddress("erick.merhy.avellar@formandos.cinel.pt");
                    Message.To.Add(tb_confEmail.Text);
                    Message.Body = $"Utilizador: {tb_confEmail.Text}\n Password: {tb_pw.Text}";
                    Message.Subject = "Ativação de conta";

                    usuario.Host = "smtp.office365.com";
                    usuario.Port = 587;
                    usuario.Credentials = new System.Net.NetworkCredential("erick.merhy.avellar@formandos.cinel.pt", "Programador2021");
                    usuario.EnableSsl = true;
                    usuario.Send(Message);
                    MessageBox.Show("Foi enviado as informações para o seu emaiil !");
                    this.Dispose();
                }
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
                MessageBox.Show("Insira nome do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_apelidoUser.Text))
            {
                MessageBox.Show("Insira apelido do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_departamento.Text))
            {
                MessageBox.Show("Insira departamento do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_morada.Text))
            {
                MessageBox.Show("Insira a morada do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_localidade.Text))
            {
                MessageBox.Show("Insira a localidade do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_cp.Text))
            {
                MessageBox.Show("Insira o código postal do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_cp.Text, "^\\d{4}-\\d{3}$"))
            {
                MessageBox.Show("Código Postal com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_nif.Text))
            {
                MessageBox.Show("Insira o NIF do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_nif.Text, @"\d{9}$"))
            {
                MessageBox.Show("NIF com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_telemovel.Text))
            {
                MessageBox.Show("Insira o telemóvel do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_telemovel.Text, @"^(91|92|93|96)\d{7}$"))
            {
                MessageBox.Show("Telemóvel com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_email.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_pw.Text))
            {
                MessageBox.Show("Insira o email do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_confEmail.Text))
            {
                MessageBox.Show("Insira o email do usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_confEmail.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
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

        
    }
}
