using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class FaturacaoLista
    {
        public static List<Faturacao> faturacoes;

        

        public static void GravarInfo(int NumFat, int Rep, string Cliente, string Veiculo, string Servico, string Funcionario, string TipoPagamento, double PrecoCusto, double TaxaIVA, double TotalAPagar, DateTime Emissao, DateTime Vencimento)
        {
            Faturacao novafaturacao = new Faturacao();
            novafaturacao.NumFat = Rep;
            novafaturacao.Reparacao = NumFat;
            novafaturacao.Cliente = Cliente;
            novafaturacao.Veiculo = Veiculo;
            novafaturacao.Servico = Servico;
            novafaturacao.Funcionario = Funcionario;
            novafaturacao.TipoPagamento = TipoPagamento;
            novafaturacao.PrecoCusto = PrecoCusto;
            novafaturacao.TaxaIVA = TaxaIVA;
            novafaturacao.TotalAPagar = TotalAPagar;
            novafaturacao.Emissao = Emissao;
            novafaturacao.Vencimento = Vencimento;

            faturacoes.Add(novafaturacao);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Faturações.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Faturacao novafaturacao in faturacoes)
            {
                ficheiro.WriteLine(novafaturacao.NumFat);
                ficheiro.WriteLine(novafaturacao.Reparacao);
                ficheiro.WriteLine(novafaturacao.Cliente);
                ficheiro.WriteLine(novafaturacao.Veiculo);
                ficheiro.WriteLine(novafaturacao.Servico);
                ficheiro.WriteLine(novafaturacao.Funcionario);
                ficheiro.WriteLine(novafaturacao.TipoPagamento);
                ficheiro.WriteLine(novafaturacao.PrecoCusto);
                ficheiro.WriteLine(novafaturacao.TaxaIVA);
                ficheiro.WriteLine(novafaturacao.TotalAPagar);
                ficheiro.WriteLine(novafaturacao.Emissao);
                ficheiro.WriteLine(novafaturacao.Vencimento);


            }
            ficheiro.Dispose();
        }

        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Faturações.txt";

            faturacoes = new List<Faturacao>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);


                while (!ficheiro.EndOfStream)
                {

                    int NumFat = Convert.ToInt32(ficheiro.ReadLine());
                    int Rep = Convert.ToInt32(ficheiro.ReadLine());
                    string Cliente = ficheiro.ReadLine();
                    string Veiculo = ficheiro.ReadLine();
                    string Servico = ficheiro.ReadLine();
                    string Funcionario = ficheiro.ReadLine();
                    string TipoPagamento = ficheiro.ReadLine();
                    double PrecoCusto = Convert.ToDouble(ficheiro.ReadLine());
                    double TaxaIVA = Convert.ToDouble(ficheiro.ReadLine());
                    double TotalAPagar = Convert.ToDouble(ficheiro.ReadLine());
                    DateTime Emissao = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Vencimento = Convert.ToDateTime(ficheiro.ReadLine());


                    Faturacao novafaturacao = new Faturacao();

                    novafaturacao.NumFat = NumFat;
                    novafaturacao.Reparacao = Rep;
                    novafaturacao.Cliente = Cliente;
                    novafaturacao.Veiculo = Veiculo;
                    novafaturacao.Servico = Servico;
                    novafaturacao.Funcionario = Funcionario;
                    novafaturacao.TipoPagamento = TipoPagamento;
                    novafaturacao.PrecoCusto = PrecoCusto;
                    novafaturacao.TaxaIVA = TaxaIVA;
                    novafaturacao.TotalAPagar = TotalAPagar;
                    novafaturacao.Emissao = Emissao;
                    novafaturacao.Vencimento = Vencimento;


                    faturacoes.Add(novafaturacao);
                }

                ficheiro.Dispose();

            }
        }

    }
}
