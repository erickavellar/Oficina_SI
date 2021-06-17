
namespace FormDashboard
{
    partial class UC_GestaoReparacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GestaoReparacao));
            this.ServicosListBox = new System.Windows.Forms.ListBox();
            this.btn_editar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_apagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_precoVenda = new System.Windows.Forms.TextBox();
            this.tb_precoCusto = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.tb_codReparacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServicosListBox
            // 
            this.ServicosListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServicosListBox.FormattingEnabled = true;
            this.ServicosListBox.ItemHeight = 21;
            this.ServicosListBox.Location = new System.Drawing.Point(39, 381);
            this.ServicosListBox.Name = "ServicosListBox";
            this.ServicosListBox.Size = new System.Drawing.Size(818, 319);
            this.ServicosListBox.TabIndex = 1016;
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
            this.btn_editar.Location = new System.Drawing.Point(865, 659);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(181, 41);
            this.btn_editar.TabIndex = 1014;
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
            this.btn_apagar.Location = new System.Drawing.Point(865, 608);
            this.btn_apagar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(181, 41);
            this.btn_apagar.TabIndex = 1015;
            this.btn_apagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
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
            this.btn_salvar.Location = new System.Drawing.Point(848, 308);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(181, 41);
            this.btn_salvar.TabIndex = 1011;
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
            this.btn_cancelar.Location = new System.Drawing.Point(650, 308);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 41);
            this.btn_cancelar.TabIndex = 1013;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_precoVenda
            // 
            this.tb_precoVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_precoVenda.Location = new System.Drawing.Point(758, 248);
            this.tb_precoVenda.Name = "tb_precoVenda";
            this.tb_precoVenda.Size = new System.Drawing.Size(271, 27);
            this.tb_precoVenda.TabIndex = 1007;
            // 
            // tb_precoCusto
            // 
            this.tb_precoCusto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_precoCusto.Location = new System.Drawing.Point(758, 190);
            this.tb_precoCusto.Name = "tb_precoCusto";
            this.tb_precoCusto.Size = new System.Drawing.Size(271, 27);
            this.tb_precoCusto.TabIndex = 1005;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_descricao.Location = new System.Drawing.Point(143, 248);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(271, 27);
            this.tb_descricao.TabIndex = 1003;
            // 
            // tb_codReparacao
            // 
            this.tb_codReparacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_codReparacao.Enabled = false;
            this.tb_codReparacao.Location = new System.Drawing.Point(143, 190);
            this.tb_codReparacao.Name = "tb_codReparacao";
            this.tb_codReparacao.Size = new System.Drawing.Size(271, 27);
            this.tb_codReparacao.TabIndex = 1012;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(613, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 1023;
            this.label10.Text = "Preço de Venda:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(624, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 1020;
            this.label5.Text = "Preço de Custo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 1022;
            this.label3.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 1002;
            this.label1.Text = "Cod:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 47);
            this.panel1.TabIndex = 1024;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Incluir Serviços";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(474, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 1026;
            this.label4.Text = "Serviços";
            // 
            // btn_listar
            // 
            this.btn_listar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_listar.BackColor = System.Drawing.Color.Orange;
            this.btn_listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar.Location = new System.Drawing.Point(247, 325);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(75, 29);
            this.btn_listar.TabIndex = 1063;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(102, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 19);
            this.label11.TabIndex = 1062;
            this.label11.Text = "Lista de Serviços:";
            // 
            // UC_GestaoReparacao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServicosListBox);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tb_precoVenda);
            this.Controls.Add(this.tb_precoCusto);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_codReparacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Name = "UC_GestaoReparacao";
            this.Size = new System.Drawing.Size(1055, 733);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServicosListBox;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_editar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_apagar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private System.Windows.Forms.TextBox tb_precoVenda;
        private System.Windows.Forms.TextBox tb_precoCusto;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.TextBox tb_codReparacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label label11;
    }
}
