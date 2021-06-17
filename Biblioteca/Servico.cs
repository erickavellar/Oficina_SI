using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Servico
    {
        public int Cod_reparacao { get; set; }

        public string Descricao { get; set; }

        public decimal Preco_Custo { get; set; }

        public decimal Preco_Venda { get; set; }


        public string NomeCompleto
        {
            get
            {
                return $"Cod: {Cod_reparacao} | Descrição: {Descricao} | Preço de Custo: {Preco_Custo} | Preço de Venda: {Preco_Venda}";
            }
        }

        public string NomeCompleto2
        {
            get
            {
                return $"Cod: {Cod_reparacao} | Descrição: {Descricao} | Preço de Custo: {Preco_Custo} | Preço de Venda: {Preco_Venda}";
            }
        }

        public string InfoServico
        {
            get
            {
                return $"{Descricao}";
            }
        }

        public string PrecoCusto
        {
            get
            {
                return $"{Preco_Custo}";
            }
        }



        public string DescricaoServico
        {
            get
            {
                return $"Cod: {Cod_reparacao} - Descrição: {Descricao}";
            }
        }

        public string PrecoCustoServico
        {
            get
            {
                return $"Preço de Custo: {Preco_Custo}";
            }
        }

        public string PrecoVenda
        {
            get
            {
                return $"{Preco_Venda}";
            }
        }
    }
}
