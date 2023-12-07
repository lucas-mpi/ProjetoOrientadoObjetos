using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;


namespace AtendimentoAoCliente.Repositorio
{
    
    internal class ClienteRepositorio
    {
        private readonly AtendimentoDbContext _context;
        
        public ClienteRepositorio()
        {
            _context = new AtendimentoDbContext();
        }

        public IQueryable<Clientes> ObtemClientes()
        {
            return _context.Clientes;
        } 

        public void AdicionarCliente(Clientes clientes)
        {
            _context.Clientes.Add(clientes); 
            _context.SaveChanges(); 
        }

        public void DeletarCliente(int id)
        {
            var cliente = _context.Clientes.Find(id);
            
            _context.Clientes.Remove(cliente);

            _context.SaveChanges();
        }
    }

    

}
