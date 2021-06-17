using Biblioteca;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class EditarOrcamentoForm : Form
    {
        Orcamento _editado;
        UC_GestaoOrcamento _GestaoOrcamento;
        private readonly Orcamento _principal;

        public EditarOrcamentoForm(UC_GestaoOrcamento gestaoOrcamento, Orcamento editado)
        {
            InitializeComponent();

            _principal = new Orcamento();

            OrcamentosLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();

            
            InitListCliente();
            InitListVeiculo();
            InitListServico();
            InitListFuncionario();


            _editado = editado;
            _GestaoOrcamento = gestaoOrcamento;

            tb_idOrcamento.Text = editado.Id_Orcamento.ToString();
            cb_cliente.Text = editado.Cliente;
            cb_veiculo.Text = editado.Veiculo;
            cb_servico.Text = editado.Servico;
            cb_funcionario.Text = editado.Funcionario;
            dt_dataEmissao.Text = editado.Data_Emissao.ToString();
            dt_Validade.Text = editado.Validade.ToString();

        }

        public void InitListCliente()
        {
            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ClientesLista.clientes;
            cb_cliente.DisplayMember = "NomeCompleto2";
        }

        public void InitListVeiculo()
        {
            cb_veiculo.DataSource = VeiculosLista.veiculos.Where(x => x.Cliente == cb_cliente.Text).ToList();
            cb_veiculo.DisplayMember = "InfoVeiculo";
        }

        public void InitListServico()
        {
            cb_servico.DataSource = null;

            cb_servico.DataSource = ServicoLista.reparacoes;
            cb_servico.DisplayMember = "InfoServico";
        }

        public void InitListServico2()
        {
            cb_precoVenda.DataSource = ServicoLista.reparacoes.Where(x => x.Descricao == cb_servico.Text).ToList();
            cb_precoVenda.DisplayMember = "PrecoVenda";
        }

        public void InitListFuncionario()
        {

            cb_funcionario.DataSource = null;

            cb_funcionario.DataSource = UsuarioLista.usuarios;
            cb_funcionario.DisplayMember = "InfoUsuario2";
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Cliente = cb_cliente.Text.ToString();
                _editado.Veiculo = cb_veiculo.Text.ToString();
                _editado.Servico = cb_servico.Text.ToString();
                _editado.Funcionario = cb_funcionario.Text.ToString();
                _editado.Data_Emissao = Convert.ToDateTime(dt_dataEmissao.Text);
                _editado.Validade = Convert.ToDateTime(dt_Validade.Text);

                OrcamentosLista.GravarFicheiro();
                _GestaoOrcamento.InitList();
                this.Close(); 
            }

        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cb_cliente.Text))
            {
                MessageBox.Show("Insira o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_veiculo.Text))
            {
                MessageBox.Show("Insira o veículo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_servico.Text))
            {
                MessageBox.Show("Insira o serviço", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(cb_funcionario.Text))
            {
                MessageBox.Show("Insira o funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_dataEmissao.Text))
            {
                MessageBox.Show("Insira a data de início", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_dataEmissao.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data da emissão igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }


            if (string.IsNullOrEmpty(dt_Validade.Text))
            {
                MessageBox.Show("Insira a data de validade do orçamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_Validade.Text) <= DateTime.Today)
            {
                MessageBox.Show("Insira uma data de validade superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_email.Text))
            {
                MessageBox.Show("Insira o email", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (!Regex.IsMatch(tb_email.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_assunto.Text))
            {
                MessageBox.Show("Insira um assunto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_mensagem.Text))
            {
                MessageBox.Show("Insira uma mensagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }

        private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListVeiculo();
        }

        private void cb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListServico2();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            //Caminho da pasta e nome do ficheiro salvo
            string Pasta = Directory.GetCurrentDirectory();
            string caminho = Pasta + @"\PDFS\";
            Guid id = Guid.NewGuid();


            //caminho do pdf  mais o nome da pata e o nome do ficheiro. usamos dos \ para não ter espaço
            String pdfNovo = caminho + "Template\\Orçamento.pdf";

            //nome do PDF que vamos gerar.
            string nomePDF = id + ".pdf";

            //aonde eu vou salvar o pdf gerado
            string newFile = caminho + nomePDF;

            //cria pdf atravez do template
            PdfReader pdfreader = new PdfReader(pdfNovo);

            //vai criar um novo template com o nome x e criação da raíz.
            PdfStamper pdfStamper = new PdfStamper(pdfreader, new FileStream(newFile, FileMode.Create));

            AcroFields camposPDF = pdfStamper.AcroFields;

            //escreve no pdf – PRIMEIRO CAMPO DO PDF E SEGUNDO NOMD DA TEXTBOX
            camposPDF.SetField("id", tb_idOrcamento.Text);
            camposPDF.SetField("dataemissao", dt_dataEmissao.Text);
            camposPDF.SetField("datavalidade", dt_Validade.Text);
            camposPDF.SetField("cliente", cb_cliente.Text);
            camposPDF.SetField("veiculo", cb_veiculo.Text);
            camposPDF.SetField("servico", cb_servico.Text);
            camposPDF.SetField("preco", cb_precoVenda.Text);
            camposPDF.SetField("precocomiva", tb_totalAPagar.Text);
            camposPDF.SetField("funcionario", cb_funcionario.Text);

            pdfStamper.Close();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_anexo.Text = openFileDialog1.FileName;
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            using (SmtpClient cliente = new SmtpClient("usuario.dominio.com"))
            {
                MailMessage Message = new MailMessage();
                Attachment anexo = new Attachment(tb_anexo.Text);
                Message.From = new MailAddress("erick.merhy.avellar@formandos.cinel.pt");
                Message.To.Add(tb_email.Text);
                Message.Attachments.Add(anexo);
                Message.Body = tb_mensagem.Text;
                Message.Subject = $"Orçamento nº: #{tb_idOrcamento.Text}";

                cliente.Host = "smtp.office365.com";
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential("erick.merhy.avellar@formandos.cinel.pt", "Programador2021");
                cliente.EnableSsl = true;
                cliente.Send(Message);
                MessageBox.Show("Email enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_precoVenda_SelectedValueChanged(object sender, EventArgs e)
        {
            tb_iva.Text = _principal.TaxaIVA.ToString();
        }

        private void cb_precoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_totalAPagar.Text = $"{(Convert.ToDouble(cb_precoVenda.Text.ToString()) * Convert.ToDouble(tb_iva.Text.ToString())) + Convert.ToDouble(cb_precoVenda.Text.ToString())}";
        }
    }
}
