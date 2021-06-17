using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public string Departamento { get; set; }

        public string Morada { get; set; }

        public string Localidade { get; set; }

        public string CodPostal { get; set; }

        public int Nif { get; set; }

        public int Telemovel { get; set; } 

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmacaoEmail { get; set; }

        


        public string InfoUsuario
        {
            get
            {
                return $"ID: {Id_Usuario} | Nome: {Nome} {Apelido} | Departamento: {Departamento} | Morada: {Morada} | Localidade: {Localidade} | " + 
                    $"Código-Postal: {CodPostal} | NIF: {Nif} | Telemóvel: {Telemovel} | Email: {Email} | " + 
                    $"Password: {Password} | Conf. Email: {ConfirmacaoEmail}";
            }
        }

        public string InfoUsuario2
        {
            get
            {
                return $"{Id_Usuario} - {Nome} {Apelido}";
            }
        }

        public string InfoUsuario3
        {
            get
            {
                return $"{Id_Usuario} - {Nome} {Apelido} - {Departamento}";
            }
        }

        public string InfoUsuario4
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }

        public string pw
        {
            get
            {
                return $"{Password}";
            }
        }

    }
}
