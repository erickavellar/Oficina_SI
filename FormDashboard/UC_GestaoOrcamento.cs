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
using System.Configuration;

namespace FormDashboard
{
    public partial class UC_GestaoOrcamento : UserControl
    {
        //faço a passagem da informação criada na minha classe Orçamento, mais propriamente o construtor do iva
        private readonly Orcamento _principal;

        int contaOrcamento = 1;
        public UC_GestaoOrcamento()
        {
            InitializeComponent();

            

            _principal = new Orcamento();
            //mando ler as minhas classes listas dos ficheiros gravados
            OrcamentosLista.LerInfo();
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            ServicoLista.LerInfo();
            ServicoLista.LerInfo();
            UsuarioLista.LerInfo();
            
            InitList();
            InitListCliente();
            InitListVeiculo();
            InitListServico();
            InitListFuncionario();

            tb_idOrcamento.Text = contaOrcamento.ToString();
            dt_dataEmissao.MinDate = dt_dataEmissao.MinDate;
            dt_Validade.MinDate = dt_Validade.MinDate;
            
        }

        public void InitList()
        {
            int count = 0;
            foreach (Orcamento orcamento in OrcamentosLista.orcamentos)
            {
                if (orcamento.Id_Orcamento >= count)
                {
                    count = orcamento.Id_Orcamento;
                }
            }
            contaOrcamento = count + 1;

            listBoxOrcamento.DataSource = null;

            listBoxOrcamento.DataSource = OrcamentosLista.orcamentos;
            listBoxOrcamento.DisplayMember = "InfoCompleto";
        }

        public void InitListCliente()
        {
            cb_Cliente.DataSource = null;

            cb_Cliente.DataSource = ClientesLista.clientes;
            cb_Cliente.DisplayMember = "NomeCompleto2";
        }

        public void InitListVeiculo()
        {
            cb_veiculo.DataSource = VeiculosLista.veiculos.Where(x => x.Cliente == cb_Cliente.Text).ToList();
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
        /// <summary>
        /// salvo as informações inseridas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                OrcamentosLista.GravarInfo(contaOrcamento, cb_Cliente.Text.ToString(), cb_veiculo.Text.ToString(), cb_servico.Text.ToString(), cb_funcionario.Text.ToString(), Convert.ToDouble(cb_precoVenda.Text), Convert.ToDouble(tb_iva.Text), Convert.ToDouble(tb_totalAPagar.Text), Convert.ToDateTime(dt_dataEmissao.Text), Convert.ToDateTime(dt_Validade.Text));
                InitList();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            tb_idOrcamento.Text = contaOrcamento.ToString();
            cb_Cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_servico.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            dt_dataEmissao.Text = string.Empty;
            dt_Validade.Text = string.Empty;
            tb_iva.Text = string.Empty;
            tb_totalAPagar.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_assunto.Text = string.Empty;
            tb_mensagem.Text = string.Empty;

        }
        /// <summary>
        /// Valido toda informação inserida no form
        /// </summary>
        /// <returns></returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(cb_Cliente.Text))
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
        /// <summary>
        /// cancelar a informação 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cb_Cliente.Text = string.Empty;
            cb_veiculo.Text = string.Empty;
            cb_servico.Text = string.Empty;
            cb_funcionario.Text = string.Empty;
            dt_dataEmissao.Text = string.Empty;
            dt_Validade.Text = string.Empty;
            tb_email.Text = string.Empty;
            tb_assunto.Text = string.Empty;
            tb_mensagem.Text = string.Empty;
        }
        /// <summary>
        /// apago o orçamento gerado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_apagar_Click(object sender, EventArgs e)
        {
            Orcamento orcamentoAApagar = (Orcamento)listBoxOrcamento.SelectedItem;

            Orcamento apagado = null;

            if (orcamentoAApagar != null)
            {
                foreach (Orcamento orcamento in OrcamentosLista.orcamentos)
                {
                    if (orcamentoAApagar.Id_Orcamento == orcamento.Id_Orcamento)
                    {
                        apagado = orcamento;
                    }
                }


                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar o {apagado.InfoCompleto}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        OrcamentosLista.orcamentos.Remove(apagado);
                        OrcamentosLista.GravarFicheiro();
                        InitList();
                    }
                }
            }
        }
        /// <summary>
        /// editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Orcamento orcamentoAEditar = (Orcamento)listBoxOrcamento.SelectedItem;

            Orcamento editado = null;

            if (orcamentoAEditar != null)
            {
                foreach (Orcamento orcamento in OrcamentosLista.orcamentos)
                {
                    if (orcamentoAEditar.Id_Orcamento == orcamento.Id_Orcamento)
                    {
                        editado = orcamento;
                    }
                }

                EditarOrcamentoForm editarOrcamentoForm = new EditarOrcamentoForm(this, editado);
                editarOrcamentoForm.Show();
            }
        }

        private void cb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListVeiculo();
        }

        private void cb_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListServico2();
        }
        /// <summary>
        /// onde gero o meu pdf do orçamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            camposPDF.SetField("cliente", cb_Cliente.Text);
            camposPDF.SetField("veiculo", cb_veiculo.Text);
            camposPDF.SetField("servico", cb_servico.Text);
            camposPDF.SetField("preco", cb_precoVenda.Text );
            camposPDF.SetField("precocomiva", tb_totalAPagar.Text);
            camposPDF.SetField("funcionario", cb_funcionario.Text);

            pdfStamper.Close();
        }

        /// <summary>
        /// busco meu pdf criado e insiro no form para ser enviado por email ao cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_procurar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            tb_anexo.Text = openFileDialog1.FileName;
        }
        /// <summary>
        /// envio meu pdf para o cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// instancioalizo meu iva na combo box para ler a informação do meu construtor na classe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_precoVenda_SelectedValueChanged(object sender, EventArgs e)
        {
            tb_iva.Text = _principal.TaxaIVA.ToString();
            
        }
        /// <summary>
        /// gero o calculo do meu total a pagar para que apareça automaticamente na textbox ao selecionar o meu preco de venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_precoVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_totalAPagar.Text = $"{(Convert.ToDouble(cb_precoVenda.Text.ToString()) * Convert.ToDouble(tb_iva.Text.ToString())) + Convert.ToDouble(cb_precoVenda.Text.ToString())}";
        }
    }
}
