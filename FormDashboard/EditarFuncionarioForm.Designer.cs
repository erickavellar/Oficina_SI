
namespace FormDashboard
{
    partial class EditarFuncionarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionarioForm));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cp = new System.Windows.Forms.MaskedTextBox();
            this.tb_telemovel = new System.Windows.Forms.MaskedTextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nomeUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_confEmail = new System.Windows.Forms.TextBox();
            this.tb_nif = new System.Windows.Forms.TextBox();
            this.tb_localidade = new System.Windows.Forms.TextBox();
            this.tb_apelidoUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(443, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 28);
            this.label2.TabIndex = 1022;
            this.label2.Text = "Editar Usuário";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_confEmail);
            this.panel1.Controls.Add(this.tb_nif);
            this.panel1.Controls.Add(this.tb_localidade);
            this.panel1.Controls.Add(this.tb_apelidoUser);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_cp);
            this.panel1.Controls.Add(this.tb_telemovel);
            this.panel1.Controls.Add(this.tb_id);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tb_pw);
            this.panel1.Controls.Add(this.tb_morada);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_nomeUser);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 442);
            this.panel1.TabIndex = 1023;
            // 
            // tb_cp
            // 
            this.tb_cp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_cp.Location = new System.Drawing.Point(32, 242);
            this.tb_cp.Mask = "00000-9999";
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(94, 27);
            this.tb_cp.TabIndex = 68;
            // 
            // tb_telemovel
            // 
            this.tb_telemovel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_telemovel.Location = new System.Drawing.Point(32, 305);
            this.tb_telemovel.Name = "tb_telemovel";
            this.tb_telemovel.Size = new System.Drawing.Size(194, 27);
            this.tb_telemovel.TabIndex = 67;
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(32, 49);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(75, 27);
            this.tb_id.TabIndex = 66;
            this.tb_id.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label15.Location = new System.Drawing.Point(32, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 22);
            this.label15.TabIndex = 65;
            this.label15.Text = "ID: ";
            this.label15.Visible = false;
            // 
            // tb_pw
            // 
            this.tb_pw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_pw.Location = new System.Drawing.Point(32, 368);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(343, 27);
            this.tb_pw.TabIndex = 60;
            // 
            // tb_morada
            // 
            this.tb_morada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_morada.Location = new System.Drawing.Point(32, 175);
            this.tb_morada.Multiline = true;
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(343, 27);
            this.tb_morada.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(32, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 22);
            this.label10.TabIndex = 64;
            this.label10.Text = "Telemóvel: ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(32, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "Código-Postal: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(32, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Morada: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(32, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 61;
            this.label3.Text = "Password: ";
            // 
            // tb_nomeUser
            // 
            this.tb_nomeUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nomeUser.Location = new System.Drawing.Point(32, 112);
            this.tb_nomeUser.Name = "tb_nomeUser";
            this.tb_nomeUser.Size = new System.Drawing.Size(343, 27);
            this.tb_nomeUser.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(32, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "Nome: ";
            // 
            // cb_departamento
            // 
            this.cb_departamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Items.AddRange(new object[] {
            "Administrativo",
            "Mecânico",
            "Diretor"});
            this.cb_departamento.Location = new System.Drawing.Point(635, 49);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(348, 29);
            this.cb_departamento.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label7.Location = new System.Drawing.Point(635, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 22);
            this.label7.TabIndex = 79;
            this.label7.Text = "Departamento: ";
            this.label7.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_email.Location = new System.Drawing.Point(635, 305);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(348, 27);
            this.tb_email.TabIndex = 72;
            // 
            // tb_confEmail
            // 
            this.tb_confEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_confEmail.Location = new System.Drawing.Point(635, 368);
            this.tb_confEmail.Name = "tb_confEmail";
            this.tb_confEmail.Size = new System.Drawing.Size(348, 27);
            this.tb_confEmail.TabIndex = 74;
            // 
            // tb_nif
            // 
            this.tb_nif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_nif.Location = new System.Drawing.Point(635, 242);
            this.tb_nif.Name = "tb_nif";
            this.tb_nif.Size = new System.Drawing.Size(348, 27);
            this.tb_nif.TabIndex = 71;
            // 
            // tb_localidade
            // 
            this.tb_localidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_localidade.Location = new System.Drawing.Point(635, 175);
            this.tb_localidade.Name = "tb_localidade";
            this.tb_localidade.Size = new System.Drawing.Size(348, 27);
            this.tb_localidade.TabIndex = 70;
            // 
            // tb_apelidoUser
            // 
            this.tb_apelidoUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_apelidoUser.Location = new System.Drawing.Point(635, 112);
            this.tb_apelidoUser.Name = "tb_apelidoUser";
            this.tb_apelidoUser.Size = new System.Drawing.Size(348, 27);
            this.tb_apelidoUser.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(635, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 22);
            this.label13.TabIndex = 78;
            this.label13.Text = "Conf. Email: ";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(635, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 77;
            this.label12.Text = "Email: ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(635, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 76;
            this.label11.Text = "NIF: ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(635, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 22);
            this.label9.TabIndex = 75;
            this.label9.Text = "Localidade: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(635, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 73;
            this.label6.Text = "Apelido: ";
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
            this.btn_salvar.Location = new System.Drawing.Point(865, 581);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(181, 41);
            this.btn_salvar.TabIndex = 1024;
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
            this.btn_cancelar.Location = new System.Drawing.Point(667, 581);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 41);
            this.btn_cancelar.TabIndex = 1025;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // EditarFuncionarioForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1059, 646);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFuncionarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFuncionarioForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox tb_cp;
        private System.Windows.Forms.MaskedTextBox tb_telemovel;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nomeUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_confEmail;
        private System.Windows.Forms.TextBox tb_nif;
        private System.Windows.Forms.TextBox tb_localidade;
        private System.Windows.Forms.TextBox tb_apelidoUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
    }
}