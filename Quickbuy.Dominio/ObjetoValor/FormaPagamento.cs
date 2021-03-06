﻿using Quickbuy.Dominio.Entidades;
using Quickbuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy.Dominio.ObjetoValor
{
    public class FormaPagamento :Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto 
        {
            get { return Id ==(int)TipoFormaPagamentoEnum.Boleto; }
        }

        public bool EhCartao
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }

        }
             public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.naoDefinido; }
        }

        public override void Validade()
        {
            throw new NotImplementedException();
        }
    }
}
