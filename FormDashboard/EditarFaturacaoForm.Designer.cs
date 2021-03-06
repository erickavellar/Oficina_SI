
namespace FormDashboard
{
    partial class EditarFaturacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFaturacaoForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_idRep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.cb_veiculo = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_numFat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_pdf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cb_precoCusto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_vencimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_emissao = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_iva = new System.Windows.Forms.TextBox();
            this.tb_totalAPagar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_tipoPagamento = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
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
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(467, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 1078;
            this.label2.Text = "Editar Faturação";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tb_idRep);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cb_funcionario);
            this.panel2.Controls.Add(this.cb_servico);
            this.panel2.Controls.Add(this.cb_veiculo);
            this.panel2.Controls.Add(this.cb_cliente);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_numFat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 119);
            this.panel2.TabIndex = 1079;
            // 
            // tb_idRep
            // 
            this.tb_idRep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_idRep.FormattingEnabled = true;
            this.tb_idRep.Location = new System.Drawing.Point(346, 6);
            this.tb_idRep.Name = "tb_idRep";
            this.tb_idRep.Size = new System.Drawing.Size(82, 29);
            this.tb_idRep.TabIndex = 1040;
            this.tb_idRep.SelectedValueChanged += new System.EventHandler(this.tb_idRep_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(221, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 1039;
            this.label6.Text = "ID Reparação :";
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Location = new System.Drawing.Point(814, 62);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(342, 29);
            this.cb_funcionario.TabIndex = 1036;
            // 
            // cb_servico
            // 
            this.cb_servico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_servico.FormattingEnabled = true;
            this.cb_servico.Items.AddRange(new object[] {
            "Numerário",
            "Multibanco",
            "Cartão Crédito",
            "Transferência Bancária",
            "MBWay"});
            this.cb_servico.Location = new System.Drawing.Point(87, 62);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(535, 29);
            this.cb_servico.TabIndex = 1035;
            // 
            // cb_veiculo
            // 
            this.cb_veiculo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_veiculo.FormattingEnabled = true;
            this.cb_veiculo.Items.AddRange(new object[] {
            "Numerário",
            "Multibanco",
            "Cartão Crédito",
            "Transferência Bancária",
            "MBWay"});
            this.cb_veiculo.Location = new System.Drawing.Point(909, 8);
            this.cb_veiculo.Name = "cb_veiculo";
            this.cb_veiculo.Size = new System.Drawing.Size(247, 29);
            this.cb_veiculo.TabIndex = 1034;
            // 
            // cb_cliente
            // 
            this.cb_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Items.AddRange(new object[] {
            "Numerário",
            "Multibanco",
            "Cartão Crédito",
            "Transferência Bancária",
            "MBWay"});
            this.cb_cliente.Location = new System.Drawing.Point(549, 8);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(247, 29);
            this.cb_cliente.TabIndex = 1033;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(831, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 19);
            this.label13.TabIndex = 1031;
            this.label13.Text = "Veiculo:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 1029;
            this.label12.Text = "Serviço:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(703, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 1026;
            this.label7.Text = "Funcionário:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(476, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 1015;
            this.label3.Text = "Cliente:";
            // 
            // tb_numFat
            // 
            this.tb_numFat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_numFat.Enabled = false;
            this.tb_numFat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_numFat.Location = new System.Drawing.Point(106, 8);
            this.tb_numFat.Name = "tb_numFat";
            this.tb_numFat.Size = new System.Drawing.Size(82, 27);
            this.tb_numFat.TabIndex = 1014;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 1013;
            this.label4.Text = "Nº da Fat.:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_pdf);
            this.panel4.Controls.Add(this.cb_precoCusto);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.dt_vencimento);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dt_emissao);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.tb_iva);
            this.panel4.Controls.Add(this.tb_totalAPagar);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.cb_tipoPagamento);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(12, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1179, 138);
            this.panel4.TabIndex = 1080;
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
            this.btn_pdf.Location = new System.Drawing.Point(990, 71);
            this.btn_pdf.Margin = new System.Windows.Forms.Padding(5);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(129, 49);
            this.btn_pdf.TabIndex = 1048;
            this.btn_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // cb_precoCusto
            // 
            this.cb_precoCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_precoCusto.Enabled = false;
            this.cb_precoCusto.FormattingEnabled = true;
            this.cb_precoCusto.Items.AddRange(new object[] {
            "Numerário",
            "Multibanco",
            "Cartão Crédito",
            "Transferência Bancária",
            "MBWay"});
            this.cb_precoCusto.Location = new System.Drawing.Point(600, 13);
            this.cb_precoCusto.Name = "cb_precoCusto";
            this.cb_precoCusto.Size = new System.Drawing.Size(192, 29);
            this.cb_precoCusto.TabIndex = 1054;
            this.cb_precoCusto.SelectedIndexChanged += new System.EventHandler(this.cb_precoCusto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(485, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 1053;
            this.label5.Text = "Preço s/ IVA :";
            // 
            // dt_vencimento
            // 
            this.dt_vencimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_vencimento.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_vencimento.Location = new System.Drawing.Point(824, 80);
            this.dt_vencimento.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_vencimento.Name = "dt_vencimento";
            this.dt_vencimento.Size = new System.Drawing.Size(121, 27);
            this.dt_vencimento.TabIndex = 1052;
            this.dt_vencimento.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(715, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 1051;
            this.label9.Text = "Vencimento:";
            // 
            // dt_emissao
            // 
            this.dt_emissao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_emissao.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_emissao.Location = new System.Drawing.Point(503, 82);
            this.dt_emissao.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_emissao.Name = "dt_emissao";
            this.dt_emissao.Size = new System.Drawing.Size(121, 27);
            this.dt_emissao.TabIndex = 1050;
            this.dt_emissao.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label16.Location = new System.Drawing.Point(397, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 19);
            this.label16.TabIndex = 1049;
            this.label16.Text = "Emitido em:";
            // 
            // tb_iva
            // 
            this.tb_iva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_iva.Enabled = false;
            this.tb_iva.Location = new System.Drawing.Point(949, 17);
            this.tb_iva.Name = "tb_iva";
            this.tb_iva.Size = new System.Drawing.Size(187, 27);
            this.tb_iva.TabIndex = 1047;
            // 
            // tb_totalAPagar
            // 
            this.tb_totalAPagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_totalAPagar.Enabled = false;
            this.tb_totalAPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_totalAPagar.Location = new System.Drawing.Point(135, 80);
            this.tb_totalAPagar.Multiline = true;
            this.tb_totalAPagar.Name = "tb_totalAPagar";
            this.tb_totalAPagar.Size = new System.Drawing.Size(187, 27);
            this.tb_totalAPagar.TabIndex = 1046;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(14, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 1045;
            this.label8.Text = "Total à Pagar:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label15.Location = new System.Drawing.Point(903, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 19);
            this.label15.TabIndex = 1044;
            this.label15.Text = "IVA:";
            // 
            // cb_tipoPagamento
            // 
            this.cb_tipoPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_tipoPagamento.FormattingEnabled = true;
            this.cb_tipoPagamento.Items.AddRange(new object[] {
            "Numerário",
            "Multibanco",
            "Cartão Crédito",
            "Transferência Bancária",
            "MBWay"});
            this.cb_tipoPagamento.Location = new System.Drawing.Point(186, 13);
            this.cb_tipoPagamento.Name = "cb_tipoPagamento";
            this.cb_tipoPagamento.Size = new System.Drawing.Size(196, 29);
            this.cb_tipoPagamento.TabIndex = 1043;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label14.Location = new System.Drawing.Point(14, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 19);
            this.label14.TabIndex = 1042;
            this.label14.Text = "Tipo de Pagamento:";
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
            this.panel3.Location = new System.Drawing.Point(12, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 152);
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
            this.btn_procurar.Location = new System.Drawing.Point(701, 27);
            this.btn_procurar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(110, 38);
            this.btn_procurar.TabIndex = 1049;
            this.btn_procurar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // tb_mensagem
            // 
            this.tb_mensagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_mensagem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_mensagem.Location = new System.Drawing.Point(440, 109);
            this.tb_mensagem.Multiline = true;
            this.tb_mensagem.Name = "tb_mensagem";
            this.tb_mensagem.Size = new System.Drawing.Size(218, 27);
            this.tb_mensagem.TabIndex = 1048;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label18.Location = new System.Drawing.Point(440, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 19);
            this.label18.TabIndex = 1047;
            this.label18.Text = "Mensagem:";
            // 
            // tb_anexo
            // 
            this.tb_anexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_anexo.Enabled = false;
            this.tb_anexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_anexo.Location = new System.Drawing.Point(440, 37);
            this.tb_anexo.Multiline = true;
            this.tb_anexo.Name = "tb_anexo";
            this.tb_anexo.Size = new System.Drawing.Size(249, 27);
            this.tb_anexo.TabIndex = 1046;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label17.Location = new System.Drawing.Point(440, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 19);
            this.label17.TabIndex = 1045;
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
            this.btn_enviar.Location = new System.Drawing.Point(701, 98);
            this.btn_enviar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(110, 38);
            this.btn_enviar.TabIndex = 1044;
            this.btn_enviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // tb_assunto
            // 
            this.tb_assunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_assunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_assunto.Location = new System.Drawing.Point(14, 109);
            this.tb_assunto.Multiline = true;
            this.tb_assunto.Name = "tb_assunto";
            this.tb_assunto.Size = new System.Drawing.Size(269, 27);
            this.tb_assunto.TabIndex = 1043;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(12, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 1042;
            this.label11.Text = "Assunto:";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(14, 37);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(280, 27);
            this.tb_email.TabIndex = 1041;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(14, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 1040;
            this.label10.Text = "Email:";
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
            this.btn_salvar.Location = new System.Drawing.Point(1034, 524);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(141, 40);
            this.btn_salvar.TabIndex = 1082;
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
            this.btn_cancelar.Location = new System.Drawing.Point(872, 524);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 40);
            this.btn_cancelar.TabIndex = 1083;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EditarFaturacaoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1203, 614);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFaturacaoForm";
            this.Text = "EditarFaturacaoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditarFaturacaoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_funcionario;
        private System.Windows.Forms.ComboBox cb_servico;
        private System.Windows.Forms.ComboBox cb_veiculo;
        private System.Windows.Forms.ComboBox cb_cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_numFat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tb_idRep;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_pdf;
        private System.Windows.Forms.ComboBox cb_precoCusto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_vencimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_emissao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_iva;
        private System.Windows.Forms.TextBox tb_totalAPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_tipoPagamento;
        private System.Windows.Forms.Label label14;
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