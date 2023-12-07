using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;

namespace AtendimentoAoCliente.UI
{
    internal class SetoresUI
    {

        readonly SetoresRepositorio setor = new();

        public void CadastrarSetor()
        {
            

            Console.WriteLine("Nome do setor: ");
            string nomeSetor = Console.ReadLine();

            Setores setores = new(nomeSetor);

            setor.AdicionarSetores(setores);

        }

        public void EditarSetor()
        {

            ListarSetor();

            Console.Write("Informe o Id do setor a ser editado: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe o novo nome do setor: ");
            string novoNome = Console.ReadLine();

            setor.EditarSetor(novoNome, id);

        }

        public void ListarSetor()
        {
            var setores = setor.ObtemSetores();

            Console.WriteLine("Setores Cadastrados: ");
            foreach (var listaSetor in  setores)
            {
                Console.WriteLine($"Código: {listaSetor.SetorId}");
                Console.WriteLine($"Descrição: {listaSetor.Descricao}");
                Console.WriteLine("----------------------------------");
            }
        }

        public void ExcluirSetor()
        {
            ListarSetor();

            Console.Write("Informe o Id do setor a ser excluído: ");
            int id = int.Parse(Console.ReadLine());

            setor.DeletarSetor(id);
            
        }
    }
}
