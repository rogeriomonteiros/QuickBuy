using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagem();

            if (this.ProdutoId == 0)
                AdicionarCritica("Item do pedido deve ter um produto");
            if (this.Quantidade <= 0)
                AdicionarCritica("Item do pedido precisa tem uma quantidade");
        }
    }
}
