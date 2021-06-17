using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Biblioteca;

namespace FormLogin
{
    public partial class EsqueceuSenhaForm : Form
    {
        
        string password;

        public EsqueceuSenhaForm()
        {
            InitializeComponent();
            UsuarioLista.LerInfo();
           
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_para.Text, @"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$"))
            {
                listBox1.DataSource = UsuarioLista.usuarios.Where(x => x.Email == tb_para.Text).ToList();
                listBox1.DisplayMember = "pw";

                password = listBox1.Text.ToString();
                EnviarEmail(password); 
            }
            else
            {
                MessageBox.Show("Email com formatação errada. Insira um email válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void EnviarEmail(string pw)
        {
            using (SmtpClient cliente = new SmtpClient("usuario.dominio.com"))
            {
                MailMessage Message = new MailMessage();
                Message.From = new MailAddress("erick.merhy.avellar@formandos.cinel.pt");
                Message.To.Add(tb_para.Text);
                Message.Body = $"Password:{pw}";
                Message.Subject = "Ativação de conta";

                cliente.Host = "smtp.office365.com";
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential("erick.merhy.avellar@formandos.cinel.pt", "Programador2021");
                cliente.EnableSsl = true;
                cliente.Send(Message);
                MessageBox.Show("Foi enviado as iinformações para o seu email !");
                this.Dispose();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
