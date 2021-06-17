using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Orcamento
    {
        private double _taxaIVA;

        private double _totalAPagar;



        public int Id_Orcamento { get; set; }

        public string Cliente { get; set; }

        public string Veiculo { get; set; }

        public string Servico { get; set; }

        public string Funcionario { get; set; }

        public DateTime Data_Emissao { get; set; }

        public DateTime Validade { get; set; }

        public double PrecoVenda { get; set; }

        public double TaxaIVA
        {
            get
            {
                return _taxaIVA;
            }
            set
            {
                _taxaIVA = value;
            }
        }

        public double TotalAPagar { get; set; }

        public Orcamento()
        {
            _taxaIVA = 0.23;
        }

        public double ValorAPagar()
        {
            return (PrecoVenda * TaxaIVA) + PrecoVenda;
        }

        public string InfoCompleto
        {
            get
            {
                return $"Id: {Id_Orcamento} | Cliente: {Cliente} | Veículo: {Veiculo} | Serviço: {Servico} | Funcionário: {Funcionario} | " +
                    $"Preço: {PrecoVenda} | Taxa de IVA: {TaxaIVA} | Total à Pagar: {ValorAPagar()} |Data de Emissão: {Data_Emissao} | Validade: {Validade}";
            }
        }

        public string ClienteOrcamento
        {
            get
            {
                return $"Id: {Id_Orcamento} - Cliente: {Cliente}";
            }
        }

        public string VeiculoOrcamento
        {
            get
            {
                return $"Veículo: {Veiculo}";
            }
        }

        public string ServicoOrcamento
        {
            get
            {
                return $"Serviço: {Servico}";
            }
        }

        public string FuncionarioOrcamento
        {
            get
            {
                return $"Funcionário: {Funcionario}";
            }
        }

        public string EmissaoOrcamento
        {
            get
            {
                return $"Data de Emissão: {Data_Emissao}";
            }
        }

        public string ValidadeOrcamento
        {
            get
            {
                return $"Validade: {Validade}";
            }
        }
    }
}
