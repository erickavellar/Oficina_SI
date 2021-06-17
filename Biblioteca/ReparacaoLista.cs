using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class ReparacaoLista
    {
        public static List<Reparacao> reparacoes;



        public static void GravarInfo(int Id, string Cliente, string Veiculo, string Funcionario, decimal Preco, string Servico, DateTime Inicio, DateTime Final)
        {
            Reparacao novoReparo = new Reparacao();
            novoReparo.Id = Id;
            novoReparo.Cliente = Cliente;
            novoReparo.Veiculo = Veiculo;
            novoReparo.Funcionario = Funcionario;
            novoReparo.PrecoVenda = Preco;
            novoReparo.Servico = Servico;
            novoReparo.Inicio = Inicio;
            novoReparo.Final = Final;

            reparacoes.Add(novoReparo);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Reparações.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Reparacao novoReparo in reparacoes)
            {
                ficheiro.WriteLine(novoReparo.Id);
                ficheiro.WriteLine(novoReparo.Cliente);
                ficheiro.WriteLine(novoReparo.Veiculo);
                ficheiro.WriteLine(novoReparo.Funcionario);
                ficheiro.WriteLine(novoReparo.PrecoVenda);
                ficheiro.WriteLine(novoReparo.Servico);
                ficheiro.WriteLine(novoReparo.Inicio);
                ficheiro.WriteLine(novoReparo.Final);


            }
            ficheiro.Dispose();
        }

        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Reparações.txt";

            reparacoes = new List<Reparacao>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);


                while (!ficheiro.EndOfStream)
                {

                    int Id = Convert.ToInt32(ficheiro.ReadLine());
                    string Cliente = ficheiro.ReadLine();
                    string Veiculo = ficheiro.ReadLine();
                    string Funcionario = ficheiro.ReadLine();
                    decimal Preco = Convert.ToDecimal(ficheiro.ReadLine());
                    string Servico = ficheiro.ReadLine();
                    DateTime Inicio = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Final = Convert.ToDateTime(ficheiro.ReadLine());


                    Reparacao novoReparo = new Reparacao();

                    novoReparo.Id = Id;
                    novoReparo.Cliente = Cliente;
                    novoReparo.Veiculo = Veiculo;
                    novoReparo.Funcionario = Funcionario;
                    novoReparo.PrecoVenda = Preco;
                    novoReparo.Servico = Servico;
                    novoReparo.Inicio = Inicio;
                    novoReparo.Final = Final;


                    reparacoes.Add(novoReparo);
                }

                ficheiro.Dispose();

            }
        }
    }
}
