
namespace FormDashboard
{
    partial class UC_ListaDeMarcacoes
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
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFiltro = new System.Windows.Forms.ListBox();
            this.cb_ordenar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(343, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(145, 28);
            this.label26.TabIndex = 1051;
            this.label26.Text = "Marcações";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(17, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 24);
            this.label25.TabIndex = 0;
            this.label25.Text = "Lista de Marcações";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel7.Controls.Add(this.label25);
            this.panel7.Location = new System.Drawing.Point(0, 87);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(845, 47);
            this.panel7.TabIndex = 1052;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtrar por :";
            // 
            // listBoxFiltro
            // 
            this.listBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxFiltro.FormattingEnabled = true;
            this.listBoxFiltro.HorizontalScrollbar = true;
            this.listBoxFiltro.ItemHeight = 21;
            this.listBoxFiltro.Location = new System.Drawing.Point(17, 254);
            this.listBoxFiltro.Name = "listBoxFiltro";
            this.listBoxFiltro.ScrollAlwaysVisible = true;
            this.listBoxFiltro.Size = new System.Drawing.Size(815, 361);
            this.listBoxFiltro.TabIndex = 1054;
            // 
            // cb_ordenar
            // 
            this.cb_ordenar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_ordenar.FormattingEnabled = true;
            this.cb_ordenar.Items.AddRange(new object[] {
            "Nome",
            "Funcionario",
            "Email"});
            this.cb_ordenar.Location = new System.Drawing.Point(17, 190);
            this.cb_ordenar.Name = "cb_ordenar";
            this.cb_ordenar.Size = new System.Drawing.Size(174, 29);
            this.cb_ordenar.TabIndex = 1055;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 21);
            this.label1.TabIndex = 1056;
            this.label1.Text = "Lista de Todas as Marcações :";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.BackColor = System.Drawing.Color.Gold;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(223, 190);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 1057;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(714, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1058;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_ListaDeMarcacoes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ordenar);
            this.Controls.Add(this.listBoxFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.Name = "UC_ListaDeMarcacoes";
            this.Size = new System.Drawing.Size(845, 639);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFiltro;
        private System.Windows.Forms.ComboBox cb_ordenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button button1;
    }
}
