using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormDashboard
{
    public partial class UC_Inicio : UserControl
    {
        public UC_Inicio()
        {
            InitializeComponent();

            
        }
        /// <summary>
        /// É um método para manipular os botões com o panel
        /// </summary>
        /// <param name="c"></param>
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(c);
        }
        /// <summary>
        /// Serve para enviar os botões e label para tras e aparecer o User Form que for selecionado
        /// </summary>
        private void SendToBack()
        {
            btn_ClienteCaminho.SendToBack();
            btn_VeiculoCaminho.SendToBack();
            btn_ReparacaoCaminho.SendToBack();
            btn_MarcacaoCaminho.SendToBack();
            btn_OrcamentoCaminho.SendToBack();
            btn_FaturacaoCaminho.SendToBack();
            label4.SendToBack();
            label5.SendToBack();
            label6.SendToBack();
            label7.SendToBack();
            label8.SendToBack();
            label9.SendToBack();
        }
        /// <summary>
        /// Botão para carregar o UC Gestão Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ClienteCaminho_Click(object sender, EventArgs e)
        {
            UC_GestaoClientes gc = new UC_GestaoClientes();
            AddControlsToPanel(gc);
            SendToBack();
        }
        /// <summary>
        /// botãqo para aparecer o form do veiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_VeiculoCaminho_Click(object sender, EventArgs e)
        {
            UC_GestaoVeiculos gv = new UC_GestaoVeiculos();
            AddControlsToPanel(gv);
            SendToBack();
        }
        /// <summary>
        /// botão para aparecer o form reparação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ReparacaoCaminho_Click(object sender, EventArgs e)
        {
            UC_Reparacao r = new UC_Reparacao();
            AddControlsToPanel(r);
            SendToBack();
        }
        /// <summary>
        /// botão para aparecer o form Marcação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_MarcacaoCaminho_Click(object sender, EventArgs e)
        {
            UC_IncluirMarcacao im = new UC_IncluirMarcacao();
            AddControlsToPanel(im);
            SendToBack();
        }
        /// <summary>
        /// botão para aparecer o form Orçamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OrcamentoCaminho_Click(object sender, EventArgs e)
        {
            UC_GestaoOrcamento go = new UC_GestaoOrcamento();
            AddControlsToPanel(go);
            SendToBack();
        }
        /// <summary>
        /// botão para aparecer o form Faturação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FaturacaoCaminho_Click(object sender, EventArgs e)
        {
            UC_GestaoFaturacao gf = new UC_GestaoFaturacao();
            AddControlsToPanel(gf);
            SendToBack();
        }
    }
}
