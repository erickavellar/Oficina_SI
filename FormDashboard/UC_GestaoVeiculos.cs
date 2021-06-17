using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class UC_GestaoVeiculos : UserControl
    {
        //variavel contar os veiculos
        int contaVeiculos = 1;

        public UC_GestaoVeiculos()
        {
            InitializeComponent();
            VeiculosLista.LerInfo();//inicializo as informações gravadas da classe VeiculoLista
            Constroi();
            Constroi2();
            tb_id.Text = contaVeiculos.ToString();
        }
        /// <summary>
        /// Inicializa a lista do veiculo
        /// </summary>
        public void Constroi()
        {
            int count = 0;
            foreach (Veiculo veiculo in VeiculosLista.veiculos)
            {
                if (veiculo.Id_Veiculo >= count)
                {
                    count = veiculo.Id_Veiculo;
                }
            }
            contaVeiculos = count + 1;

            VeiculosListBox.DataSource = null;

            VeiculosListBox.DataSource = VeiculosLista.veiculos;
            VeiculosListBox.DisplayMember = "NomeCompleto";

            
        }
        /// <summary>
        /// busco e apresento a informação do cliente
        /// </summary>
        public void Constroi2()
        {
            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ClientesLista.clientes;
            cb_cliente.DisplayMember = "NomeCompleto2";
        }
        /// <summary>
        /// salvar as informaç~es inseridas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            if (ValidaForm())
            {
                VeiculosLista.GravarInfo(contaVeiculos, cb_cliente.Text, tb_matricula.Text, cb_categoria.Text, cb_marca.Text, tb_modelo.Text, Convert.ToInt32(tb_ano.Text), tb_cor.Text);
                Constroi();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_id.Text = contaVeiculos.ToString();
            cb_cliente.Text = string.Empty;
            tb_matricula.Text = string.Empty;
            cb_categoria.Text = string.Empty;
            cb_marca.Text = string.Empty;
            tb_modelo.Text = string.Empty;
            tb_ano.Text = string.Empty;
            tb_cor.Text = string.Empty;
        }
        /// <summary>
        /// valida todas as informações que for inseridas pelo utilizador
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cb_cliente.Text))
            {
                MessageBox.Show("Insira o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_matricula.Text))
            {
                MessageBox.Show("Insira a matrícula", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_categoria.Text))
            {
                MessageBox.Show("Insira ã categoria", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_marca.Text))
            {
                MessageBox.Show("Insira a marca", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_modelo.Text))
            {
                MessageBox.Show("Insira o modelo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_ano.Text))
            {
                MessageBox.Show("Insira o ano do veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_ano.Text, @"^\d{4}$"))
            {
                MessageBox.Show("O ano inserido está com formatação errada. Insira o ano com formatação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_cor.Text))
            {
                MessageBox.Show("Insira a cor do veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_cor.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("A cor inserida está com formatação errada. Insira uma formatação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }
        /// <summary>
        /// cancela as informações inseridas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cb_cliente.Text = string.Empty;
            tb_matricula.Text = string.Empty;
            cb_categoria.Text = string.Empty;
            cb_marca.Text = string.Empty;
            tb_modelo.Text = string.Empty;
            tb_ano.Text = string.Empty;
            tb_cor.Text = string.Empty;
        }
        /// <summary>
        /// apaga as informações inseridas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Veiculo veiculoAApagar = (Veiculo)VeiculosListBox.SelectedItem;

            Veiculo apagado = null;

            if (veiculoAApagar != null)
            {
                foreach (Veiculo veiculo in VeiculosLista.veiculos)
                {
                    if (veiculoAApagar.Id_Veiculo == veiculo.Id_Veiculo)
                    {
                        apagado = veiculo;
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
                        VeiculosLista.veiculos.Remove(apagado);
                        VeiculosLista.GravarFicheiro();
                        Constroi();
                    }
                }
            }
        }
        /// <summary>
        /// aqui eu busco o id do veiculo na lista e envio a informação para o form editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Veiculo veiculoAEditar = (Veiculo)VeiculosListBox.SelectedItem;

            Veiculo editado = null;

            if (veiculoAEditar != null)
            {

                foreach (Veiculo veiculo in VeiculosLista.veiculos)
                {
                    if (veiculoAEditar.Id_Veiculo == veiculo.Id_Veiculo)
                    {
                        editado = veiculo;
                    }
                }

                EditarVeiculoForm editarMecanicoForm = new EditarVeiculoForm(this, editado);
                editarMecanicoForm.Show();
            }
        }
        /// <summary>
        /// Passagem para um form de listar os veiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_listar_Click(object sender, EventArgs e)
        {
            ListaVeiculoForm listaVeiculoForm = new ListaVeiculoForm(this);
            listaVeiculoForm.Show();
        }
    }

}
