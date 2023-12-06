using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.UI
{
    internal class SetoresUI
    {

        public void CadastrarSetor()
        {
            var setor = new SetoresRepositorio();

            Console.WriteLine("Nome do setor: ");
            string nomeSetor = Console.ReadLine();

            Setores setores = new(nomeSetor);

            setor.AdicionarSetores(setores);

        }

        public void EditarSetor()
        {

            var setor = new SetoresRepositorio();

            Console.Write("Informe o Id do setor a ser editado: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe o novo nome do setor: ");
            string novoNome = Console.ReadLine();

            Setores setores = new(novoNome);

            setor.EditarSetorPorId(setores);

        }

        public void ListarSetor()
        {
            var setor = new SetoresRepositorio();

            var setores = setor.ObtemSetores();

            foreach (var listaSetor in  setores)
            {
                Console.WriteLine($"Código: {listaSetor.SetorId}");
                Console.WriteLine($"Descrição: {listaSetor.Descricao}");
            }
        }

        public void ExcluirSetor()
        {

        }
    }
}
