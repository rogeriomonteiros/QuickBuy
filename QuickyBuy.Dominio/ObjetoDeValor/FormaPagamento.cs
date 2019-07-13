﻿using QuickBuy.Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return (this.Id == (int)TipoFormaPagamentoEnum.Boleto); }
        }

        public bool EhCartaoCredito
        {
            get { return (this.Id == (int)TipoFormaPagamentoEnum.CartaoDeCredito); }
        }

        public bool EhDeposito
        {
            get { return (this.Id == (int)TipoFormaPagamentoEnum.Deposito); }
        }

        public bool EhNaoDefinido
        {
            get { return (this.Id == (int)TipoFormaPagamentoEnum.NaoDefinido); }
        }

    }

}
