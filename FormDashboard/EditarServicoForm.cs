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
    public partial class EditarServicoForm : Form
    {
        Servico _editado;

        UC_GestaoReparacao _GestaoReparacao;

        int X = 0;
        int Y = 0;

        public EditarServicoForm(UC_GestaoReparacao gestaoReparacao, Servico editado)
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.MouseMove += new MouseEventHandler(Form_MouseMove);

            _editado = editado;
            _GestaoReparacao = gestaoReparacao;

            tb_cod.Text = editado.Cod_reparacao.ToString();
            tb_descricao.Text = editado.Descricao;
            tb_precoCusto.Text = editado.Preco_Custo.ToString();
            tb_precoVenda.Text = editado.Preco_Venda.ToString();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_descricao.Text))
            {
                MessageBox.Show("Insira a descrição do serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_precoCusto.Text))
            {
                MessageBox.Show("Insira o preço de custo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_precoCusto.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("O preço de custo está com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_precoVenda.Text))
            {
                MessageBox.Show("Insira o preço de venda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_precoVenda.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("O preço de venda está com formatação errada. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            if (ValidaForm())
            {

                _editado.Descricao = tb_descricao.Text;
                _editado.Preco_Custo = Convert.ToDecimal(tb_precoCusto.Text);
                _editado.Preco_Venda = Convert.ToDecimal(tb_precoVenda.Text);
                ServicoLista.GravarFicheiro();
                _GestaoReparacao.InitLista();
                this.Close();
            }
        }
    }
}
