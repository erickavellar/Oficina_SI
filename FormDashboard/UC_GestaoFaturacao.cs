using Biblioteca;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class UC_GestaoFaturacao : UserControl
    {

        private readonly Faturacao _principal;

        int contaFaturacao = 1;
        public UC_GestaoFaturacao()
        {
            InitializeComponent();

            _principal = new Faturacao();

            FaturacaoLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();
            ReparacaoLista.LerInfo();

            InitList();


            InitListReparacao();
            InitListServico2();

            tb_numFat.Text = contaFaturacao.ToString();
            dt_emissao.MinDate = dt_emissao.MinDate;
            dt_vencimento.MinDate = dt_vencimento.MinDate;


        }

        public void InitList()
        {
            int count = 0;
            foreach (Faturacao faturacao in FaturacaoLista.faturacoes)
            {
                if (faturacao.NumFat >= count)
                {
                    count = faturacao.NumFat;
                }
            }
            contaFaturacao = count + 1;

            FaturacaolistBox.DataSource = null;

            FaturacaolistBox.DataSource = FaturacaoLista.faturacoes;
            FaturacaolistBox.DisplayMember = "InfoFaturacao2";
        }

        public void InitListReparacao()
        {

            tb_idRep.DataSource = null;

            tb_idRep.DataSource = ReparacaoLista.reparacoes;
            tb_idRep.DisplayMember = "IDReparacao";
        }

        public void InitListCliente()
        {

            cb_cliente.DataSource = null;

            cb_cliente.DataSource = ReparacaoLista.reparacoes.Where(x => x.Id.ToString() == tb_idRep.Text.ToString()).ToList();
            cb_cliente.DisplayMember = "ClienteReparacao";
        }

        public void InitListVeiculo()
        {
            cb_veiculo.DataSource = ReparacaoLista.reparacoes.Where(x => x.Id.ToString() == tb_idRep.Text.ToString()).ToList();
            cb_veiculo.DisplayMember = "VeiculoReparacao";
        }

        public void InitListServico()
        {
            cb_servico.DataSource = ReparacaoLista.reparacoes.Where(x => x.Id.ToString() == tb_idRep.Text.ToString()).ToList();
            cb_servico.DisplayMember = "ServicoReparacao";
        }

        public void InitListFuncionario()
        {
            cb_funcionario.DataSource = ReparacaoLista.reparacoes.Where(x => x.Id.ToString() == tb_idRep.Text.ToString()).ToList();
            cb_funcionario.DisplayMember = "FuncionarioReparacao";
        }

        public void InitListServico2()
        {
            cb_precoCusto.DataSource = ReparacaoLista.reparacoes.Where(x => x.Id.ToString() == tb_idRep.Text.ToString()).ToList();
            cb_precoCusto.DisplayMember = "PrecoReparacao";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (ValidaForm())
            {

                FaturacaoLista.GravarInfo(contaFaturacao, Convert.ToInt32(tb_idRep.Text), cb_cliente.Text, cb_veiculo.Text, cb_servico.Text, cb_funcionario.Text, cb_tipoPagamento.Text, Convert.ToDouble(cb_precoCusto.Text), Convert.ToDouble(tb_iva.Text), Convert.ToDouble(tb_totalAPagar.Text), Convert.ToDateTime(dt_emissao.Text), Convert.ToDateTime(dt_vencimento.Text));
                InitList();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_numFat.Text = contaFaturacao.ToString();
            tb_idRep.Text = string.Empty;
            cb_cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_servico.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            cb_tipoPagamento.Text = string.Empty;
            tb_iva.Text = string.Empty;
            tb_totalAPagar.Text = string.Empty;
            dt_emissao.Text = string.Empty;
            dt_vencimento.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_assunto.Text = string.Empty;
            tb_mensagem.Text = string.Empty;

        }

        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(tb_idRep.Text))
            {
                MessageBox.Show("Selecione a reparação realizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

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

            if (string.IsNullOrEmpty(cb_tipoPagamento.Text))
            {
                MessageBox.Show("Insira a forma de pagamento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_iva.Text))
            {
                MessageBox.Show("Insira a taxa de iva", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(tb_totalAPagar.Text))
            {
                MessageBox.Show("Insira o valor a pagar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_emissao.Text))
            {
                MessageBox.Show("Insira a data de emissão da fatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_emissao.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data da emissão igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(dt_vencimento.Text))
            {
                MessageBox.Show("Insira a data de vencimento da fatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }
            else if (Convert.ToDateTime(dt_vencimento.Text) < DateTime.Today)
            {
                MessageBox.Show("Insira uma data de vencimento igual ou superior de hoje.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_idRep.Text = string.Empty;
            cb_cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_servico.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            cb_tipoPagamento.Text = string.Empty;
            tb_iva.Text = string.Empty;
            tb_totalAPagar.Text = string.Empty;
            dt_emissao.Text = string.Empty;
            dt_vencimento.Text = string.Empty;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Faturacao faturacaoAEditar = (Faturacao)FaturacaolistBox.SelectedItem;

            Faturacao editado = null;

            if (faturacaoAEditar != null)
            {

                foreach (Faturacao faturacao in FaturacaoLista.faturacoes)
                {
                    if (faturacaoAEditar.NumFat == faturacao.NumFat)
                    {
                        editado = faturacao;
                    }
                }

                EditarFaturacaoForm editarFaturacaoForm = new EditarFaturacaoForm(this, editado);
                editarFaturacaoForm.Show();
            }
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Faturacao faturacaoAApagar = (Faturacao)FaturacaolistBox.SelectedItem;

            Faturacao apagado = null;

            if (faturacaoAApagar != null)
            {
                foreach (Faturacao faturacao in FaturacaoLista.faturacoes)
                {
                    if (faturacaoAApagar.NumFat == faturacao.NumFat)
                    {
                        apagado = faturacao;
                    }
                }


                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.InfoFaturacao}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        FaturacaoLista.faturacoes.Remove(apagado);
                        FaturacaoLista.GravarFicheiro();
                        InitList();
                    }
                }
            }
        }

        private void tb_idRep_SelectedValueChanged(object sender, EventArgs e)
        {
            InitListVeiculo();
            InitListCliente();
            InitListServico();
            InitListFuncionario();
            InitListServico2();
        }

        private void UC_GestaoFaturacao_Load(object sender, EventArgs e)
        {
            tb_iva.Text = _principal.TaxaIVA.ToString();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            //Caminho da pasta e nome do ficheiro salvo
            string Pasta = Directory.GetCurrentDirectory();
            string caminho = Pasta + @"\PDFS\";
            Guid id = Guid.NewGuid();


            //caminho do pdf  mais o nome da pata e o nome do ficheiro. usamos dos \ para não ter espaço
            String pdfNovo = caminho + "Template\\Fatura.pdf";

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
            camposPDF.SetField("num_fat", tb_numFat.Text);
            camposPDF.SetField("data_emissao", dt_emissao.Text);
            camposPDF.SetField("cliente", cb_cliente.Text);
            camposPDF.SetField("veiculo", cb_veiculo.Text);
            camposPDF.SetField("descricao1", cb_servico.Text);
            camposPDF.SetField("tipopagamento", cb_tipoPagamento.Text);
            camposPDF.SetField("preco_venda1", cb_precoCusto.Text);
            camposPDF.SetField("qnt_preco1", cb_precoCusto.Text);
            camposPDF.SetField("subtotal", cb_precoCusto.Text);
            camposPDF.SetField("iva", tb_iva.Text);
            camposPDF.SetField("total", tb_totalAPagar.Text);

            pdfStamper.Close();
            
        }

        private void cb_precoCusto_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_totalAPagar.Text = $"{(Convert.ToDouble(cb_precoCusto.Text.ToString()) * Convert.ToDouble(tb_iva.Text.ToString())) + Convert.ToDouble(cb_precoCusto.Text.ToString()) }";
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
                Message.Subject = tb_assunto.Text;

                cliente.Host = "smtp.office365.com";
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential("erick.merhy.avellar@formandos.cinel.pt", "Programador2021");
                cliente.EnableSsl = true;
                cliente.Send(Message);
                MessageBox.Show("Email enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_anexo.Text = openFileDialog1.FileName;
        }
    }
        
}
