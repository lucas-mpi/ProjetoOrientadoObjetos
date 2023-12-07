using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;


namespace AtendimentoAoCliente.UI
{
    internal class TipoUsuarioUI
    {
        readonly TipoUsuarioRepositorio tipo = new();

        public void CadastrarTipoUsuario()
        {
            Console.WriteLine("Cadastro novo tipo de funcionário:");
            Console.Write("Descrição: ");

            string tipoUsuario = Console.ReadLine();

            TipoUsuario novoTipo = new(tipoUsuario);

            tipo.AdicionarTipoUsuario(novoTipo);

        }

        public void EditarTipoUsuario()
        {
            ListarTipoUsuario();
            Console.WriteLine("Editar Usuario: ");
            Console.Write("Informe o Id do tipo do usuaário: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe a nova descrição: ");
            string novoNome = Console.ReadLine();

            tipo.EditarTipoUsuario(novoNome, id);



        }

        public void ListarTipoUsuario()
        {
           

            var tiposUsuarios = tipo.ObtemTipos();

            Console.WriteLine("Tipos cadastrados: ");

            foreach (var lista in tiposUsuarios)
            {
                Console.WriteLine($"Código: {lista.TipoUsuarioId}");
                Console.WriteLine($"Descrição: {lista.Descricao}");
                Console.WriteLine("----------------------------------");
            }

        }

        public void ExcluirTipoUsuario()
        {
            ListarTipoUsuario();
            Console.WriteLine("Excluir tipo de usuário");
            Console.Write("Informe o Id do tipo a ser excluído: ");
            
            int id = int.Parse(Console.ReadLine());
            
            tipo.DeletarTipoUsuario(id);

        }
    }
}
