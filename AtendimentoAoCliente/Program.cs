using AtendimentoAoCliente.UI;


namespace AtendimentoAoCliente
{
    internal class Program
    {
        static void Main()
        {

            MenuPrincipal();

            int opcaoMenu;

            void MenuPrincipal()
            {
                do
                {
                    Console.WriteLine("Informe uma opção no menu: ");
                    Console.WriteLine("1 - Área do cliente");
                    Console.WriteLine("2 - Área do suporte");
                    Console.WriteLine("0 - Encerrar.");

                    opcaoMenu = int.Parse(Console.ReadLine());

                    switch (opcaoMenu)
                    {
                        case 1:

                            SubMenuCliente();
                            break;

                        case 2:
                            SubMenuSuporte();
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;


                    }

                } while (opcaoMenu != 0);
            }

            void SubMenuCliente()
            {
                int subMenu;

                do
                {
                    Console.WriteLine("Informe uma opção:");
                    Console.WriteLine("1 - Registrar Solicitação");
                    Console.WriteLine("2 - Consultar Solicitações");
                    Console.WriteLine("0 - Retornar Ao Menu Principal");

                    subMenu = int.Parse(Console.ReadLine());

                    AtendimentosUI atendimento = new();

                    switch (subMenu)
                    {
                        case 1:
                            atendimento.CadastrarAtendimento();
                            break;

                        case 2:
                            atendimento.ListarAtendimentoClientes();
                            break;

                        case 0:
                            MenuPrincipal();
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;

                    }
                } while (subMenu != 0);

            }

            void LoginUsuario()
            {
                Console.WriteLine("Login do usuário: ");

                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                UsuariosUI usuarioUI = new();

                var confirmaUsuario = usuarioUI.VerificaUsuario(usuario, senha);


                if (confirmaUsuario == true)
                {
                    Console.WriteLine("Logado com sucesso!");
                    SubMenuSuporte();
                }
                else
                {
                    Console.WriteLine("Senha ou usuário inválido!");
                }
            }

            void SubMenuSuporte()
            {

                int subMenu;

                do
                {
                    Console.WriteLine("Informe uma opção:");
                    Console.WriteLine("1 - Visualizar Solicitações abertas");
                    Console.WriteLine("2 - Visualizar Solicitações Encerradas");
                    Console.WriteLine("3 - Começar um atendimento");
                    Console.WriteLine("4 - Painel do Administrador");
                    Console.WriteLine("0 - Retornar Ao Menu Principal");

                    subMenu = int.Parse(Console.ReadLine());

                    AtendimentosUI atendimento = new();
                    UsuariosUI usuario = new();
                    SetoresUI setor = new();
                    TipoUsuarioUI tipo = new();

                    switch (subMenu)
                    {
                        case 1:
                            atendimento.ListarAtendimentosAbertos();
                            break;

                        case 2:
                            atendimento.ListarAtendimentosFechados();
                            break;
                        case 3:
                            atendimento.AtribuirAtendimento();
                            break;

                        case 4:
                            setor.ListarSetor();
                            break;


                        case 0:
                            MenuPrincipal();
                            break;

                        default:
                            throw new Exception("Opção incorreta!");

                    }
                } while (subMenu != 0);
            }


        }



    }
}