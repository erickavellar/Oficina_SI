using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class VeiculosLista
    {

        public static List<Veiculo> veiculos;


        

        public static void GravarInfo(int Id, string Cliente, string Matricula, string Categoria, string Marca, string Modelo, int Ano, string Cor)
        {
            Veiculo novoveiculo = new Veiculo();
            novoveiculo.Id_Veiculo = Id;
            novoveiculo.Cliente = Cliente;
            novoveiculo.Matricula = Matricula;
            novoveiculo.Categoria = Categoria;
            novoveiculo.Marca = Marca;
            novoveiculo.Modelo = Modelo;
            novoveiculo.Ano = Ano;
            novoveiculo.Cor = Cor;

            veiculos.Add(novoveiculo);

            GravarFicheiro();
        }

        public static void GravarFicheiro()
        {
            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Veiculos.txt";

            StreamWriter ficheiro = new StreamWriter(NomeFicheiro, false, Encoding.UTF8);

            foreach (Veiculo novoveiculo in veiculos)
            {
                ficheiro.WriteLine(novoveiculo.Id_Veiculo);
                ficheiro.WriteLine(novoveiculo.Cliente);
                ficheiro.WriteLine(novoveiculo.Matricula);
                ficheiro.WriteLine(novoveiculo.Categoria);
                ficheiro.WriteLine(novoveiculo.Marca);
                ficheiro.WriteLine(novoveiculo.Modelo);
                ficheiro.WriteLine(novoveiculo.Ano);
                ficheiro.WriteLine(novoveiculo.Cor); 
                

            }
            ficheiro.Dispose();
        }

        public static void LerInfo()
        {

            string Pasta = Directory.GetCurrentDirectory();
            string NomeFicheiro = Pasta + @"Veiculos.txt";

            veiculos = new List<Veiculo>();

            if (File.Exists(NomeFicheiro))
            {

                StreamReader ficheiro = new StreamReader(NomeFicheiro, Encoding.UTF8);
                

                while (!ficheiro.EndOfStream)
                {
                    
                    int Id = Convert.ToInt32(ficheiro.ReadLine());
                    string Cliente = ficheiro.ReadLine();
                    string Matricula = ficheiro.ReadLine();
                    string Categoria = ficheiro.ReadLine();
                    string Marca = ficheiro.ReadLine();
                    string Modelo = ficheiro.ReadLine();
                    int Ano = Convert.ToInt32(ficheiro.ReadLine());
                    string Cor = ficheiro.ReadLine();


                    Veiculo novoveiculo = new Veiculo();

                    novoveiculo.Id_Veiculo = Id;
                    novoveiculo.Cliente = Cliente;
                    novoveiculo.Matricula = Matricula;
                    novoveiculo.Categoria = Categoria;
                    novoveiculo.Marca = Marca;
                    novoveiculo.Modelo = Modelo;
                    novoveiculo.Ano = Ano;
                    novoveiculo.Cor = Cor;


                    veiculos.Add(novoveiculo);
                }

                ficheiro.Dispose();

            }
        }
    }
}
