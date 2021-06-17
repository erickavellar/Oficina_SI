
namespace FormDashboard
{
    partial class EditarVeiculoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarVeiculoForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria = new MetroFramework.Controls.MetroComboBox();
            this.cb_marca = new MetroFramework.Controls.MetroComboBox();
            this.tb_cor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_cliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(419, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 1057;
            this.label2.Text = "Editar Veículo";
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
            this.btn_salvar.Location = new System.Drawing.Point(806, 367);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(181, 41);
            this.btn_salvar.TabIndex = 1048;
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
            this.btn_cancelar.Location = new System.Drawing.Point(608, 367);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(181, 41);
            this.btn_cancelar.TabIndex = 1049;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_modelo
            // 
            this.tb_modelo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_modelo.Location = new System.Drawing.Point(716, 258);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(271, 27);
            this.tb_modelo.TabIndex = 1046;
            // 
            // tb_ano
            // 
            this.tb_ano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_ano.Location = new System.Drawing.Point(136, 318);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(271, 27);
            this.tb_ano.TabIndex = 1047;
            // 
            // tb_matricula
            // 
            this.tb_matricula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_matricula.Location = new System.Drawing.Point(136, 190);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(271, 27);
            this.tb_matricula.TabIndex = 1043;
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(136, 120);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(271, 27);
            this.tb_id.TabIndex = 1051;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(638, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 1052;
            this.label8.Text = "Modelo:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(85, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 1053;
            this.label7.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 1054;
            this.label6.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(619, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 1055;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 1056;
            this.label3.Text = "Matricula:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 1050;
            this.label1.Text = "ID:";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.ItemHeight = 23;
            this.cb_categoria.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camião"});
            this.cb_categoria.Location = new System.Drawing.Point(716, 188);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(271, 29);
            this.cb_categoria.TabIndex = 1058;
            this.cb_categoria.UseSelectable = true;
            // 
            // cb_marca
            // 
            this.cb_marca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.ItemHeight = 23;
            this.cb_marca.Items.AddRange(new object[] {
            "Abarth",
            "Aixam",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Austin",
            "Bentley",
            "BMW",
            "Cadillac",
            "Caterham",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Dacia",
            "Daewoo",
            "Daihatsu",
            "Datsun",
            "Dodge",
            "DS",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Jaguar",
            "JDM",
            "Jeep",
            "Joint",
            "Kia",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Ligier",
            "Lincoln",
            "Lotus",
            "Maserati",
            "Maybach",
            "Mazda",
            "Mercedes-Benz",
            "MG",
            "Microcar ",
            "MINI",
            "Mitsubishi",
            "Moncayo",
            "Morris",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Rolls Royce",
            "Rover",
            "Saab",
            "Seat",
            "Skoda",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "Tata",
            "Tesla",
            "Toyota",
            "UMM ",
            "Volkswagen",
            "Volvo"});
            this.cb_marca.Location = new System.Drawing.Point(136, 252);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(271, 29);
            this.cb_marca.TabIndex = 1059;
            this.cb_marca.UseSelectable = true;
            // 
            // tb_cor
            // 
            this.tb_cor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_cor.Location = new System.Drawing.Point(716, 318);
            this.tb_cor.Name = "tb_cor";
            this.tb_cor.Size = new System.Drawing.Size(271, 27);
            this.tb_cor.TabIndex = 1060;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(665, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 1061;
            this.label5.Text = "Cor:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(643, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 19);
            this.label9.TabIndex = 1062;
            this.label9.Text = "Cliente:";
            // 
            // cb_cliente
            // 
            this.cb_cliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_cliente.FormattingEnabled = true;
            this.cb_cliente.Location = new System.Drawing.Point(716, 118);
            this.cb_cliente.Name = "cb_cliente";
            this.cb_cliente.Size = new System.Drawing.Size(271, 29);
            this.cb_cliente.TabIndex = 1063;
            // 
            // EditarVeiculoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 443);
            this.Controls.Add(this.cb_cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_cor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarVeiculoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarVeiculoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancelar;
        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cb_categoria;
        private MetroFramework.Controls.MetroComboBox cb_marca;
        private System.Windows.Forms.TextBox tb_cor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_cliente;
    }
}