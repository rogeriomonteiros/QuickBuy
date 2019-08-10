using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        public ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagem();

            if (!this.ItemPedidos.Any())
                AdicionarCritica("Item de Pedido não pode estar vazio");

            if (string.IsNullOrEmpty(this.CEP))
                AdicionarCritica("É preciso informar o CEP");
        }
    }
}
