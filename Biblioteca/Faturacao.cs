using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Faturacao
    {
        private double _taxaIVA;

        private double _totalAPagar;


        public int NumFat { get; set; }

        public int Reparacao { get; set; }

        public string Cliente { get; set; }

        public string Veiculo { get; set; }

        public string Servico { get; set; }

        public string Funcionario { get; set; }

        public string TipoPagamento { get; set; }

        public double PrecoCusto { get; set; }

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

        public DateTime Emissao { get; set; }

        public DateTime Vencimento { get; set; }

        public string Assunto { get; set; }

        public string Email { get; set; }



        public Faturacao()
        {
            _taxaIVA = 0.23;
        }


        public double ValorAPagar()
        {
            return (PrecoCusto * TaxaIVA) + PrecoCusto;
        }


        public string InfoFaturacao
        {
            get
            {
                return $"Nº Faturação: {NumFat} | Reparação: {Reparacao} | Cliente: {Cliente} | Veiculo: {Veiculo} | Serviço: {Servico} | Funcionário: {Funcionario} | Tipo de Pagamento: {TipoPagamento} | Preço de Custo: {PrecoCusto} | Taxa de IVA: {TaxaIVA} | Total à Pagar: {ValorAPagar()} | Emissão: {Emissao} | Vencimento: {Vencimento} | Assunto: {Assunto} | Email: {Email}";
            }
        }

        public string InfoFaturacao2
        {
            get
            {
                return $"Nº Faturação: {NumFat} | Reparação: {Reparacao} | Cliente: {Cliente} | Veiculo: {Veiculo} | Serviço: {Servico} | Funcionário: {Funcionario} | Tipo de Pagamento: {TipoPagamento} | Preço de Custo: {PrecoCusto} | Taxa de IVA: {TaxaIVA} | Total à Pagar: {ValorAPagar()} | Emissão: {Emissao} | Vencimento: {Vencimento}";
            }
        }

        public string ClienteFatura
        {
            get
            {
                return $"Cliente: {Cliente}";
            }
        }

        public string VeiculoFatura
        {
            get
            {
                return $"Veiculo: {Veiculo}";
            }
        }

        public string ServicoFatura
        {
            get
            {
                return $"Serviço: {Servico}";
            }
        }

        public string FuncionarioFatura
        {
            get
            {
                return $"Funcionário: {Funcionario}";
            }
        }

        public string TipoPagFatura
        {
            get
            {
                return $"Tipo de Pagamento: {TipoPagamento}";
            }
        }

        public string PrecoCustoFatura
        {
            get
            {
                return $"Preço de Custo: {PrecoCusto}";
            }
        }

        public string TotalPagar
        {
            get
            {
                return $"Total à Pagar: {ValorAPagar()}";
            }
        }

        public string DataEmissao
        {
            get
            {
                return $"Emissão: {Emissao}";
            }
        }

        public string DataVencimento
        {
            get
            {
                return $"Vencimento: {Vencimento}";
            }
        }

    }
}
