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

        public void CadastrarUsuario()
        {
            Console.Write("Nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Nome de usuário: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            Console.Write("Categoria: ");
            string categoria = Console.ReadLine();

            Console.Write("Setor usuário: ");
            string setor = Console.ReadLine();


            SetoresRepositorio setores = new();

            Setores setorUsuario = (Setores)setores.ObtemSetorPorNome(setor);

            TipoUsuarioRepositorio tipoUsuario = new();

            TipoUsuario tipo = (TipoUsuario)tipoUsuario.ObtemTipoPorNome(categoria);

            var usuario = new UsuariosRepositorio();

            if (setorUsuario != null)
                if (tipo != null)
                {
                    Usuarios novoUsuario = new(nomeCompleto, nomeUsuario, senha, true, tipo, setorUsuario);
                    usuario.AdicionarUsuarios(novoUsuario);
                }
            else
            {
                Console.WriteLine("Área de atendimento inválida");
            }
        }

        public void EditarUsuario()
        {

        }

        public void ListarUsuario(string nome)
        {

            UsuariosRepositorio usuarios = new();

        }

        public void ExcluirUsuario()
        {

        }

        public void DesativarUsuario()
        {
        }

        public Boolean VerificaUsuario(string usuario, string senha)
        {

            UsuariosRepositorio usuarios = new();
            
            usuarios.ConfirmaCredenciais(usuario, senha);   

            if (usuarios != null)
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
