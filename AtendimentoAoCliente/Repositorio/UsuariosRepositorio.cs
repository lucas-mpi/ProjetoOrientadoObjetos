﻿using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Contextos;


namespace AtendimentoAoCliente.Repositorio
{
    internal class UsuariosRepositorio
    {
        private readonly AtendimentoDbContext _context;

        public UsuariosRepositorio()
        {
            _context = new AtendimentoDbContext();
        }

        public IQueryable<Usuarios> ObtemUsuarios()
        {
            return _context.Usuarios;
        }

        public IQueryable<Usuarios> ObtemUsuariosPorId(int id)
        {
            return _context.Usuarios.Where(u => u.UsuarioId == id);
        }

        public void AdicionarUsuarios(Usuarios usuarios)
        {
            _context.Usuarios.Add(usuarios);
            _context.SaveChanges();
        }

        public IQueryable<Usuarios> ConfirmaCredenciais(string usuario, string senha)
        {

            return _context.Usuarios.Where(u => u.NomeUsuario == usuario && u.Senha == senha);
            
        }

        
        

        
    }
}
