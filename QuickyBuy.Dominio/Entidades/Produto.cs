using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descriacao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagem();

            if (this.Preco <= 0)
                AdicionarCritica("O produto precisa ter um preço");
        }
    }
}
