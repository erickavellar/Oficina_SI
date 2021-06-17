using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class ClientesLista
    {
        public static List<Cliente> clientes;

         

        public static void GravarInfo(int Id, string Nome, string Apelido, string Morada, string Codigo_postal, string Localidade, int Telemovel, string Email, int Nif)
        {
            Cliente novocliente = new Cliente();
            novocliente.Id_Cliente = Id;
            novocliente.Nome = Nome;
            novocliente.Apelido = Apelido;
            novocliente.Morada = Morada;
            novocliente.CodPostal = Codigo_postal;
            novocliente.Localidade = Localidade;
            novocliente.Telemovel = Telemovel;
            novocliente.Email = Email;
            novocliente.Nif = Nif;

            clientes.Add(novocliente);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Clientes.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Cliente novocliente in clientes)
            {
                ficheiro.WriteLine(novocliente.Id_Cliente); 
                ficheiro.WriteLine(novocliente.Nome);
                ficheiro.WriteLine(novocliente.Apelido);
                ficheiro.WriteLine(novocliente.Morada);
                ficheiro.WriteLine(novocliente.CodPostal);
                ficheiro.WriteLine(novocliente.Localidade);
                ficheiro.WriteLine(novocliente.Telemovel);
                ficheiro.WriteLine(novocliente.Email);
                ficheiro.WriteLine(novocliente.Nif);
            }
            ficheiro.Dispose();
        }
        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Clientes.txt";

            clientes = new List<Cliente>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);
                

                while (!ficheiro.EndOfStream)
                {
                    
                    int Id = Convert.ToInt32(ficheiro.ReadLine());
                    string Nome = ficheiro.ReadLine();
                    string Apelido = ficheiro.ReadLine();
                    string Morada = ficheiro.ReadLine();
                    string Codigo_Postal = ficheiro.ReadLine();
                    string Localidade = ficheiro.ReadLine();
                    int Telemovel = Convert.ToInt32(ficheiro.ReadLine());
                    string Email = ficheiro.ReadLine();
                    int Nif = Convert.ToInt32(ficheiro.ReadLine());


                    Cliente novocliente = new Cliente();

                    novocliente.Id_Cliente = Id;
                    novocliente.Nome = Nome;
                    novocliente.Apelido = Apelido;
                    novocliente.Morada = Morada;
                    novocliente.CodPostal = Codigo_Postal;
                    novocliente.Localidade = Localidade;
                    novocliente.Telemovel = Telemovel;
                    novocliente.Email = Email;
                    novocliente.Nif = Nif;

                    clientes.Add(novocliente);
                }

                ficheiro.Dispose();

            }
        }

        
    }
}
