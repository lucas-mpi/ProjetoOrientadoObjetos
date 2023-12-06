using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Repositorio
{
    internal class SetoresRepositorio
    {
        private readonly AtendimentoDbContext _context;

        public SetoresRepositorio()
        {
            _context = new AtendimentoDbContext();
        }

        public void AdicionarSetores(Setores setores)
        {
            _context.Setores.Add(setores);
            _context.SaveChanges();
        }

        public void EditarSetorPorId(Setores setorAtualizado)
        {
            _context.Setores.Update(setorAtualizado);
        }

        public IQueryable<Setores> ObtemSetores()
        {
            return _context.Setores;
        }

        public IQueryable<Setores> ObtemSetorPorNome(string nome)
        {
            return _context.Setores.Where(s => s.Descricao == nome);
        }

    }
}


