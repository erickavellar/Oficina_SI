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
    public partial class EditarClienteForm : Form
    {
        //Receber as informações do método editar do UC_GestaoCliente
        Cliente _editado;

        UC_GestaoClientes _GestaoClientes;

        public EditarClienteForm(UC_GestaoClientes gestaoClientes, Cliente editado)
        {
            InitializeComponent();

            _editado = editado;
            _GestaoClientes = gestaoClientes;

            //inicializar as informações contidas no outro form
            tb_id.Text = editado.Id_Cliente.ToString();
            tb_nome.Text = editado.Nome;
            tb_apelido.Text = editado.Apelido;
            tb_morada.Text = editado.Morada;
            tb_localidade.Text = editado.Localidade;
            tb_codPostal.Text = editado.CodPostal;
            tb_nif.Text = editado.Nif.ToString();
            tb_telemovel.Text = editado.Telemovel.ToString();
            tb_email.Text = editado.Email;
        }
        /// <summary>
        /// Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Salva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                _editado.Nome = tb_nome.Text;
                _editado.Apelido = tb_apelido.Text;
                _editado.Morada = tb_morada.Text;
                _editado.Localidade = tb_localidade.Text;
                _editado.CodPostal = tb_codPostal.Text;
                _editado.Nif = Convert.ToInt32(tb_nif.Text);
                _editado.Telemovel = Convert.ToInt32(tb_telemovel.Text);
                _editado.Email = tb_email.Text;
                ClientesLista.GravarFicheiro();
                _GestaoClientes.Constroi();
                
                
                this.Close();
            }
        }
        /// <summary>
        /// Valida as informações no form
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_nome.Text))
            {
                MessageBox.Show("Insira nome do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_apelido.Text))
            {
                MessageBox.Show("Insira apelido do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_morada.Text))
            {
                MessageBox.Show("Insira a morada do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_localidade.Text))
            {
                MessageBox.Show("Insira a localidade do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_codPostal.Text))
            {
                MessageBox.Show("Insira o código postal do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_codPostal.Text, "^\\d{4}-\\d{3}$"))
            {
                MessageBox.Show("Código Postal com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_nif.Text))
            {
                MessageBox.Show("Insira o NIF do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_nif.Text, @"\d{9}$"))
            {
                MessageBox.Show("NIF com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_telemovel.Text))
            {
                MessageBox.Show("Insira o telemóvel do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_telemovel.Text, @"^(91|92|93|96)\d{7}$"))
            {
                MessageBox.Show("Telemóvel com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email do cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_email.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira uma formatação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
    }
}
