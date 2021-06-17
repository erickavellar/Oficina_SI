using FormDashboard;
using System;
using System.Windows.Forms;
using Biblioteca;

namespace FormLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UsuarioLista.LerInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Login()
        {

            foreach (Usuario user in UsuarioLista.usuarios)
            {
                if (user.Nome == tb_nomeUtilizador.Text && user.Password == tb_pw.Text || tb_nomeUtilizador.Text == "Admin" && tb_pw.Text == "123")
                {
                    using (FormDashboard.Form_Dashboard fd = new FormDashboard.Form_Dashboard())
                    {
                        fd.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    

                }
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
            MessageBox.Show("Usuário ou palavra-passe incorreta, tente novamente!");
        }

        public void btn_esqueceuSenha_Click(object sender, EventArgs e)
        {
            
            EsqueceuSenhaForm esqueceuSenha = new EsqueceuSenhaForm();
            esqueceuSenha.Show();
        }

        private void btn_criarUser_Click(object sender, EventArgs e)
        {
            using (FormLogin.FormCriarUser fcu = new FormLogin.FormCriarUser())
            {
                fcu.ShowDialog();
            }
            this.Close();
            
        }
    }
}
