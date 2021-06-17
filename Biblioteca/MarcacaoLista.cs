using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class MarcacaoLista
    {
        public static List<Marcacao> marcacoes;



        public static void GravarInfo(int Id_Marcacao, string NomeCompleto, string Usuario, DateTime Data_Agenda, DateTime Hora, DateTime Data_Expira, DateTime Data_Alerta, string Email, string Assunto)
        {
            Marcacao novamarcacao = new Marcacao();
            novamarcacao.Id_Marcacao = Id_Marcacao;
            novamarcacao.NomeCompleto = NomeCompleto;
            novamarcacao.Usuario = Usuario;
            novamarcacao.Data_Agendada = Data_Agenda;
            novamarcacao.Hora = Hora;
            novamarcacao.Data_Expira = Data_Expira;
            novamarcacao.Data_Alerta = Data_Alerta;            
            novamarcacao.Email = Email;
            novamarcacao.Assunto = Assunto;

            marcacoes.Add(novamarcacao);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Marcações.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Marcacao novamarcacao in marcacoes)
            {
                ficheiro.WriteLine(novamarcacao.Id_Marcacao);
                ficheiro.WriteLine(novamarcacao.NomeCompleto);
                ficheiro.WriteLine(novamarcacao.Usuario);
                ficheiro.WriteLine(novamarcacao.Data_Agendada);
                ficheiro.WriteLine(novamarcacao.Hora);
                ficheiro.WriteLine(novamarcacao.Data_Expira);
                ficheiro.WriteLine(novamarcacao.Data_Alerta);                
                ficheiro.WriteLine(novamarcacao.Email);
                ficheiro.WriteLine(novamarcacao.Assunto);
            }
            ficheiro.Dispose();
        }
        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Marcações.txt";

            marcacoes = new List<Marcacao>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                while (!ficheiro.EndOfStream)
                {
                    int Id_Marcacao = Convert.ToInt32(ficheiro.ReadLine());
                    string NomeCompleto = ficheiro.ReadLine();
                    string Usuario = ficheiro.ReadLine();
                    DateTime Data_Agendada = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Hora = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Data_Expira = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Data_Alerta = Convert.ToDateTime(ficheiro.ReadLine());                    
                    string Email = ficheiro.ReadLine();
                    string Assunto = ficheiro.ReadLine();
                    


                    Marcacao novamarcacao = new Marcacao();

                    novamarcacao.Id_Marcacao = Id_Marcacao;
                    novamarcacao.NomeCompleto = NomeCompleto;
                    novamarcacao.Data_Agendada = Data_Agendada;
                    novamarcacao.Hora = Hora;
                    novamarcacao.Data_Expira = Data_Expira;
                    novamarcacao.Data_Alerta = Data_Alerta;
                    novamarcacao.Usuario = Usuario;
                    novamarcacao.Email = Email;
                    novamarcacao.Assunto = Assunto;

                    marcacoes.Add(novamarcacao);
                }

                ficheiro.Dispose();

            }
        }
    }
}
