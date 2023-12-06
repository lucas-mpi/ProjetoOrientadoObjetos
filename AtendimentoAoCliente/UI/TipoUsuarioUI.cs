using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.UI
{
    internal class TipoUsuarioUI
    {

        public void CadastrarTipoUsuario()
        {
            var tipo = new TipoUsuarioRepositorio();

            Console.WriteLine("Descrição: ");
            string tipoUsuario = Console.ReadLine();

            TipoUsuario novoTipo = new(tipoUsuario);

            tipo.AdicionarTipoUsuario(novoTipo);

        }

        public void EditarSetor()
        {

        }

        public void ListarSetor()
        {

        }

        public void ExcluirSetor()
        {

        }
    }
}
