﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quickbuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public static bool Any { get; internal set; }
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
            
                AdicionarCritica("Não foi identificado o produto");
            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi adicionada");
        }
    }
}
