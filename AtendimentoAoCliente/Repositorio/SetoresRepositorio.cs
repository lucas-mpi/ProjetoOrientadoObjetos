using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;

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

        public void EditarSetor(string descricao, int id)
        {
            var setor = _context.Setores.Find(id);
            setor.Descricao = descricao;
            _context.SaveChanges();
        }

        public void DeletarSetor(int id)
        {
            var setor = _context.Setores.Find(id);
            _context.Setores.Remove(setor);
            _context.SaveChanges();
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


