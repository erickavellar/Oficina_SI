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
    public partial class UC_GestaoClientes : UserControl
    {
        
        //variavel para contar cliente
        int contaClientes = 1;
       
        public UC_GestaoClientes()
        {
            

            InitializeComponent();

            
            ClientesLista.LerInfo();            
            Constroi();
            tb_id.Text = contaClientes.ToString();
        }
        /// <summary>
        /// Inicializar a lista
        /// </summary>
        public void Constroi()
        {
            int count = 0;
            foreach (Cliente cliente in ClientesLista.clientes)
            {
                if (cliente.Id_Cliente >= count)
                {
                    count = cliente.Id_Cliente;
                }
            }
            contaClientes = count + 1;

            ClientesListBox.DataSource = null;
            ClientesListBox.DataSource = ClientesLista.clientes;
            ClientesListBox.DisplayMember = "NomeCompleto";
            
        }
        /// <summary>
        /// Salvar as informações do cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            if (ValidaForm())
            {
                ClientesLista.GravarInfo(contaClientes, tb_nome.Text, tb_apelido.Text, tb_morada.Text, tb_codPostal.Text, tb_localidade.Text, Convert.ToInt32(tb_telemovel.Text), tb_email.Text, Convert.ToInt32(tb_nif.Text));
                Constroi();                
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_id.Text = contaClientes.ToString();
            tb_nome.Text = string.Empty;
            tb_apelido.Text = string.Empty;
            tb_morada.Text = string.Empty;
            tb_localidade.Text = string.Empty;
            tb_codPostal.Text = string.Empty;
            tb_nif.Text = string.Empty;
            tb_telemovel.Text = string.Empty;
            tb_email.Text = string.Empty;
        }
         /// <summary>
         /// Validar informações no form
         /// </summary>
         /// <returns>Se as informações são nulas ou bem formatadas</returns>
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
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = string.Empty;
            tb_apelido.Text = string.Empty;
            tb_morada.Text = string.Empty;
            tb_localidade.Text = string.Empty;
            tb_nif.Text = string.Empty;
            tb_telemovel.Text = string.Empty;
            tb_codPostal.Text = string.Empty;
            tb_email.Text = string.Empty;
        }
        /// <summary>
        /// Apagar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_apagar_Click(object sender, EventArgs e)
        {
            Cliente clienteAApagar = (Cliente)ClientesListBox.SelectedItem;

            Cliente apagado = null;

            if (clienteAApagar != null)
            {
                foreach (Cliente cliente in ClientesLista.clientes)
                {
                    if (clienteAApagar.Id_Cliente == cliente.Id_Cliente)
                    {
                        apagado = cliente;
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
                        ClientesLista.clientes.Remove(apagado);
                        ClientesLista.GravarFicheiro();
                        Constroi();
                    }
                }
            }
        }
        /// <summary>
        /// Editar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_editar_Click(object sender, EventArgs e)
        {
            Cliente clienteAEditar = (Cliente)ClientesListBox.SelectedItem;
            
            Cliente editado = null;
            
            if (clienteAEditar != null)
            {

                foreach (Cliente cliente in ClientesLista.clientes)
                {
                    if (clienteAEditar.Id_Cliente == cliente.Id_Cliente)
                    {
                        editado = cliente;
                    }
                }
                
                EditarClienteForm editarClienteForm = new EditarClienteForm(this, editado);
                editarClienteForm.Show();
            }
        }
        /// <summary>
        /// Passagem para um form de listar os clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listar_Click(object sender, EventArgs e)
        {


            ListaClienteForm listaClienteForm = new ListaClienteForm(this);
            listaClienteForm.Show();
        }
    }
}
