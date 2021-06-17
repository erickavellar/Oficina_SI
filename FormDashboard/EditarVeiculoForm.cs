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
    public partial class EditarVeiculoForm : Form
    {
        //Receber as informações do método editar do UC_GestaoVeiculo
        Veiculo _editado;
        UC_GestaoVeiculos _GestaoVeiculo;

        public EditarVeiculoForm(UC_GestaoVeiculos gestaoVeiculos, Veiculo editado)
        {
            InitializeComponent();
            Constroi2();

            _editado = editado;
            _GestaoVeiculo = gestaoVeiculos;
            //inicializar as informações contidas no outro form
            tb_id.Text = editado.Id_Veiculo.ToString();
            cb_cliente.Text = editado.Cliente;
            tb_matricula.Text = editado.Matricula;
            cb_categoria.Text = editado.Categoria;
            cb_marca.Text = editado.Marca;
            tb_modelo.Text = editado.Modelo;
            tb_ano.Text = editado.Ano.ToString();
            tb_cor.Text = editado.Cor;
            
        }
        /// <summary>
        /// Serve para o veiculo aparecer somente quando o cliente é selecionado
        /// </summary>
        public void Constroi2()
        {
            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ClientesLista.clientes;
            cb_cliente.DisplayMember = "NomeCompleto2";
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
        /// Salvar as informações editadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Cliente = cb_cliente.Text.ToString();
                _editado.Matricula = tb_matricula.Text;
                _editado.Categoria = cb_categoria.Text;
                _editado.Marca = cb_marca.Text;
                _editado.Modelo = tb_modelo.Text;
                _editado.Ano = Convert.ToInt32(tb_ano.Text);
                _editado.Cor = tb_cor.Text;
                VeiculosLista.GravarFicheiro();
                _GestaoVeiculo.Constroi();
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
    }
}
