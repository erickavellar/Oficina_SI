using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class OrcamentosLista
    {
        public static List<Orcamento> orcamentos;



        public static void GravarInfo(int Id_Orcamento, string Cliente, string Veiculo, string Servico, string Funcionario, double PrecoVenda, double TaxaIVA, double TotalAPagar, DateTime Data_Emissao, DateTime Validade)
        {
            Orcamento novoOrcamento = new Orcamento();
            novoOrcamento.Id_Orcamento = Id_Orcamento;
            novoOrcamento.Cliente = Cliente;
            novoOrcamento.Veiculo = Veiculo;
            novoOrcamento.Servico = Servico;
            novoOrcamento.Funcionario = Funcionario;
            novoOrcamento.PrecoVenda = PrecoVenda;
            novoOrcamento.TaxaIVA = TaxaIVA;
            novoOrcamento.TotalAPagar = TotalAPagar;
            novoOrcamento.Data_Emissao = Data_Emissao;
            novoOrcamento.Validade = Validade;

            orcamentos.Add(novoOrcamento);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Orçamentos.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Orcamento novoOrcamento in orcamentos)
            {
                ficheiro.WriteLine(novoOrcamento.Id_Orcamento); 
                ficheiro.WriteLine(novoOrcamento.Cliente); 
                ficheiro.WriteLine(novoOrcamento.Veiculo);
                ficheiro.WriteLine(novoOrcamento.Servico);  
                ficheiro.WriteLine(novoOrcamento.Funcionario);
                ficheiro.WriteLine(novoOrcamento.PrecoVenda);
                ficheiro.WriteLine(novoOrcamento.TaxaIVA);
                ficheiro.WriteLine(novoOrcamento.TotalAPagar);
                ficheiro.WriteLine(novoOrcamento.Data_Emissao); 
                ficheiro.WriteLine(novoOrcamento.Validade);
                
            }
            ficheiro.Dispose();
        }
        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Orçamentos.txt";

            orcamentos = new List<Orcamento>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);

                while (!ficheiro.EndOfStream)
                {
                    int Id_Orcamento = Convert.ToInt32(ficheiro.ReadLine());
                    string Cliente = ficheiro.ReadLine();
                    string Veiculo = ficheiro.ReadLine();
                    string Servico = ficheiro.ReadLine();
                    string Funcionario = ficheiro.ReadLine();
                    double PrecoVenda = Convert.ToDouble(ficheiro.ReadLine());
                    double TaxaIVA = Convert.ToDouble(ficheiro.ReadLine());
                    double TotalAPagar = Convert.ToDouble(ficheiro.ReadLine());
                    DateTime Data_Emissao = Convert.ToDateTime(ficheiro.ReadLine());
                    DateTime Validade = Convert.ToDateTime(ficheiro.ReadLine());


                    Orcamento novoOrcamento = new Orcamento();

                    novoOrcamento.Id_Orcamento = Id_Orcamento;
                    novoOrcamento.Cliente = Cliente;
                    novoOrcamento.Veiculo = Veiculo;
                    novoOrcamento.Servico = Servico;
                    novoOrcamento.Funcionario = Funcionario;
                    novoOrcamento.PrecoVenda = PrecoVenda;
                    novoOrcamento.TaxaIVA = TaxaIVA;
                    novoOrcamento.TotalAPagar = TotalAPagar;
                    novoOrcamento.Data_Emissao = Data_Emissao;
                    novoOrcamento.Validade = Validade;

                    orcamentos.Add(novoOrcamento);
                }

                ficheiro.Dispose();

            }
        }

    }
}
