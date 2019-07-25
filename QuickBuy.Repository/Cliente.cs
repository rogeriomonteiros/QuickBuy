using QuickBuy.Dominio.Entidades;
using QuickBuy.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepository = new UsuarioRepository();

            var usuario = new Usuario();

            usuarioRepository.Adicionar(usuario);
        }
    }
}
