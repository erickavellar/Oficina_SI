using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Marcacao
    {
        public int text_idMarcacao;

        public int Id_Marcacao { get; set; }

        public string NomeCompleto { get; set; }

        public string Usuario { get; set; }

        public DateTime Data_Agendada { get; set; }

        public DateTime Hora { get; set; }

        public DateTime Data_Expira { get; set; }

        public DateTime Data_Alerta { get; set; }

        public string Email { get; set; }

        public string Assunto { get; set; }


        

        public string DescricaoCompleta
        {
            get
            {
                return $"ID Marcação: {Id_Marcacao} | Nome: {NomeCompleto} | Funcionário: {Usuario} | Data Agendada: {Data_Agendada} | " +
                    $"Hora: {Hora} | Data de Expiração: {Data_Expira} | Data de Alerta: {Data_Alerta} | " +
                    $"Email: {Email} | Assunto: {Assunto}";
            }
             
        }

        public string Nome
        {
            get
            {
                return $"{NomeCompleto}";
            }

        }

        public string Funcionario
        {
            get
            {
                return $"{Usuario}";
            }

        }

        public string email
        {
            get
            {
                return $"{Email}";
            }

        }

    }
}
