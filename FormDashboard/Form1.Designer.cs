
namespace FormDashboard
{
    partial class Form_Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btn_sobre = new System.Windows.Forms.Button();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btn_configuracao = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.panelReparacao = new System.Windows.Forms.Panel();
            this.btn_ConsultarReparacoes = new System.Windows.Forms.Button();
            this.btn_reparacoes = new System.Windows.Forms.Button();
            this.btn_IncluirServico = new System.Windows.Forms.Button();
            this.btn_reparacao = new System.Windows.Forms.Button();
            this.panelMarcacao = new System.Windows.Forms.Panel();
            this.btn_marcacao = new System.Windows.Forms.Button();
            this.btn_listaMarcacoes = new System.Windows.Forms.Button();
            this.btn_calendario = new System.Windows.Forms.Button();
            this.btn_incluirAgend = new System.Windows.Forms.Button();
            this.panel_Fin = new System.Windows.Forms.Panel();
            this.btn_faturacao = new System.Windows.Forms.Button();
            this.btn_consultarFaturacao = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.panelOrcamento = new System.Windows.Forms.Panel();
            this.btn_buscarOrcamento = new System.Windows.Forms.Button();
            this.btn_incluirOrcamento = new System.Windows.Forms.Button();
            this.btn_orcamento = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_veiculo = new System.Windows.Forms.Button();
            this.panelSide = new System.Windows.Forms.Panel();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerFin = new System.Windows.Forms.Timer(this.components);
            this.timerMarcacao = new System.Windows.Forms.Timer(this.components);
            this.timerConf = new System.Windows.Forms.Timer(this.components);
            this.timerReparacao = new System.Windows.Forms.Timer(this.components);
            this.panelEsquerdo.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.panelReparacao.SuspendLayout();
            this.panelMarcacao.SuspendLayout();
            this.panel_Fin.SuspendLayout();
            this.panelOrcamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panelEsquerdo.Controls.Add(this.btn_sobre);
            this.panelEsquerdo.Controls.Add(this.panelConfig);
            this.panelEsquerdo.Controls.Add(this.panelReparacao);
            this.panelEsquerdo.Controls.Add(this.panelMarcacao);
            this.panelEsquerdo.Controls.Add(this.panel_Fin);
            this.panelEsquerdo.Controls.Add(this.panelOrcamento);
            this.panelEsquerdo.Controls.Add(this.btn_cliente);
            this.panelEsquerdo.Controls.Add(this.btn_veiculo);
            this.panelEsquerdo.Controls.Add(this.panelSide);
            this.panelEsquerdo.Controls.Add(this.btn_inicio);
            this.panelEsquerdo.Controls.Add(this.panel2);
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(225, 824);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // btn_sobre
            // 
            this.btn_sobre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sobre.FlatAppearance.BorderSize = 0;
            this.btn_sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sobre.ForeColor = System.Drawing.Color.White;
            this.btn_sobre.Image = ((System.Drawing.Image)(resources.GetObject("btn_sobre.Image")));
            this.btn_sobre.Location = new System.Drawing.Point(0, 774);
            this.btn_sobre.Name = "btn_sobre";
            this.btn_sobre.Size = new System.Drawing.Size(225, 50);
            this.btn_sobre.TabIndex = 23;
            this.btn_sobre.Text = "Sobre         ";
            this.btn_sobre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sobre.UseVisualStyleBackColor = true;
            this.btn_sobre.Click += new System.EventHandler(this.btn_sobre_Click);
            // 
            // panelConfig
            // 
            this.panelConfig.Controls.Add(this.btn_configuracao);
            this.panelConfig.Controls.Add(this.btn_usuario);
            this.panelConfig.Location = new System.Drawing.Point(1, 527);
            this.panelConfig.MaximumSize = new System.Drawing.Size(225, 90);
            this.panelConfig.MinimumSize = new System.Drawing.Size(225, 50);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(225, 50);
            this.panelConfig.TabIndex = 3;
            // 
            // btn_configuracao
            // 
            this.btn_configuracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_configuracao.FlatAppearance.BorderSize = 0;
            this.btn_configuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracao.ForeColor = System.Drawing.Color.White;
            this.btn_configuracao.Image = ((System.Drawing.Image)(resources.GetObject("btn_configuracao.Image")));
            this.btn_configuracao.Location = new System.Drawing.Point(0, 0);
            this.btn_configuracao.Name = "btn_configuracao";
            this.btn_configuracao.Size = new System.Drawing.Size(225, 50);
            this.btn_configuracao.TabIndex = 2;
            this.btn_configuracao.Text = "Configuração";
            this.btn_configuracao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_configuracao.UseVisualStyleBackColor = false;
            this.btn_configuracao.Click += new System.EventHandler(this.btn_configuracao_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_usuario.FlatAppearance.BorderSize = 0;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_usuario.ForeColor = System.Drawing.Color.White;
            this.btn_usuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_usuario.Image")));
            this.btn_usuario.Location = new System.Drawing.Point(0, 50);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(225, 40);
            this.btn_usuario.TabIndex = 17;
            this.btn_usuario.Text = "Usuário";
            this.btn_usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // panelReparacao
            // 
            this.panelReparacao.Controls.Add(this.btn_ConsultarReparacoes);
            this.panelReparacao.Controls.Add(this.btn_reparacoes);
            this.panelReparacao.Controls.Add(this.btn_IncluirServico);
            this.panelReparacao.Controls.Add(this.btn_reparacao);
            this.panelReparacao.Location = new System.Drawing.Point(0, 303);
            this.panelReparacao.MaximumSize = new System.Drawing.Size(225, 170);
            this.panelReparacao.MinimumSize = new System.Drawing.Size(225, 50);
            this.panelReparacao.Name = "panelReparacao";
            this.panelReparacao.Size = new System.Drawing.Size(225, 50);
            this.panelReparacao.TabIndex = 11;
            // 
            // btn_ConsultarReparacoes
            // 
            this.btn_ConsultarReparacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_ConsultarReparacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ConsultarReparacoes.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarReparacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarReparacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConsultarReparacoes.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultarReparacoes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConsultarReparacoes.Image")));
            this.btn_ConsultarReparacoes.Location = new System.Drawing.Point(0, 130);
            this.btn_ConsultarReparacoes.Name = "btn_ConsultarReparacoes";
            this.btn_ConsultarReparacoes.Size = new System.Drawing.Size(225, 40);
            this.btn_ConsultarReparacoes.TabIndex = 13;
            this.btn_ConsultarReparacoes.Text = "Consultar Reparações";
            this.btn_ConsultarReparacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_ConsultarReparacoes.UseVisualStyleBackColor = false;
            this.btn_ConsultarReparacoes.Click += new System.EventHandler(this.btn_ConsultarReparacoes_Click);
            // 
            // btn_reparacoes
            // 
            this.btn_reparacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_reparacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reparacoes.FlatAppearance.BorderSize = 0;
            this.btn_reparacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reparacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reparacoes.ForeColor = System.Drawing.Color.White;
            this.btn_reparacoes.Image = ((System.Drawing.Image)(resources.GetObject("btn_reparacoes.Image")));
            this.btn_reparacoes.Location = new System.Drawing.Point(0, 90);
            this.btn_reparacoes.Name = "btn_reparacoes";
            this.btn_reparacoes.Size = new System.Drawing.Size(225, 40);
            this.btn_reparacoes.TabIndex = 12;
            this.btn_reparacoes.Text = "Reparação";
            this.btn_reparacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_reparacoes.UseVisualStyleBackColor = false;
            this.btn_reparacoes.Click += new System.EventHandler(this.btn_reparacoes_Click);
            // 
            // btn_IncluirServico
            // 
            this.btn_IncluirServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_IncluirServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_IncluirServico.FlatAppearance.BorderSize = 0;
            this.btn_IncluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IncluirServico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IncluirServico.ForeColor = System.Drawing.Color.White;
            this.btn_IncluirServico.Image = ((System.Drawing.Image)(resources.GetObject("btn_IncluirServico.Image")));
            this.btn_IncluirServico.Location = new System.Drawing.Point(0, 50);
            this.btn_IncluirServico.Name = "btn_IncluirServico";
            this.btn_IncluirServico.Size = new System.Drawing.Size(225, 40);
            this.btn_IncluirServico.TabIndex = 11;
            this.btn_IncluirServico.Text = "Incluir Serviço";
            this.btn_IncluirServico.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_IncluirServico.UseVisualStyleBackColor = false;
            this.btn_IncluirServico.Click += new System.EventHandler(this.btn_IncluirServico_Click);
            // 
            // btn_reparacao
            // 
            this.btn_reparacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_reparacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_reparacao.FlatAppearance.BorderSize = 0;
            this.btn_reparacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reparacao.ForeColor = System.Drawing.Color.White;
            this.btn_reparacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_reparacao.Image")));
            this.btn_reparacao.Location = new System.Drawing.Point(0, 0);
            this.btn_reparacao.Name = "btn_reparacao";
            this.btn_reparacao.Size = new System.Drawing.Size(225, 50);
            this.btn_reparacao.TabIndex = 10;
            this.btn_reparacao.Text = "Reparação";
            this.btn_reparacao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_reparacao.UseVisualStyleBackColor = false;
            this.btn_reparacao.Click += new System.EventHandler(this.btn_reparacao_Click);
            // 
            // panelMarcacao
            // 
            this.panelMarcacao.Controls.Add(this.btn_marcacao);
            this.panelMarcacao.Controls.Add(this.btn_listaMarcacoes);
            this.panelMarcacao.Controls.Add(this.btn_calendario);
            this.panelMarcacao.Controls.Add(this.btn_incluirAgend);
            this.panelMarcacao.Location = new System.Drawing.Point(1, 359);
            this.panelMarcacao.MaximumSize = new System.Drawing.Size(225, 170);
            this.panelMarcacao.MinimumSize = new System.Drawing.Size(225, 50);
            this.panelMarcacao.Name = "panelMarcacao";
            this.panelMarcacao.Size = new System.Drawing.Size(225, 50);
            this.panelMarcacao.TabIndex = 22;
            // 
            // btn_marcacao
            // 
            this.btn_marcacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_marcacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_marcacao.FlatAppearance.BorderSize = 0;
            this.btn_marcacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marcacao.ForeColor = System.Drawing.Color.White;
            this.btn_marcacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_marcacao.Image")));
            this.btn_marcacao.Location = new System.Drawing.Point(0, 0);
            this.btn_marcacao.Name = "btn_marcacao";
            this.btn_marcacao.Size = new System.Drawing.Size(225, 50);
            this.btn_marcacao.TabIndex = 21;
            this.btn_marcacao.Text = "Marcação  ";
            this.btn_marcacao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_marcacao.UseVisualStyleBackColor = false;
            this.btn_marcacao.Click += new System.EventHandler(this.btn_marcacao_Click);
            // 
            // btn_listaMarcacoes
            // 
            this.btn_listaMarcacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_listaMarcacoes.FlatAppearance.BorderSize = 0;
            this.btn_listaMarcacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listaMarcacoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_listaMarcacoes.ForeColor = System.Drawing.Color.White;
            this.btn_listaMarcacoes.Image = ((System.Drawing.Image)(resources.GetObject("btn_listaMarcacoes.Image")));
            this.btn_listaMarcacoes.Location = new System.Drawing.Point(0, 130);
            this.btn_listaMarcacoes.Name = "btn_listaMarcacoes";
            this.btn_listaMarcacoes.Size = new System.Drawing.Size(225, 40);
            this.btn_listaMarcacoes.TabIndex = 24;
            this.btn_listaMarcacoes.Text = "Lista de Marcações";
            this.btn_listaMarcacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_listaMarcacoes.UseVisualStyleBackColor = false;
            this.btn_listaMarcacoes.Click += new System.EventHandler(this.btn_listaMarcacoes_Click);
            // 
            // btn_calendario
            // 
            this.btn_calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_calendario.FlatAppearance.BorderSize = 0;
            this.btn_calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calendario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calendario.ForeColor = System.Drawing.Color.White;
            this.btn_calendario.Image = ((System.Drawing.Image)(resources.GetObject("btn_calendario.Image")));
            this.btn_calendario.Location = new System.Drawing.Point(0, 90);
            this.btn_calendario.Name = "btn_calendario";
            this.btn_calendario.Size = new System.Drawing.Size(225, 40);
            this.btn_calendario.TabIndex = 23;
            this.btn_calendario.Text = "Calendário";
            this.btn_calendario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_calendario.UseVisualStyleBackColor = false;
            this.btn_calendario.Click += new System.EventHandler(this.btn_calendario_Click);
            // 
            // btn_incluirAgend
            // 
            this.btn_incluirAgend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_incluirAgend.FlatAppearance.BorderSize = 0;
            this.btn_incluirAgend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incluirAgend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_incluirAgend.ForeColor = System.Drawing.Color.White;
            this.btn_incluirAgend.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluirAgend.Image")));
            this.btn_incluirAgend.Location = new System.Drawing.Point(0, 50);
            this.btn_incluirAgend.Name = "btn_incluirAgend";
            this.btn_incluirAgend.Size = new System.Drawing.Size(225, 40);
            this.btn_incluirAgend.TabIndex = 22;
            this.btn_incluirAgend.Text = "Incluir Agendamento";
            this.btn_incluirAgend.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_incluirAgend.UseVisualStyleBackColor = false;
            this.btn_incluirAgend.Click += new System.EventHandler(this.btn_incluirAgend_Click);
            // 
            // panel_Fin
            // 
            this.panel_Fin.Controls.Add(this.btn_faturacao);
            this.panel_Fin.Controls.Add(this.btn_consultarFaturacao);
            this.panel_Fin.Controls.Add(this.btn_financeiro);
            this.panel_Fin.Location = new System.Drawing.Point(1, 471);
            this.panel_Fin.MaximumSize = new System.Drawing.Size(225, 131);
            this.panel_Fin.MinimumSize = new System.Drawing.Size(225, 50);
            this.panel_Fin.Name = "panel_Fin";
            this.panel_Fin.Size = new System.Drawing.Size(225, 50);
            this.panel_Fin.TabIndex = 17;
            // 
            // btn_faturacao
            // 
            this.btn_faturacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_faturacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_faturacao.FlatAppearance.BorderSize = 0;
            this.btn_faturacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faturacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_faturacao.ForeColor = System.Drawing.Color.White;
            this.btn_faturacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_faturacao.Image")));
            this.btn_faturacao.Location = new System.Drawing.Point(0, 50);
            this.btn_faturacao.Name = "btn_faturacao";
            this.btn_faturacao.Size = new System.Drawing.Size(225, 40);
            this.btn_faturacao.TabIndex = 20;
            this.btn_faturacao.Text = "Faturacao";
            this.btn_faturacao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_faturacao.UseVisualStyleBackColor = false;
            this.btn_faturacao.Click += new System.EventHandler(this.btn_faturacao_Click);
            // 
            // btn_consultarFaturacao
            // 
            this.btn_consultarFaturacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_consultarFaturacao.FlatAppearance.BorderSize = 0;
            this.btn_consultarFaturacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarFaturacao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_consultarFaturacao.ForeColor = System.Drawing.Color.White;
            this.btn_consultarFaturacao.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultarFaturacao.Image")));
            this.btn_consultarFaturacao.Location = new System.Drawing.Point(0, 90);
            this.btn_consultarFaturacao.Name = "btn_consultarFaturacao";
            this.btn_consultarFaturacao.Size = new System.Drawing.Size(225, 40);
            this.btn_consultarFaturacao.TabIndex = 19;
            this.btn_consultarFaturacao.Text = "Consultar Faturação";
            this.btn_consultarFaturacao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_consultarFaturacao.UseVisualStyleBackColor = false;
            this.btn_consultarFaturacao.Click += new System.EventHandler(this.btn_consultarFaturacao_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_financeiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_financeiro.FlatAppearance.BorderSize = 0;
            this.btn_financeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financeiro.ForeColor = System.Drawing.Color.White;
            this.btn_financeiro.Image = ((System.Drawing.Image)(resources.GetObject("btn_financeiro.Image")));
            this.btn_financeiro.Location = new System.Drawing.Point(0, 0);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(225, 50);
            this.btn_financeiro.TabIndex = 16;
            this.btn_financeiro.Text = "Financeiro     ";
            this.btn_financeiro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_financeiro.UseVisualStyleBackColor = false;
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            // 
            // panelOrcamento
            // 
            this.panelOrcamento.Controls.Add(this.btn_buscarOrcamento);
            this.panelOrcamento.Controls.Add(this.btn_incluirOrcamento);
            this.panelOrcamento.Controls.Add(this.btn_orcamento);
            this.panelOrcamento.Location = new System.Drawing.Point(0, 415);
            this.panelOrcamento.MaximumSize = new System.Drawing.Size(225, 137);
            this.panelOrcamento.MinimumSize = new System.Drawing.Size(225, 50);
            this.panelOrcamento.Name = "panelOrcamento";
            this.panelOrcamento.Size = new System.Drawing.Size(225, 50);
            this.panelOrcamento.TabIndex = 14;
            // 
            // btn_buscarOrcamento
            // 
            this.btn_buscarOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_buscarOrcamento.FlatAppearance.BorderSize = 0;
            this.btn_buscarOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarOrcamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buscarOrcamento.ForeColor = System.Drawing.Color.White;
            this.btn_buscarOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscarOrcamento.Image")));
            this.btn_buscarOrcamento.Location = new System.Drawing.Point(0, 90);
            this.btn_buscarOrcamento.Name = "btn_buscarOrcamento";
            this.btn_buscarOrcamento.Size = new System.Drawing.Size(225, 38);
            this.btn_buscarOrcamento.TabIndex = 14;
            this.btn_buscarOrcamento.Text = "Buscar Orçamento";
            this.btn_buscarOrcamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_buscarOrcamento.UseVisualStyleBackColor = false;
            this.btn_buscarOrcamento.Click += new System.EventHandler(this.btn_buscarOrcamento_Click);
            // 
            // btn_incluirOrcamento
            // 
            this.btn_incluirOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_incluirOrcamento.FlatAppearance.BorderSize = 0;
            this.btn_incluirOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incluirOrcamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_incluirOrcamento.ForeColor = System.Drawing.Color.White;
            this.btn_incluirOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("btn_incluirOrcamento.Image")));
            this.btn_incluirOrcamento.Location = new System.Drawing.Point(0, 50);
            this.btn_incluirOrcamento.Name = "btn_incluirOrcamento";
            this.btn_incluirOrcamento.Size = new System.Drawing.Size(225, 40);
            this.btn_incluirOrcamento.TabIndex = 13;
            this.btn_incluirOrcamento.Text = "Incluir Orçamento";
            this.btn_incluirOrcamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_incluirOrcamento.UseVisualStyleBackColor = false;
            this.btn_incluirOrcamento.Click += new System.EventHandler(this.btn_incluirOrcamento_Click_1);
            // 
            // btn_orcamento
            // 
            this.btn_orcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_orcamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_orcamento.FlatAppearance.BorderSize = 0;
            this.btn_orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orcamento.ForeColor = System.Drawing.Color.White;
            this.btn_orcamento.Image = ((System.Drawing.Image)(resources.GetObject("btn_orcamento.Image")));
            this.btn_orcamento.Location = new System.Drawing.Point(0, 0);
            this.btn_orcamento.Name = "btn_orcamento";
            this.btn_orcamento.Size = new System.Drawing.Size(225, 50);
            this.btn_orcamento.TabIndex = 12;
            this.btn_orcamento.Text = "Orçamento";
            this.btn_orcamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_orcamento.UseVisualStyleBackColor = false;
            this.btn_orcamento.Click += new System.EventHandler(this.btn_orcamento_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cliente.Image")));
            this.btn_cliente.Location = new System.Drawing.Point(1, 191);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(225, 50);
            this.btn_cliente.TabIndex = 20;
            this.btn_cliente.Text = "Cliente        ";
            this.btn_cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click_1);
            // 
            // btn_veiculo
            // 
            this.btn_veiculo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_veiculo.FlatAppearance.BorderSize = 0;
            this.btn_veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veiculo.ForeColor = System.Drawing.Color.White;
            this.btn_veiculo.Image = ((System.Drawing.Image)(resources.GetObject("btn_veiculo.Image")));
            this.btn_veiculo.Location = new System.Drawing.Point(0, 247);
            this.btn_veiculo.Name = "btn_veiculo";
            this.btn_veiculo.Size = new System.Drawing.Size(225, 50);
            this.btn_veiculo.TabIndex = 9;
            this.btn_veiculo.Text = "Veículo           ";
            this.btn_veiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_veiculo.UseVisualStyleBackColor = true;
            this.btn_veiculo.Click += new System.EventHandler(this.btn_veiculo_Click);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.White;
            this.panelSide.Location = new System.Drawing.Point(1, 142);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(7, 60);
            this.panelSide.TabIndex = 1;
            this.panelSide.Visible = false;
            // 
            // btn_inicio
            // 
            this.btn_inicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inicio.FlatAppearance.BorderSize = 0;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.ForeColor = System.Drawing.Color.White;
            this.btn_inicio.Image = ((System.Drawing.Image)(resources.GetObject("btn_inicio.Image")));
            this.btn_inicio.Location = new System.Drawing.Point(0, 135);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(225, 50);
            this.btn_inicio.TabIndex = 1;
            this.btn_inicio.Text = "Inicio              ";
            this.btn_inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 91);
            this.panel2.TabIndex = 8;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(181, 21);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(38, 27);
            this.btn_menu.TabIndex = 20;
            this.btn_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "workshop system";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "WS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(996, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(59, 91);
            this.button9.TabIndex = 17;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Controls.Add(this.lbl_data);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1055, 91);
            this.panel3.TabIndex = 18;
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_data.ForeColor = System.Drawing.Color.White;
            this.lbl_data.Location = new System.Drawing.Point(907, 36);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(83, 19);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "HH:MM:SS";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(459, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dashboard";
            // 
            // panelControls
            // 
            this.panelControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControls.Location = new System.Drawing.Point(225, 91);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1055, 733);
            this.panelControls.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timerFin
            // 
            this.timerFin.Interval = 15;
            this.timerFin.Tick += new System.EventHandler(this.timerFin_Tick);
            // 
            // timerMarcacao
            // 
            this.timerMarcacao.Interval = 15;
            this.timerMarcacao.Tick += new System.EventHandler(this.timerMarcacao_Tick);
            // 
            // timerConf
            // 
            this.timerConf.Interval = 15;
            this.timerConf.Tick += new System.EventHandler(this.timerConf_Tick);
            // 
            // timerReparacao
            // 
            this.timerReparacao.Interval = 15;
            this.timerReparacao.Tick += new System.EventHandler(this.timerReparacao_Tick);
            // 
            // Form_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 824);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEsquerdo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Dashboard";
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelEsquerdo.ResumeLayout(false);
            this.panelConfig.ResumeLayout(false);
            this.panelReparacao.ResumeLayout(false);
            this.panelMarcacao.ResumeLayout(false);
            this.panel_Fin.ResumeLayout(false);
            this.panelOrcamento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_reparacao;
        private System.Windows.Forms.Button btn_veiculo;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel panelOrcamento;
        private System.Windows.Forms.Button btn_buscarOrcamento;
        private System.Windows.Forms.Button btn_incluirOrcamento;
        private System.Windows.Forms.Button btn_orcamento;
        private System.Windows.Forms.Panel panel_Fin;
        private System.Windows.Forms.Button btn_faturacao;
        private System.Windows.Forms.Button btn_consultarFaturacao;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Timer timerFin;
        private System.Windows.Forms.Panel panelMarcacao;
        private System.Windows.Forms.Button btn_calendario;
        private System.Windows.Forms.Button btn_incluirAgend;
        private System.Windows.Forms.Button btn_marcacao;
        private System.Windows.Forms.Timer timerMarcacao;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button btn_configuracao;
        private System.Windows.Forms.Timer timerConf;
        private System.Windows.Forms.Button btn_listaMarcacoes;
        private System.Windows.Forms.Panel panelReparacao;
        private System.Windows.Forms.Button btn_reparacoes;
        private System.Windows.Forms.Button btn_IncluirServico;
        private System.Windows.Forms.Button btn_ConsultarReparacoes;
        private System.Windows.Forms.Timer timerReparacao;
        private System.Windows.Forms.Button btn_sobre;
    }
}

