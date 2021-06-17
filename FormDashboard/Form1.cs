using Biblioteca;
using FormDashboard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormDashboard
{
    public partial class Form_Dashboard : Form
    {
        int PanelWidth;
        bool colapsou;
        private bool isCollapsed, isCollapsed_fin, isCollapsed_marc, isCollapsed_config, isCollapsed_rep;

        public Form_Dashboard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelEsquerdo.Width;
            colapsou = false;
            UC_MarcaEmpresa me = new UC_MarcaEmpresa();
            AddControlsToPanel(me);
            ClientesLista.LerInfo();
            VeiculosLista.LerInfo();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_inicio);
            UC_Inicio inicio = new UC_Inicio();
            AddControlsToPanel(inicio);
        }

        private void btn_veiculo_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_veiculo);
            UC_GestaoVeiculos gc = new UC_GestaoVeiculos();
            AddControlsToPanel(gc);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (colapsou)
            {
                panelEsquerdo.Width = panelEsquerdo.Width + 10;
                if (panelEsquerdo.Width >= PanelWidth)
                {
                    timer1.Stop();
                    colapsou = false;
                    this.Refresh();
                }
            }
            else
            {
                panelEsquerdo.Width = panelEsquerdo.Width - 10;
                if (panelEsquerdo.Width <= 40)
                {
                    timer1.Stop();
                    colapsou = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbl_data.Text = dt.ToString();
        }

        private void btn_reparacao_Click(object sender, EventArgs e)
        {
            timerReparacao.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btn_orcamento.Image = Resources.icons8_collapse_arrow_20px;
                panelOrcamento.Height += 10;
                if (panelOrcamento.Size == panelOrcamento.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btn_orcamento.Image = Resources.icons8_expand_arrow_20px;
                panelOrcamento.Height -= 10;
                if (panelOrcamento.Size == panelOrcamento.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }        

        private void btn_cliente_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btn_cliente);
            UC_GestaoClientes gc = new UC_GestaoClientes();
            AddControlsToPanel(gc);
        }
        
        private void btn_incluirOrcamento_Click_1(object sender, EventArgs e)
        {
            moveSidePanel(btn_incluirOrcamento);
            UC_GestaoOrcamento io = new UC_GestaoOrcamento();
            AddControlsToPanel(io);
        }

        private void btn_buscarOrcamento_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_buscarOrcamento);
            UC_BuscarOrcamentos bo = new UC_BuscarOrcamentos();
            AddControlsToPanel(bo);
        }

        private void btn_orcamento_Click(object sender, EventArgs e)
        {
            timer2.Start();
            panel_Fin.SendToBack();
            panelConfig.SendToBack();
        }
        
        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            timerFin.Start();
            panelConfig.SendToBack();
        }
             
        private void btn_calendario_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_calendario);
            UC_Calendario cal = new UC_Calendario();
            AddControlsToPanel(cal);
        }

        private void btn_incluirAgend_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_incluirAgend);
            UC_IncluirMarcacao im = new UC_IncluirMarcacao();
            AddControlsToPanel(im);
        }
        
        private void timerMarcacao_Tick(object sender, EventArgs e)
        {
            if (isCollapsed_marc)
            {
                btn_marcacao.Image = Resources.icons8_collapse_arrow_20px;
                panelMarcacao.Height += 10;
                if (panelMarcacao.Size == panelMarcacao.MaximumSize)
                {
                    timerMarcacao.Stop();
                    isCollapsed_marc = false;
                }
            }
            else
            {
                btn_marcacao.Image = Resources.icons8_expand_arrow_20px;
                panelMarcacao.Height -= 10;
                if (panelMarcacao.Size == panelMarcacao.MinimumSize)
                {
                    timerMarcacao.Stop();
                    isCollapsed_marc = true;
                }
            }
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_usuario);
            UC_Funcionario f = new UC_Funcionario();
            AddControlsToPanel(f);
        }

        private void btn_configuracao_Click(object sender, EventArgs e)
        {
            timerConf.Start();            
        }

        private void btn_listaMarcacoes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_listaMarcacoes);
            UC_ListaDeMarcacoes lm = new UC_ListaDeMarcacoes();
            AddControlsToPanel(lm);
        }

        private void btn_consultarFaturacao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_consultarFaturacao);
            UC_ConsultarFaturacao cf = new UC_ConsultarFaturacao();
            AddControlsToPanel(cf);
        }

        private void btn_faturacao_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_financeiro);
            UC_GestaoFaturacao ft = new UC_GestaoFaturacao();
            AddControlsToPanel(ft);
        }

        private void btn_IncluirServico_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_reparacao);
            UC_GestaoReparacao gc = new UC_GestaoReparacao();
            AddControlsToPanel(gc);
        }

        private void btn_reparacoes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_reparacoes);
            UC_Reparacao rep = new UC_Reparacao();
            AddControlsToPanel(rep);
        }

        private void btn_ConsultarReparacoes_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_reparacao);
            UC_ListaDeReparacao lr = new UC_ListaDeReparacao();
            AddControlsToPanel(lr);
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            moveSidePanel(btn_sobre);
            UC_Sobre sobre = new UC_Sobre();
            AddControlsToPanel(sobre);
        }

        private void timerReparacao_Tick(object sender, EventArgs e)
        {
            if (isCollapsed_rep)
            {
                btn_reparacao.Image = Resources.icons8_collapse_arrow_20px;
                panelReparacao.Height += 10;
                if (panelReparacao.Size == panelReparacao.MaximumSize)
                {
                    timerReparacao.Stop();
                    isCollapsed_rep = false;
                }
            }
            else
            {
                btn_reparacao.Image = Resources.icons8_expand_arrow_20px;
                panelReparacao.Height -= 10;
                if (panelReparacao.Size == panelReparacao.MinimumSize)
                {
                    timerReparacao.Stop();
                    isCollapsed_rep = true;
                }
            }
        }

        private void timerConf_Tick(object sender, EventArgs e)
        {
            if (isCollapsed_config)
            {
                btn_configuracao.Image = Resources.icons8_collapse_arrow_20px;
                panelConfig.Height += 10;
                if (panelConfig.Size == panelConfig.MaximumSize)
                {
                    timerConf.Stop();
                    isCollapsed_config = false;
                }
            }
            else
            {
                btn_configuracao.Image = Resources.icons8_expand_arrow_20px;
                panelConfig.Height -= 10;
                if (panelConfig.Size == panelConfig.MinimumSize)
                {
                    timerConf.Stop();
                    isCollapsed_config = true;
                }
            }
        }

        private void btn_marcacao_Click(object sender, EventArgs e)
        {
            timerMarcacao.Start();
            panelOrcamento.SendToBack();
            panel_Fin.SendToBack();
            panelConfig.SendToBack();
        }

        private void timerFin_Tick(object sender, EventArgs e)
        {
            if (isCollapsed_fin)
            {
                btn_financeiro.Image = Resources.icons8_collapse_arrow_20px;
                panel_Fin.Height += 10;
                if (panel_Fin.Size == panel_Fin.MaximumSize)
                {
                    timerFin.Stop();
                    isCollapsed_fin = false;
                }
            }
            else
            {
                btn_financeiro.Image = Resources.icons8_expand_arrow_20px;
                panel_Fin.Height -= 10;
                if (panel_Fin.Size == panel_Fin.MinimumSize)
                {
                    timerFin.Stop();
                    isCollapsed_fin = true;
                }
            }
        }
    }
}
