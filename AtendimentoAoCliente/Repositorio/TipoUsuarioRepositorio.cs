using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;


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
            //var entry = _context.Entry(tipoUsuario);
            //Console.WriteLine($"Estado do Setor: {entry.State}");
            
            _context.SaveChanges();

            //int result = _context.SaveChanges();
           //Console.WriteLine($"Número de Entradas Modificadas: {result}");
        }

        public void EditarTipoUsuario(string nome, int id)
        {
            var tipoUsuario = _context.TipoUsuarios.Find(id);

            tipoUsuario.Descricao = nome;

            _context.SaveChanges();

        }

        public void DeletarTipoUsuario(int id)
        {
            var tipoUsuario = _context.TipoUsuarios.Find(id);

            _context.TipoUsuarios.Remove(tipoUsuario);

            _context.SaveChanges();
        }

        public IQueryable<TipoUsuario> ObtemTipos()
        {
            return _context.TipoUsuarios;
        }

        public IQueryable<TipoUsuario> ObtemTipoPorNome(string nome)
        {
            return _context.TipoUsuarios.Where(s => s.Descricao == nome);
        }

        
    }
}
