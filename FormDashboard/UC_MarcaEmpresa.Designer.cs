
namespace FormDashboard
{
    partial class UC_MarcaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MarcaEmpresa));
            this.pb_inicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_inicio
            // 
            this.pb_inicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_inicio.Image = ((System.Drawing.Image)(resources.GetObject("pb_inicio.Image")));
            this.pb_inicio.Location = new System.Drawing.Point(0, 0);
            this.pb_inicio.Name = "pb_inicio";
            this.pb_inicio.Size = new System.Drawing.Size(1055, 733);
            this.pb_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_inicio.TabIndex = 0;
            this.pb_inicio.TabStop = false;
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pb_inicio);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(1055, 733);
            ((System.ComponentModel.ISupportInitialize)(this.pb_inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_inicio;
    }
}
