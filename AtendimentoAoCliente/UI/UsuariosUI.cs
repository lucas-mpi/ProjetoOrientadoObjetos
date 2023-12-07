using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.UI
{
    internal class UsuariosUI
    {
        UsuariosRepositorio usuario = new();

        public void CadastrarUsuario()
        {
            Console.WriteLine("Cadastro de novo usuário");

            Console.Write("Nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Nome de usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            Console.Write("Categoria: ");
            int categoria = int.Parse(Console.ReadLine());

            Console.Write("Setor usuário: ");
            int setor = int.Parse(Console.ReadLine());


            
            Usuarios novoUsuario = new(nomeCompleto, nomeUsuario, senha, true, categoria, setor);

            usuario.AdicionarUsuarios(novoUsuario);

        }

        public void EditarUsuario()
        {

        }

        public void ListarUsuario()
        {

            var usuarios = usuario.ObtemUsuarios();
            Console.WriteLine("Usuários Cadastrados: ");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine($"Id: {usuario.UsuarioId}");
                Console.WriteLine($"Nome: {usuario.NomeUsuario}");
                Console.WriteLine("----------------------------------");
            }

        }

        public void ExcluirUsuario()
        {
            Console.WriteLine("Excluir Usuario");

            Console.Write("Informe o Id do usuário: ");
            int id = int.Parse(Console.ReadLine());

        }

        public void DesativarUsuario()
        {
        }

        public Boolean VerificaUsuario(string usuario, string senha)
        {

            UsuariosRepositorio usuarios = new();
            
            var user = usuarios.ConfirmaCredenciais(usuario, senha);

            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        


    }
}
