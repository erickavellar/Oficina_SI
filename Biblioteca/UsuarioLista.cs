using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class UsuarioLista
    {
        public static List<Usuario> usuarios;



        public static void GravarInfo(int Id, string Nome, string Apelido, string Departamento, string Morada, string Localidade, string Codigo_postal, int Nif, int Telemovel, string Email, string Password, string ConfEmail)
        {
            Usuario novousuario = new Usuario();
            novousuario.Id_Usuario = Id;
            novousuario.Nome = Nome;
            novousuario.Apelido = Apelido;
            novousuario.Departamento = Departamento;
            novousuario.Morada = Morada;
            novousuario.Localidade = Localidade;
            novousuario.CodPostal = Codigo_postal;
            novousuario.Nif = Nif;
            novousuario.Telemovel = Telemovel;
            novousuario.Email = Email;
            novousuario.Password = Password;
            novousuario.ConfirmacaoEmail = ConfEmail;


            usuarios.Add(novousuario);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Usuarios.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Usuario novousuario in usuarios)
            {
                ficheiro.WriteLine(novousuario.Id_Usuario);
                ficheiro.WriteLine(novousuario.Nome);
                ficheiro.WriteLine(novousuario.Apelido);
                ficheiro.WriteLine(novousuario.Departamento);
                ficheiro.WriteLine(novousuario.Morada);
                ficheiro.WriteLine(novousuario.Localidade);
                ficheiro.WriteLine(novousuario.CodPostal);
                ficheiro.WriteLine(novousuario.Nif);
                ficheiro.WriteLine(novousuario.Telemovel);
                ficheiro.WriteLine(novousuario.Email);
                ficheiro.WriteLine(novousuario.Password);
                ficheiro.WriteLine(novousuario.ConfirmacaoEmail);
            }
            ficheiro.Dispose();
        }

        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Usuarios.txt";

            usuarios = new List<Usuario>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                while (!ficheiro.EndOfStream)
                {
                    int Id = Convert.ToInt32(ficheiro.ReadLine());
                    string Nome = ficheiro.ReadLine();
                    string Apelido = ficheiro.ReadLine();
                    string Departamento = ficheiro.ReadLine();
                    string Morada = ficheiro.ReadLine();
                    string Localidade = ficheiro.ReadLine();
                    string Codigo_Postal = ficheiro.ReadLine();
                    int Nif = Convert.ToInt32(ficheiro.ReadLine());
                    int Telemovel = Convert.ToInt32(ficheiro.ReadLine());
                    string Email = ficheiro.ReadLine();
                    string Password = ficheiro.ReadLine();
                    string ConfEmail = ficheiro.ReadLine();



                    Usuario novousuario = new Usuario();

                    novousuario.Id_Usuario = Id;
                    novousuario.Nome = Nome;
                    novousuario.Apelido = Apelido;
                    novousuario.Departamento = Departamento;
                    novousuario.Morada = Morada;
                    novousuario.Localidade = Localidade;
                    novousuario.CodPostal = Codigo_Postal;
                    novousuario.Nif = Nif;
                    novousuario.Telemovel = Telemovel;
                    novousuario.Email = Email;
                    novousuario.Password = Password;
                    novousuario.ConfirmacaoEmail = ConfEmail;


                    usuarios.Add(novousuario);
                }

                ficheiro.Dispose();

            }
        }

    }
}
