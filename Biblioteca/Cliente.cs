using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class Cliente
    {
        public int Id_Cliente { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Morada { get; set; }

        public string CodPostal { get; set; }

        public string Localidade { get; set; }

        public int Telemovel { get; set; }

        public string Email { get; set; }

        public int Nif { get; set; }

        


        public string NomeCompleto
        {
            get
            {
                return $"Nome: {Nome} {Apelido} | Morada: {Morada} | Código-Postal: {CodPostal} | Localidade: {Localidade} | Telemóvel: {Telemovel} | Email: {Email} | NIF: {Nif}";
            }
        }

        public string NomeCompleto2
        {
            get
            {
                return $"{Id_Cliente} - {Nome} {Apelido}";
            }
        }

        public string MoradaCliente
        {
            get
            {
                return $"Morada: {Morada}";
            }
        }

        public string CodigoPostal
        {
            get
            {
                return $"Código-Postal: {CodPostal}";
            }
        }

        public string LocalidadeCliente
        {
            get
            {
                return $"Localidade: {Localidade}";
            }
        }

        public string TelemovelCliente
        {
            get
            {
                return $"Telemóvel: {Telemovel}";
            }
        }

        public string EmailCliente
        {
            get
            {
                return $"Email: {Email}";
            }
        }

        public string NifCliente
        {
            get
            {
                return $"NIF: {Nif}";
            }
        }

    }
}
