
namespace FormDashboard
{
    partial class ListaReparacaoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaReparacaoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.listBoxFiltro = new System.Windows.Forms.ListBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cb_ordenar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 47);
            this.panel1.TabIndex = 1071;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(624, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 47);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(17, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(208, 24);
            this.label25.TabIndex = 1;
            this.label25.Text = "Lista de Serviços";
            // 
            // listBoxFiltro
            // 
            this.listBoxFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxFiltro.FormattingEnabled = true;
            this.listBoxFiltro.HorizontalScrollbar = true;
            this.listBoxFiltro.ItemHeight = 21;
            this.listBoxFiltro.Location = new System.Drawing.Point(12, 215);
            this.listBoxFiltro.Name = "listBoxFiltro";
            this.listBoxFiltro.ScrollAlwaysVisible = true;
            this.listBoxFiltro.Size = new System.Drawing.Size(652, 361);
            this.listBoxFiltro.TabIndex = 1070;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Buscar.BackColor = System.Drawing.Color.Gold;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Location = new System.Drawing.Point(218, 133);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 29);
            this.btn_Buscar.TabIndex = 1069;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cb_ordenar
            // 
            this.cb_ordenar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_ordenar.FormattingEnabled = true;
            this.cb_ordenar.Items.AddRange(new object[] {
            "Descricao",
            "Preco Custo",
            "Preco Venda"});
            this.cb_ordenar.Location = new System.Drawing.Point(12, 133);
            this.cb_ordenar.Name = "cb_ordenar";
            this.cb_ordenar.Size = new System.Drawing.Size(174, 29);
            this.cb_ordenar.TabIndex = 1068;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1067;
            this.label2.Text = "Filtrar por :";
            // 
            // ListaReparacaoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(683, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxFiltro);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.cb_ordenar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaReparacaoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaReparacaoForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox listBoxFiltro;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cb_ordenar;
        private System.Windows.Forms.Label label2;
    }
}