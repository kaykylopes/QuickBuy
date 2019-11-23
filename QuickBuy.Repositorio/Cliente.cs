using Quickbuy.Dominio.Entidades;
using QuickBuy.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepostirio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepostirio.Adicionar(usuario);
        }
    }
}
