using Quickbuy.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quickbuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }


        public DateTime DataPrevisaoEntrega  { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento  { get; set; }

        public ICollection<ItemPedido> ItensPedidos  { get; set; }


        public override void Validade()
        {
            LimparMensagemValidacao();

            if (ItensPedidos.Any())
            
                AdicionarCritica("Lista de Pedidos nao ser vazia");
           
            if (string.IsNullOrEmpty(Cep))
                AdicionarCritica("ListCritica - Cep deve  estar preenchido");
        }
    }
}
