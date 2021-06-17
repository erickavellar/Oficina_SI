
namespace FormDashboard
{
    partial class UC_Reparacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Reparacao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_precoCusto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.cb_servico = new System.Windows.Forms.ComboBox();
            this.cb_veiculo = new System.Windows.Forms.ComboBox();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_fim = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxReparacao = new System.Windows.Forms.ListBox();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_editar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_apagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 47);
            this.panel1.TabIndex = 1043;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incluir Reparação";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(450, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 1042;
            this.label2.Text = "Reparação";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_precoCusto);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cb_funcionario);
            this.panel2.Controls.Add(this.cb_servico);
            this.panel2.Controls.Add(this.cb_veiculo);
            this.panel2.Controls.Add(this.cb_cliente);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_id);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(13, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 193);
            this.panel2.TabIndex = 1044;
            // 
            // cb_precoCusto
            // 
            this.cb_precoCusto.Enabled = false;
            this.cb_precoCusto.FormattingEnabled = true;
            this.cb_precoCusto.Location = new System.Drawing.Point(384, 143);
            this.cb_precoCusto.Name = "cb_precoCusto";
            this.cb_precoCusto.Size = new System.Drawing.Size(121, 29);
            this.cb_precoCusto.TabIndex = 1033;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(384, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 1032;
            this.label8.Text = "Preço ";
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_funcionario.FormattingEnabled = true;
            this.cb_funcionario.Location = new System.Drawing.Point(675, 142);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(326, 29);
            this.cb_funcionario.TabIndex = 5;
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
            this.cb_servico.Location = new System.Drawing.Point(13, 142);
            this.cb_servico.Name = "cb_servico";
            this.cb_servico.Size = new System.Drawing.Size(323, 29);
            this.cb_servico.TabIndex = 4;
            this.cb_servico.SelectedIndexChanged += new System.EventHandler(this.cb_servico_SelectedIndexChanged);
            this.cb_servico.SelectedValueChanged += new System.EventHandler(this.cb_servico_SelectedValueChanged);
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
            this.cb_veiculo.Location = new System.Drawing.Point(675, 46);
            this.cb_veiculo.Name = "cb_veiculo";
            this.cb_veiculo.Size = new System.Drawing.Size(326, 29);
            this.cb_veiculo.TabIndex = 3;
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
            this.cb_cliente.Location = new System.Drawing.Point(231, 46);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(275, 29);
            this.cb_cliente.TabIndex = 2;
            this.cb_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_cliente_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label13.Location = new System.Drawing.Point(675, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 19);
            this.label13.TabIndex = 1031;
            this.label13.Text = "Veiculo";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label12.Location = new System.Drawing.Point(13, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 1029;
            this.label12.Text = "Serviço";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(675, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 1026;
            this.label7.Text = "Funcionário";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(231, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 1015;
            this.label3.Text = "Cliente";
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_id.Location = new System.Drawing.Point(13, 46);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(82, 27);
            this.tb_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 1013;
            this.label4.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dt_fim);
            this.panel3.Controls.Add(this.dt_inicio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(13, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 92);
            this.panel3.TabIndex = 1045;
            // 
            // dt_fim
            // 
            this.dt_fim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_fim.Location = new System.Drawing.Point(313, 37);
            this.dt_fim.Name = "dt_fim";
            this.dt_fim.Size = new System.Drawing.Size(128, 27);
            this.dt_fim.TabIndex = 7;
            // 
            // dt_inicio
            // 
            this.dt_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_inicio.Location = new System.Drawing.Point(13, 37);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(128, 27);
            this.dt_inicio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(313, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 1017;
            this.label6.Text = "Término";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 1016;
            this.label5.Text = "Início";
            // 
            // listBoxReparacao
            // 
            this.listBoxReparacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxReparacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReparacao.FormattingEnabled = true;
            this.listBoxReparacao.HorizontalScrollbar = true;
            this.listBoxReparacao.ItemHeight = 21;
            this.listBoxReparacao.Location = new System.Drawing.Point(13, 463);
            this.listBoxReparacao.Name = "listBoxReparacao";
            this.listBoxReparacao.ScrollAlwaysVisible = true;
            this.listBoxReparacao.Size = new System.Drawing.Size(1011, 256);
            this.listBoxReparacao.TabIndex = 1046;
            this.listBoxReparacao.UseWaitCursor = true;
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
            this.btn_salvar.Location = new System.Drawing.Point(840, 391);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(181, 41);
            this.btn_salvar.TabIndex = 8;
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
            this.btn_cancelar.Location = new System.Drawing.Point(642, 391);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 41);
            this.btn_cancelar.TabIndex = 1048;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.ActiveBorderThickness = 1;
            this.btn_editar.ActiveCornerRadius = 20;
            this.btn_editar.ActiveFillColor = System.Drawing.Color.MidnightBlue;
            this.btn_editar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_editar.ActiveLineColor = System.Drawing.Color.MidnightBlue;
            this.btn_editar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_editar.BackColor = System.Drawing.Color.White;
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.ButtonText = "Editar";
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.IdleBorderThickness = 1;
            this.btn_editar.IdleCornerRadius = 20;
            this.btn_editar.IdleFillColor = System.Drawing.Color.MidnightBlue;
            this.btn_editar.IdleForecolor = System.Drawing.Color.White;
            this.btn_editar.IdleLineColor = System.Drawing.Color.MidnightBlue;
            this.btn_editar.Location = new System.Drawing.Point(840, 740);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(181, 41);
            this.btn_editar.TabIndex = 1049;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.ActiveBorderThickness = 1;
            this.btn_apagar.ActiveCornerRadius = 20;
            this.btn_apagar.ActiveFillColor = System.Drawing.Color.Red;
            this.btn_apagar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_apagar.ActiveLineColor = System.Drawing.Color.Red;
            this.btn_apagar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_apagar.BackColor = System.Drawing.Color.White;
            this.btn_apagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_apagar.BackgroundImage")));
            this.btn_apagar.ButtonText = "Apagar";
            this.btn_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.IdleBorderThickness = 1;
            this.btn_apagar.IdleCornerRadius = 20;
            this.btn_apagar.IdleFillColor = System.Drawing.Color.Red;
            this.btn_apagar.IdleForecolor = System.Drawing.Color.White;
            this.btn_apagar.IdleLineColor = System.Drawing.Color.Red;
            this.btn_apagar.Location = new System.Drawing.Point(642, 740);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(181, 41);
            this.btn_apagar.TabIndex = 1050;
            this.btn_apagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // UC_Reparacao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.listBoxReparacao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Name = "UC_Reparacao";
            this.Size = new System.Drawing.Size(1037, 808);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dt_fim;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxReparacao;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_editar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_apagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_precoCusto;
    }
}
