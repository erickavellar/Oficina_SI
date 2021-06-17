
namespace FormDashboard
{
    partial class UC_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sobre));
            this.tabControlVersao = new System.Windows.Forms.TabControl();
            this.tp_versao = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tp_sobre = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlVersao.SuspendLayout();
            this.tp_versao.SuspendLayout();
            this.tp_sobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVersao
            // 
            this.tabControlVersao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControlVersao.Controls.Add(this.tp_versao);
            this.tabControlVersao.Controls.Add(this.tp_sobre);
            this.tabControlVersao.Location = new System.Drawing.Point(0, 112);
            this.tabControlVersao.Name = "tabControlVersao";
            this.tabControlVersao.SelectedIndex = 0;
            this.tabControlVersao.Size = new System.Drawing.Size(763, 514);
            this.tabControlVersao.TabIndex = 0;
            // 
            // tp_versao
            // 
            this.tp_versao.BackColor = System.Drawing.Color.LightGray;
            this.tp_versao.Controls.Add(this.label1);
            this.tp_versao.Location = new System.Drawing.Point(4, 30);
            this.tp_versao.Name = "tp_versao";
            this.tp_versao.Padding = new System.Windows.Forms.Padding(3);
            this.tp_versao.Size = new System.Drawing.Size(755, 480);
            this.tp_versao.TabIndex = 0;
            this.tp_versao.Text = "Versão";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 437);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tp_sobre
            // 
            this.tp_sobre.BackColor = System.Drawing.Color.LightGray;
            this.tp_sobre.Controls.Add(this.label2);
            this.tp_sobre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tp_sobre.Location = new System.Drawing.Point(4, 30);
            this.tp_sobre.Name = "tp_sobre";
            this.tp_sobre.Padding = new System.Windows.Forms.Padding(3);
            this.tp_sobre.Size = new System.Drawing.Size(755, 480);
            this.tp_sobre.TabIndex = 1;
            this.tp_sobre.Text = "Sobre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(727, 456);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(318, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 1041;
            this.label3.Text = "Sobre";
            // 
            // UC_Sobre
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControlVersao);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UC_Sobre";
            this.Size = new System.Drawing.Size(763, 626);
            this.tabControlVersao.ResumeLayout(false);
            this.tp_versao.ResumeLayout(false);
            this.tp_sobre.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVersao;
        private System.Windows.Forms.TabPage tp_versao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tp_sobre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
