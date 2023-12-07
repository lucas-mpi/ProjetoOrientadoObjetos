using AtendimentoAoCliente.UI;


namespace AtendimentoAoCliente
{
    internal class Program
    {
        static void Main()
        {

            MenuPrincipal();


            void MenuPrincipal()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        int opcaoPrincipal;


                        Console.WriteLine("Console Principal");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção no menu: ");
                        Console.WriteLine("1 - Área do cliente");
                        Console.WriteLine("2 - Área do suporte");
                        Console.WriteLine("0 - Encerrar.");

                        opcaoPrincipal = int.Parse(Console.ReadLine());

                        switch (opcaoPrincipal)
                        {
                            case 1:
                                Console.Clear();
                                MenuCliente();
                                break;

                            case 2:
                                Console.Clear();
                                LoginUsuario();
                                //MenuSuporte();
                                break;

                            case 0:
                                Console.Clear();
                                Console.WriteLine("Saindo...");
                                return;

                            default:
                                Console.WriteLine("Opção inválida");
                                break;


                        }

                        operacaoBemSucedida = true;

                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }
                }

            }

            void MenuCliente()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        int subMenu;

                        Console.WriteLine("Área do Cliente");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Registrar Solicitação");
                        Console.WriteLine("2 - Consultar Solicitações");
                        Console.WriteLine("0 - Retornar Ao Menu Principal");

                        subMenu = int.Parse(Console.ReadLine());

                        AtendimentosUI atendimento = new();

                        switch (subMenu)
                        {
                            case 1:
                                Console.Clear();
                                atendimento.CadastrarAtendimento();

                                break;

                            case 2:
                                Console.Clear();
                                atendimento.ListarAtendimentoClientes();

                                break;

                            case 0:
                                Console.Clear();
                                MenuPrincipal();

                                break;

                            default:
                                Console.WriteLine("Opção inválida");
                                break;

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }

            void LoginUsuario()
            {
                Console.WriteLine("Login do usuário: ");

                Console.Write("Usuário: ");
                string usuario = Console.ReadLine();

                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                UsuariosUI usuarioUI = new();

                bool confirmaUsuario = usuarioUI.VerificaUsuario(usuario, senha);


                if (confirmaUsuario == true)
                {
                    Console.WriteLine("Logado com sucesso!");
                    MenuSuporte();
                }
                else
                {
                    Console.WriteLine("Senha ou usuário inválido!");
                }
            }

            void MenuSuporte()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        int opcaoSuporte;

                        Console.WriteLine("Área do Suporte");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Atendimentos");
                        Console.WriteLine("2 - Painel do Administrador");
                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoSuporte = int.Parse(Console.ReadLine());

                        switch (opcaoSuporte)
                        {
                            case 1:
                                Console.Clear();
                                PainelAtendimentos();
                                break;

                            case 2:
                                Console.Clear();
                                PainelAdministrador();
                                break;

                            case 0:
                                Console.Clear();
                                MenuPrincipal();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }

            }

            void PainelAdministrador()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        int opcaoAdministrador;

                        Console.WriteLine("Painel Adminstrador");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Setores");
                        Console.WriteLine("2 - Tipos de Usuário");
                        Console.WriteLine("3 - Usuários");
                        Console.WriteLine("4 - Clientes");

                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoAdministrador = int.Parse(Console.ReadLine());

                        switch (opcaoAdministrador)
                        {
                            case 1:
                                Console.Clear();
                                PainelSetores();
                                break;

                            case 2:
                                Console.Clear();
                                PainelTiposUsuario();
                                break;
                            case 3:
                                Console.Clear();
                                PainelUsuario();
                                break;

                            case 4:
                                Console.Clear();
                                PainelClientes();
                                break;


                            case 0:
                                Console.Clear();
                                MenuSuporte();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }

                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }

            void PainelSetores()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        SetoresUI setor = new();

                        int opcaoSetor;

                        Console.WriteLine("Painel Setores");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Cadastrar Setor");
                        Console.WriteLine("2 - Listar Setor");
                        Console.WriteLine("3 - Editar Setor");
                        Console.WriteLine("4 - Excluir Setor");
                        Console.WriteLine("0 - Retornar Ao Menu Principal");

                        opcaoSetor = int.Parse(Console.ReadLine());


                        switch (opcaoSetor)
                        {
                            case 1:
                                Console.Clear();
                                setor.CadastrarSetor();
                                break;

                            case 2:
                                Console.Clear();
                                setor.ListarSetor();
                                break;

                            case 3:

                                Console.Clear();
                                setor.EditarSetor();
                                break;

                            case 4:
                                Console.Clear();
                                setor.ExcluirSetor();
                                break;

                            case 0:
                                Console.Clear();
                                PainelAdministrador();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }

            }

            void PainelTiposUsuario()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        TipoUsuarioUI tipoUsuario = new();

                        int opcaoTipoUsuario;

                        Console.WriteLine("Painel Tipos de Usuários");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Cadastrar Tipo");
                        Console.WriteLine("2 - Listar Tipo");
                        Console.WriteLine("3 - Editar Tipo");
                        Console.WriteLine("4 - Excluir Tipo");
                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoTipoUsuario = int.Parse(Console.ReadLine());


                        switch (opcaoTipoUsuario)
                        {
                            case 1:
                                Console.Clear();
                                tipoUsuario.CadastrarTipoUsuario();
                                break;

                            case 2:
                                Console.Clear();
                                tipoUsuario.ListarTipoUsuario();
                                break;

                            case 3:
                                Console.Clear();
                                tipoUsuario.EditarTipoUsuario();
                                break;

                            case 4:
                                Console.Clear();
                                tipoUsuario.ExcluirTipoUsuario();
                                break;

                            case 0:
                                Console.Clear();
                                PainelAdministrador();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }

            void PainelUsuario()
            {
                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        UsuariosUI usuario = new();

                        int opcaoUsuario;


                        Console.WriteLine("Painel Usuários");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Cadastrar Usuário");
                        Console.WriteLine("2 - Listar Usuário");
                        Console.WriteLine("3 - Editar Usuário");
                        Console.WriteLine("4 - Excluir Usuário");
                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoUsuario = int.Parse(Console.ReadLine());


                        switch (opcaoUsuario)
                        {
                            case 1:
                                Console.Clear();
                                usuario.CadastrarUsuario();
                                break;

                            case 2:
                                Console.Clear();
                                usuario.ListarUsuario();
                                break;

                            case 3:
                                Console.Clear();
                                usuario.EditarUsuario();
                                break;

                            case 4:
                                Console.Clear();
                                usuario.ExcluirUsuario();
                                break;

                            case 0:
                                Console.Clear();
                                PainelAdministrador();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }

            void PainelClientes()
            {

                bool operacaoBemSucedida = false;
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        ClientesUI cliente = new();

                        int opcaoCliente;

                        Console.WriteLine("Painel Clientes");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Listar Clientes");
                        Console.WriteLine("2 - Editar Clientes");
                        Console.WriteLine("3 - Excluir Clientes");
                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoCliente = int.Parse(Console.ReadLine());


                        switch (opcaoCliente)
                        {
                            case 1:
                                Console.Clear();
                                cliente.ListarCliente();
                                break;

                            case 2:
                                Console.Clear();
                                break;

                            case 3:
                                Console.Clear();
                                cliente.DeletarCliente();
                                break;

                            case 0:
                                Console.Clear();
                                PainelAdministrador();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }

            void PainelAtendimentos()
            {
                bool operacaoBemSucedida = false;
                
                while (!operacaoBemSucedida)
                {
                    try
                    {
                        int opcaoAtendimento;

                        Console.WriteLine("Área do Suporte");
                        Console.WriteLine();
                        Console.WriteLine("Informe uma opção:");
                        Console.WriteLine("1 - Visualizar Solicitações abertas");
                        Console.WriteLine("2 - Visualizar Solicitações Encerradas");
                        Console.WriteLine("3 - Começar um atendimento");
                        Console.WriteLine("4 - Comentar Atendimento");
                        Console.WriteLine("5 - Mover atendimento para espera");
                        Console.WriteLine("6 - Finalizar Atendimento");
                        Console.WriteLine("0 - Retornar Ao Menu Anterior");

                        opcaoAtendimento = int.Parse(Console.ReadLine());

                        AtendimentosUI atendimento = new();

                        switch (opcaoAtendimento)
                        {
                            case 1:
                                Console.Clear();
                                atendimento.ListarAtendimentosAbertos();
                                break;

                            case 2:
                                Console.Clear();
                                atendimento.ListarAtendimentosFechados();
                                break;

                            case 3:
                                Console.Clear();
                                atendimento.AtribuirAtendimento();
                                break;

                            case 4:
                                Console.Clear();
                                PainelAdministrador();
                                break;


                            case 0:
                                Console.Clear();
                                MenuPrincipal();
                                break;

                            default:
                                throw new Exception("Opção incorreta!");

                        }
                    }


                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine($"Ocorreu um problema: {ex.Message}");
                        Console.WriteLine("Tente novamente.");
                        Console.WriteLine();
                    }

                }


            }
        }


    }



}
