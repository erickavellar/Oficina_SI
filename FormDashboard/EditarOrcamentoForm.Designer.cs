
namespace FormDashboard
{
    partial class EditarOrcamentoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarOrcamentoForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_dataEmissao = new System.Windows.Forms.DateTimePicker();
            this.dt_Validade = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_idOrcamento = new System.Windows.Forms.TextBox();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.cb_veiculo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_totalAPagar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_precoVenda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_iva = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_pdf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_procurar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_mensagem = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_anexo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_enviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_assunto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(427, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 28);
            this.label2.TabIndex = 1077;
            this.label2.Text = "Editar Orçamento";
            // 
            // btn_salvar
            // 
            this.btn_salvar.ActiveBorderThickness = 1;
            this.btn_salvar.ActiveCornerRadius = 20;
            this.btn_salvar.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_salvar.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_salvar.BackColor = System.Drawing.Color.White;
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.ButtonText = "Salvar";
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.IdleBorderThickness = 1;
            this.btn_salvar.IdleCornerRadius = 20;
            this.btn_salvar.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.IdleForecolor = System.Drawing.Color.White;
            this.btn_salvar.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_salvar.Location = new System.Drawing.Point(840, 534);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(140, 40);
            this.btn_salvar.TabIndex = 1079;
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.ActiveBorderThickness = 1;
            this.btn_cancelar.ActiveCornerRadius = 20;
            this.btn_cancelar.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_cancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_cancelar.ActiveLineColor = System.Drawing.Color.Red;
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.ButtonText = "Cancelar";
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.IdleBorderThickness = 1;
            this.btn_cancelar.IdleCornerRadius = 20;
            this.btn_cancelar.IdleFillColor = System.Drawing.Color.Red;
            this.btn_cancelar.IdleForecolor = System.Drawing.Color.White;
            this.btn_cancelar.IdleLineColor = System.Drawing.Color.Red;
            this.btn_cancelar.Location = new System.Drawing.Point(840, 453);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 40);
            this.btn_cancelar.TabIndex = 1080;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Serviço";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(299, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(299, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Funcionário";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(684, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Veiculo";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(684, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data de Emissão";
            // 
            // dt_dataEmissao
            // 
            this.dt_dataEmissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dataEmissao.Location = new System.Drawing.Point(684, 108);
            this.dt_dataEmissao.Name = "dt_dataEmissao";
            this.dt_dataEmissao.Size = new System.Drawing.Size(238, 27);
            this.dt_dataEmissao.TabIndex = 11;
            // 
            // dt_Validade
            // 
            this.dt_Validade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_Validade.Location = new System.Drawing.Point(684, 177);
            this.dt_Validade.Name = "dt_Validade";
            this.dt_Validade.Size = new System.Drawing.Size(238, 27);
            this.dt_Validade.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Validade";
            // 
            // tb_idOrcamento
            // 
            this.tb_idOrcamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_idOrcamento.Location = new System.Drawing.Point(9, 40);
            this.tb_idOrcamento.Name = "tb_idOrcamento";
            this.tb_idOrcamento.Size = new System.Drawing.Size(100, 27);
            this.tb_idOrcamento.TabIndex = 14;
            // 
            // cb_servico
            // 
            this.cb_servico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_servico.FormattingEnabled = true;
            this.cb_servico.Location = new System.Drawing.Point(9, 109);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(221, 29);
            this.cb_servico.TabIndex = 15;
            this.cb_servico.SelectedIndexChanged += new System.EventHandler(this.cb_servico_SelectedIndexChanged);
            // 
            // cb_cliente
            // 
            this.cb_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(299, 40);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(221, 29);
            this.cb_cliente.TabIndex = 16;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Location = new System.Drawing.Point(299, 110);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(221, 29);
            this.cb_funcionario.TabIndex = 17;
            // 
            // cb_veiculo
            // 
            this.cb_veiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_veiculo.FormattingEnabled = true;
            this.cb_veiculo.Location = new System.Drawing.Point(684, 39);
            this.cb_veiculo.Name = "cb_veiculo";
            this.cb_veiculo.Size = new System.Drawing.Size(221, 29);
            this.cb_veiculo.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_pdf);
            this.panel2.Controls.Add(this.tb_totalAPagar);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cb_precoVenda);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tb_iva);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cb_veiculo);
            this.panel2.Controls.Add(this.cb_funcionario);
            this.panel2.Controls.Add(this.cb_cliente);
            this.panel2.Controls.Add(this.cb_servico);
            this.panel2.Controls.Add(this.tb_idOrcamento);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.dt_Validade);
            this.panel2.Controls.Add(this.dt_dataEmissao);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(14, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 298);
            this.panel2.TabIndex = 1078;
            // 
            // tb_totalAPagar
            // 
            this.tb_totalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_totalAPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_totalAPagar.Location = new System.Drawing.Point(9, 255);
            this.tb_totalAPagar.Multiline = true;
            this.tb_totalAPagar.Name = "tb_totalAPagar";
            this.tb_totalAPagar.Size = new System.Drawing.Size(187, 27);
            this.tb_totalAPagar.TabIndex = 1053;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(9, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 19);
            this.label13.TabIndex = 1052;
            this.label13.Text = "Total à Pagar:";
            // 
            // cb_precoVenda
            // 
            this.cb_precoVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_precoVenda.FormattingEnabled = true;
            this.cb_precoVenda.Location = new System.Drawing.Point(9, 180);
            this.cb_precoVenda.Name = "cb_precoVenda";
            this.cb_precoVenda.Size = new System.Drawing.Size(192, 29);
            this.cb_precoVenda.TabIndex = 1051;
            this.cb_precoVenda.SelectedIndexChanged += new System.EventHandler(this.cb_precoVenda_SelectedIndexChanged);
            this.cb_precoVenda.SelectedValueChanged += new System.EventHandler(this.cb_precoVenda_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(9, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 19);
            this.label12.TabIndex = 1050;
            this.label12.Text = "Preço s/ IVA :";
            // 
            // tb_iva
            // 
            this.tb_iva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_iva.Enabled = false;
            this.tb_iva.Location = new System.Drawing.Point(299, 182);
            this.tb_iva.Name = "tb_iva";
            this.tb_iva.Size = new System.Drawing.Size(187, 27);
            this.tb_iva.TabIndex = 1049;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label15.Location = new System.Drawing.Point(299, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 19);
            this.label15.TabIndex = 1048;
            this.label15.Text = "IVA:";
            // 
            // btn_pdf
            // 
            this.btn_pdf.ActiveBorderThickness = 1;
            this.btn_pdf.ActiveCornerRadius = 20;
            this.btn_pdf.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_pdf.ActiveForecolor = System.Drawing.Color.White;
            this.btn_pdf.ActiveLineColor = System.Drawing.Color.Silver;
            this.btn_pdf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pdf.BackColor = System.Drawing.Color.White;
            this.btn_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pdf.BackgroundImage")));
            this.btn_pdf.ButtonText = "PDF";
            this.btn_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pdf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_pdf.IdleBorderThickness = 1;
            this.btn_pdf.IdleCornerRadius = 20;
            this.btn_pdf.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_pdf.IdleForecolor = System.Drawing.SystemColors.InfoText;
            this.btn_pdf.IdleLineColor = System.Drawing.Color.Silver;
            this.btn_pdf.Location = new System.Drawing.Point(793, 233);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(129, 49);
            this.btn_pdf.TabIndex = 1054;
            this.btn_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_procurar);
            this.panel3.Controls.Add(this.tb_mensagem);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.tb_anexo);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.btn_enviar);
            this.panel3.Controls.Add(this.tb_assunto);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(14, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 152);
            this.panel3.TabIndex = 1081;
            // 
            // btn_procurar
            // 
            this.btn_procurar.ActiveBorderThickness = 1;
            this.btn_procurar.ActiveCornerRadius = 20;
            this.btn_procurar.ActiveFillColor = System.Drawing.Color.Silver;
            this.btn_procurar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_procurar.ActiveLineColor = System.Drawing.Color.Silver;
            this.btn_procurar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_procurar.BackColor = System.Drawing.Color.White;
            this.btn_procurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_procurar.BackgroundImage")));
            this.btn_procurar.ButtonText = "Procurar";
            this.btn_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procurar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_procurar.ForeColor = System.Drawing.Color.White;
            this.btn_procurar.IdleBorderThickness = 1;
            this.btn_procurar.IdleCornerRadius = 20;
            this.btn_procurar.IdleFillColor = System.Drawing.Color.Silver;
            this.btn_procurar.IdleForecolor = System.Drawing.SystemColors.InfoText;
            this.btn_procurar.IdleLineColor = System.Drawing.Color.Silver;
            this.btn_procurar.Location = new System.Drawing.Point(626, 31);
            this.btn_procurar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(110, 38);
            this.btn_procurar.TabIndex = 1039;
            this.btn_procurar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_mensagem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mensagem.Location = new System.Drawing.Point(365, 113);
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(218, 27);
            this.tb_mensagem.TabIndex = 1038;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label18.Location = new System.Drawing.Point(365, 91);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 19);
            this.label18.TabIndex = 1037;
            this.label18.Text = "Mensagem:";
            // 
            // tb_anexo
            // 
            this.tb_anexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_anexo.Enabled = false;
            this.tb_anexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_anexo.Location = new System.Drawing.Point(365, 41);
            this.tb_anexo.Multiline = true;
            this.tb_anexo.Name = "tb_anexo";
            this.tb_anexo.Size = new System.Drawing.Size(249, 27);
            this.tb_anexo.TabIndex = 1036;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label17.Location = new System.Drawing.Point(365, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 19);
            this.label17.TabIndex = 1035;
            this.label17.Text = "Anexar Ficheiro:";
            // 
            // btn_enviar
            // 
            this.btn_enviar.ActiveBorderThickness = 1;
            this.btn_enviar.ActiveCornerRadius = 20;
            this.btn_enviar.ActiveFillColor = System.Drawing.Color.Gold;
            this.btn_enviar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_enviar.ActiveLineColor = System.Drawing.Color.Gold;
            this.btn_enviar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_enviar.BackgroundImage")));
            this.btn_enviar.ButtonText = "Enviar";
            this.btn_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.IdleBorderThickness = 1;
            this.btn_enviar.IdleCornerRadius = 20;
            this.btn_enviar.IdleFillColor = System.Drawing.Color.Gold;
            this.btn_enviar.IdleForecolor = System.Drawing.SystemColors.InfoText;
            this.btn_enviar.IdleLineColor = System.Drawing.Color.Gold;
            this.btn_enviar.Location = new System.Drawing.Point(626, 102);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(110, 38);
            this.btn_enviar.TabIndex = 1034;
            this.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // tb_assunto
            // 
            this.tb_assunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_assunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_assunto.Location = new System.Drawing.Point(10, 113);
            this.tb_assunto.Multiline = true;
            this.tb_assunto.Name = "tb_assunto";
            this.tb_assunto.Size = new System.Drawing.Size(269, 27);
            this.tb_assunto.TabIndex = 1025;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(8, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 1024;
            this.label11.Text = "Assunto:";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(10, 41);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 27);
            this.tb_email.TabIndex = 1023;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 1022;
            this.label10.Text = "Email:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditarOrcamentoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 623);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarOrcamentoForm";
            this.Text = "EditarOrcamentoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_dataEmissao;
        private System.Windows.Forms.DateTimePicker dt_Validade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_idOrcamento;
        private System.Windows.Forms.ComboBox cb_servico;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.ComboBox cb_funcionario;
        private System.Windows.Forms.ComboBox cb_veiculo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pdf;
        private System.Windows.Forms.TextBox tb_totalAPagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_precoVenda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_iva;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_procurar;
        private System.Windows.Forms.TextBox tb_mensagem;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_anexo;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_enviar;
        private System.Windows.Forms.TextBox tb_assunto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}