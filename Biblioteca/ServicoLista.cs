using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class ServicoLista
    {
        public static List<Servico> reparacoes;



        public static void GravarInfo(int Cod_reparacao, string Descricao, decimal Preco_Custo, decimal Preco_Venda)
        {
            Servico novareparacoes = new Servico();
            novareparacoes.Cod_reparacao = Cod_reparacao;
            novareparacoes.Descricao = Descricao;
            novareparacoes.Preco_Custo = Preco_Custo;
            novareparacoes.Preco_Venda = Preco_Venda;

            reparacoes.Add(novareparacoes);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Serviços.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Servico novareparacoes in reparacoes)
            {
                ficheiro.WriteLine(novareparacoes.Cod_reparacao);
                ficheiro.WriteLine(novareparacoes.Descricao);
                ficheiro.WriteLine(novareparacoes.Preco_Custo);
                ficheiro.WriteLine(novareparacoes.Preco_Venda);
            }
            ficheiro.Dispose();
        }
        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Serviços.txt";

            reparacoes = new List<Servico>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                while (!ficheiro.EndOfStream)
                {
                    int cod_reparacao = Convert.ToInt32(ficheiro.ReadLine());
                    string descricao = ficheiro.ReadLine();
                    decimal preco_custo = Convert.ToDecimal(ficheiro.ReadLine());
                    decimal preco_venda = Convert.ToDecimal(ficheiro.ReadLine());


                    Servico novareparacoes = new Servico();

                    novareparacoes.Cod_reparacao = cod_reparacao;
                    novareparacoes.Descricao = descricao;
                    novareparacoes.Preco_Custo = preco_custo;
                    novareparacoes.Preco_Venda = preco_venda;

                    reparacoes.Add(novareparacoes);
                }

                ficheiro.Dispose();

            }
        }
    }
}
