
namespace FormDashboard
{
    partial class EditarMarcacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMarcacaoForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_funcionario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_idMarcacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_hora = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_assunto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dt_dataAlerta = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_dataFim = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.label2.Location = new System.Drawing.Point(431, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 1076;
            this.label2.Text = "Editar Marcação";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_funcionario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_nome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tb_idMarcacao);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 67);
            this.panel2.TabIndex = 1077;
            // 
            // cb_funcionario
            // 
            this.cb_funcionario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_funcionario.Location = new System.Drawing.Point(709, 21);
            this.cb_funcionario.Name = "cb_funcionario";
            this.cb_funcionario.Size = new System.Drawing.Size(230, 29);
            this.cb_funcionario.TabIndex = 1027;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label7.Location = new System.Drawing.Point(598, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 1026;
            this.label7.Text = "Funcionário:";
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nome.Location = new System.Drawing.Point(329, 21);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(233, 27);
            this.tb_nome.TabIndex = 1025;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(262, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 1015;
            this.label3.Text = "Nome:";
            // 
            // tb_idMarcacao
            // 
            this.tb_idMarcacao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_idMarcacao.Enabled = false;
            this.tb_idMarcacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_idMarcacao.Location = new System.Drawing.Point(129, 21);
            this.tb_idMarcacao.Name = "tb_idMarcacao";
            this.tb_idMarcacao.Size = new System.Drawing.Size(82, 27);
            this.tb_idMarcacao.TabIndex = 1014;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 1013;
            this.label1.Text = "ID Marcação:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dt_hora);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_assunto);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tb_email);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dt_dataAlerta);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dt_dataFim);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dt_dataInicio);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(23, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 174);
            this.panel3.TabIndex = 1078;
            // 
            // dt_hora
            // 
            this.dt_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_hora.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_hora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_hora.Location = new System.Drawing.Point(700, 17);
            this.dt_hora.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_hora.Name = "dt_hora";
            this.dt_hora.RightToLeftLayout = true;
            this.dt_hora.ShowUpDown = true;
            this.dt_hora.Size = new System.Drawing.Size(247, 27);
            this.dt_hora.TabIndex = 1029;
            this.dt_hora.Value = new System.DateTime(2021, 4, 28, 23, 15, 38, 0);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(644, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 1026;
            this.label5.Text = "Hora:";
            // 
            // tb_assunto
            // 
            this.tb_assunto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_assunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_assunto.Location = new System.Drawing.Point(86, 118);
            this.tb_assunto.Name = "tb_assunto";
            this.tb_assunto.Size = new System.Drawing.Size(227, 27);
            this.tb_assunto.TabIndex = 1025;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label11.Location = new System.Drawing.Point(9, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 1024;
            this.label11.Text = "Assunto:";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(700, 114);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(247, 27);
            this.tb_email.TabIndex = 1023;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label10.Location = new System.Drawing.Point(638, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 1022;
            this.label10.Text = "Email:";
            // 
            // dt_dataAlerta
            // 
            this.dt_dataAlerta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dataAlerta.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataAlerta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataAlerta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataAlerta.Location = new System.Drawing.Point(177, 74);
            this.dt_dataAlerta.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_dataAlerta.Name = "dt_dataAlerta";
            this.dt_dataAlerta.Size = new System.Drawing.Size(136, 27);
            this.dt_dataAlerta.TabIndex = 1021;
            this.dt_dataAlerta.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label9.Location = new System.Drawing.Point(9, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 19);
            this.label9.TabIndex = 1020;
            this.label9.Text = "Data de Alerta:";
            // 
            // dt_dataFim
            // 
            this.dt_dataFim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dataFim.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataFim.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataFim.Location = new System.Drawing.Point(700, 69);
            this.dt_dataFim.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_dataFim.Name = "dt_dataFim";
            this.dt_dataFim.Size = new System.Drawing.Size(247, 27);
            this.dt_dataFim.TabIndex = 1019;
            this.dt_dataFim.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label8.Location = new System.Drawing.Point(587, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 1018;
            this.label8.Text = "Data de Fim:";
            // 
            // dt_dataInicio
            // 
            this.dt_dataInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dt_dataInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataInicio.Location = new System.Drawing.Point(177, 21);
            this.dt_dataInicio.MinDate = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dt_dataInicio.Name = "dt_dataInicio";
            this.dt_dataInicio.Size = new System.Drawing.Size(136, 27);
            this.dt_dataInicio.TabIndex = 1017;
            this.dt_dataInicio.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 1015;
            this.label6.Text = "Data da Marcação:";
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
            this.btn_salvar.Location = new System.Drawing.Point(886, 443);
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
            this.btn_cancelar.Location = new System.Drawing.Point(724, 443);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(140, 40);
            this.btn_cancelar.TabIndex = 1080;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // EditarMarcacaoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 514);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarMarcacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarMarcacaoForm";
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_idMarcacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_assunto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dt_dataAlerta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dt_dataFim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_dataInicio;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private System.Windows.Forms.DateTimePicker dt_hora;
        private System.Windows.Forms.ComboBox cb_funcionario;
    }
}