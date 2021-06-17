using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class Veiculo
    {

        public int Id_Veiculo { get; set; }

        public string Cliente { get; set; }

        public string Matricula { get; set; }

        public string Categoria { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string Cor { get; set; }


        public string NomeCompleto
        {
            get
            {
                return $"ID Veículo: {Id_Veiculo} | Cliente: {Cliente} | Matrícula: {Matricula} | Categoria: {Categoria} | Marca: {Marca} | Modelo: {Modelo} | Ano: {Ano} | Cor: {Cor}";
            }
        }

        public string NomeCompleto2
        {
            get
            {
                return $"ID Veículo: {Id_Veiculo} - Matrícula: {Matricula} - Categoria: {Categoria} - Marca: {Marca} - Modelo: {Modelo} - Ano: {Ano} - Cor: {Cor}";
            }
        }

        public string InfoVeiculo
        {
            get
            {
                return $"{Id_Veiculo} - {Matricula} ";
            }
        }

        public string ClienteVeiculo
        {
            get
            {
                return $"Cliente: {Cliente}";
            }
        }

        public string MatriculaVeiculo
        {
            get
            {
                return $"Matrícula: {Matricula}";
            }
        }

        public string CategoriaVeiculo
        {
            get
            {
                return $"Categoria: {Categoria}";
            }
        }

        public string MarcaVeiculo
        {
            get
            {
                return $"Marca: {Marca}";
            }
        }

        public string ModeloVeiculo
        {
            get
            {
                return $"Modelo: {Modelo}";
            }
        }

        public string AnoVeiculo
        {
            get
            {
                return $"Ano: {Ano}";
            }
        }

        public string CorVeiculo
        {
            get
            {
                return $"Cor: {Cor}";
            }
        }

    }
}
