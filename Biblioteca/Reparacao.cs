using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Reparacao
    {
        public int Id { get; set; }

        public string Cliente { get; set; }

        public string Veiculo { get; set; }

        public string Funcionario { get; set; }

        public decimal PrecoVenda { get; set; }

        public string Servico { get; set; }
        
        public DateTime Inicio { get; set; }

        public DateTime Final { get; set; }


        public string InfoReparacao
        {
            get
            {
                return $"ID: {Id} | Cliente: {Cliente} | Veiculo: {Veiculo} | Funcionário: {Funcionario} | Preço:{PrecoVenda} | Serviço: {Servico} | Data de Início: {Inicio} | Data Final: {Final}";
            }
        }

        public string IDReparacao
        {
            get
            {
                return $"{Id}";
            }
        }

        public string ClienteReparacao
        {
            get
            {
                return $"{Cliente}";
            }
        }

        public string VeiculoReparacao
        {
            get
            {
                return $"{Veiculo}";
            }
        }

        public string FuncionarioReparacao
        {
            get
            {
                return $"{Funcionario}";
            }
        }

        public string PrecoReparacao
        {
            get
            {
                return $"{PrecoVenda}";
            }
        }

        public string ServicoReparacao
        {
            get
            {
                return $"{Servico}";
            }
        }

        public string DataInicio
        {
            get
            {
                return $"{Inicio}";
            }
        }

        public string DataFim
        {
            get
            {
                return $"{Final}";
            }
        }
    }
}
