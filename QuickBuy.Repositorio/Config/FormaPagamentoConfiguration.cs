﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quickbuy.Dominio.ObjetoValor;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder
                .Property(f => f.Id)
                .IsRequired();

            builder
                .Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
        
    }
}
