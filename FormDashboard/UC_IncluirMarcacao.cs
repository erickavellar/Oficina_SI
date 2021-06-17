using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class UC_IncluirMarcacao : UserControl
    {
        //variavel para contar as marcações
        int contaMarcacao = 1;
        public UC_IncluirMarcacao()
        {
            InitializeComponent();

            MarcacaoLista.LerInfo();
            UsuarioLista.LerInfo();

            InitList();
            InitListFuncionario();

            text_idMarcacao.Text = contaMarcacao.ToString();
            dateMarcacao.MinDate = DateTime.Now;
            dateFim.MinDate = dateFim.MinDate;
            dateAlerta.MinDate = dateMarcacao.MinDate;
        }
        /// <summary>
        /// Inicializa as informações criadas
        /// </summary>
        public void InitList()
        {
            int count = 0;
            foreach (Marcacao marcacao in MarcacaoLista.marcacoes)
            {
                if (marcacao.Id_Marcacao >= count)
                {
                    count = marcacao.Id_Marcacao;
                }
            }
            contaMarcacao = count + 1;//conto as marcações

            ListBoxMarcacao.DataSource = null;

            ListBoxMarcacao.DataSource = MarcacaoLista.marcacoes;
            ListBoxMarcacao.DisplayMember = "DescricaoCompleta";

        }
        /// <summary>
        /// Busco o funcionario na classe na marcação
        /// </summary>
        public void InitListFuncionario()
        {

            cb_func.DataSource = null;

            cb_func.DataSource = UsuarioLista.usuarios;
            cb_func.DisplayMember = "InfoUsuario2";
        }
        /// <summary>
        /// Valida todas as informaçõe no form
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cb_func.Text))
            {
                MessageBox.Show("Insira o funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(textCliente.Text))
            {
                MessageBox.Show("Insira o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dateMarcacao.Text))
            {
                MessageBox.Show("Insira a data de início", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dateMarcacao.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dateHora.Text))
            {
                MessageBox.Show("Insira a hora da marcação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dateHora.Text) < DateTime.Now)
            {
                MessageBox.Show("Insira um horário igual ou superior de agora.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dateFim.Text))
            {
                MessageBox.Show("Insira a data de fim", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dateFim.Text) <= DateTime.Today)
            {
                MessageBox.Show("Insira uma data final superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dateAlerta.Text))
            {
                MessageBox.Show("Insira a data que está a criar o alerta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dateAlerta.Text) < DateTime.Today)
            {
                MessageBox.Show("A data de alerta só é permitido ser igual a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dateAlerta.Text) > DateTime.Today)
            {
                MessageBox.Show("A data de alerta só é permitido ser igual a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(textBoxEmail.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira uma formatação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(textBoxAssunto.Text))
            {
                MessageBox.Show("Insira o assunto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        /// <summary>
        /// salvo as informa inseridas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                MarcacaoLista.GravarInfo(contaMarcacao, textCliente.Text, cb_func.Text, Convert.ToDateTime(dateMarcacao.Text), Convert.ToDateTime(dateHora.Text), Convert.ToDateTime(dateFim.Text), Convert.ToDateTime(dateAlerta.Text), textBoxEmail.Text, textBoxAssunto.Text);
                InitList();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            text_idMarcacao.Text = contaMarcacao.ToString();
            textCliente.Text = string.Empty;
            cb_func.Text = string.Empty;
            dateMarcacao.Text = string.Empty;
            dateHora.Text = string.Empty;
            dateFim.Text = string.Empty;
            dateAlerta.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxAssunto.Text = string.Empty;
        }
        /// <summary>
        /// cancelo as informações inseridas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textCliente.Text = string.Empty;
            cb_func.ResetText();
            dateMarcacao.ResetText();
            dateHora.ResetText();
            dateFim.ResetText();
            dateAlerta.ResetText();
            textBoxEmail.Text = string.Empty;
            textBoxAssunto.Text = string.Empty;
        }
        /// <summary>
        /// apago as informações selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApagar_Click(object sender, EventArgs e)
        {
            Marcacao marcacaoAApagar = (Marcacao)ListBoxMarcacao.SelectedItem;

            Marcacao apagado = null;

            if (marcacaoAApagar != null)
            {
                foreach (Marcacao marcacao in MarcacaoLista.marcacoes)
                {
                    if (marcacaoAApagar.text_idMarcacao == marcacao.text_idMarcacao)
                    {
                        apagado = marcacao;
                    }
                }


                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.DescricaoCompleta}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        MarcacaoLista.marcacoes.Remove(apagado);
                        MarcacaoLista.GravarFicheiro();
                        InitList();
                    }
                }
            }
        }

        
        /// <summary>
        /// envio por email a marcação criada pelo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (SmtpClient cliente = new SmtpClient("usuario.dominio.com"))
            {
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("erick.merhy.avellar@formandos.cinel.pt");
                Message.To.Add(textBoxEmail.Text);
                Message.Body = $"Prezado Sr.(a) {textCliente.Text},\n\n" +
                $"Foi realizado uma marcação para o dia {dateMarcacao.Text} as {dateHora.Text}.\n\n" +
                $"Agradecemos por escolher a WS Workshop System.\n\n" +
                "Atenciosamente\n\n" +
                "WS Workshop System";
                Message.Subject = $"{textBoxAssunto.Text}";

                cliente.Host = "smtp.office365.com";
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential("erick.merhy.avellar@formandos.cinel.pt", "Programador2021");
                cliente.EnableSsl = true;
                cliente.Send(Message);
                MessageBox.Show("Foi enviado as informações para o seu emaiil !");

            }
        }
        /// <summary>
        /// faço a passagem de editar para o form editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Marcacao marcacaoAEditar = (Marcacao)ListBoxMarcacao.SelectedItem;

            Marcacao editado = null;

            if (marcacaoAEditar != null)
            {

                foreach (Marcacao marcacao in MarcacaoLista.marcacoes)
                {
                    if (marcacaoAEditar.text_idMarcacao == marcacao.text_idMarcacao)
                    {
                        editado = marcacao;
                    }
                }

                EditarMarcacaoForm editarMarcacaoForm = new EditarMarcacaoForm(this, editado);
                editarMarcacaoForm.Show();
            }
        }
    }
}
