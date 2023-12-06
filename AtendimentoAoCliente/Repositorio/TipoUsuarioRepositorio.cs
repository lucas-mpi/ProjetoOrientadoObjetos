using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Repositorio
{
    internal class TipoUsuarioRepositorio
    {
        private readonly AtendimentoDbContext _context;

        public TipoUsuarioRepositorio()
        {
            _context = new AtendimentoDbContext();
        }

        public void AdicionarTipoUsuario(TipoUsuario tipoUsuario)
        {
            _context.TipoUsuarios.Add(tipoUsuario);
            _context.SaveChanges();
        }

        public IQueryable<TipoUsuario> obtemTipos()
        {
            return _context.TipoUsuarios;
        }

        public IQueryable<TipoUsuario> ObtemTipoPorNome(string nome)
        {
            return _context.TipoUsuarios.Where(s => s.Descricao == nome);
        }

        
    }
}
