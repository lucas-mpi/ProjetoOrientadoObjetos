using AtendimentoAoCliente.Modelos;
using AtendimentoAoCliente.Repositorio;

namespace AtendimentoAoCliente.UI
{
    internal class AtendimentosUI
    {

        public void CadastrarAtendimento()
        {
                        
                var dbAtendimento = new AtendimentosRepositorio();
                var dbCliente = new ClienteRepositorio();

            
                Console.WriteLine("Informe seus dados: ");
                Console.Write("Nome completo: ");
                string nomeCompleto = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();
                
                
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                Console.Write("Telefone: ");
                string telefone  = Console.ReadLine();
                
                Clientes novoCliente = new(nomeCompleto, email, cpf, telefone);

                dbCliente.AdicionarCliente(novoCliente);



                Console.WriteLine("Informe os dados para a solicitação: ");

                Console.Write("Área para atendimento: ");
                int areaAtendimento = int.Parse(Console.ReadLine());

                Console.Write("Mensagem para o suporte: ");
                string mensagemSuporte = Console.ReadLine();

                Atendimentos novoAtendimento = new(novoCliente.ClienteId, mensagemSuporte, areaAtendimento, DateTime.Now);
                                
                dbAtendimento.AdicionarAtendimento(novoAtendimento);







        }

        public void ListarAtendimentoClientes()
        {
            var buscaAtendimentosCliente = new AtendimentosRepositorio();

            Console.Write("Informe o seu e-mail ou o Cpf: ");
            string identificadorUsuario = Console.ReadLine();

            Console.Write("Informe o código de identificação da solicitação: ");
            int identificadorSolicitacao = int.Parse(Console.ReadLine());

            var buscaAtendimentos = buscaAtendimentosCliente.ConsultaAtendimentoCliente(identificadorUsuario, identificadorSolicitacao);

        
            foreach (var atendimento in buscaAtendimentos)
            {
                Console.WriteLine($"Atendimento ID: {atendimento.AtendimentoId}");
                Console.WriteLine($"Atendente: {atendimento.Usuarios.NomeCompleto}");
                Console.WriteLine($"Cliente: {atendimento.Clientes.NomeCompleto}");
                Console.WriteLine($"Comentario Cliente: {atendimento.ComentarioCliente}");
                Console.WriteLine($"Comentario Atendente: {atendimento.ComentarioAtendente}");
                Console.WriteLine($"Área de atendimento: {atendimento.Setores.Descricao}");
                Console.WriteLine($"Data da solicitação: {atendimento.DataSolicitacao}");
                Console.WriteLine($"Data última atualização: {atendimento.UltimaAtualizacao}");
                Console.WriteLine($"Status do Atendimento: {atendimento.StatusAtendimento}");
            }
           
        }

        public void ListarAtendimentosAbertos()
        {
            var AtendimentoAberto = new AtendimentosRepositorio();

            var atendimentoAberto = AtendimentoAberto.ConsultaAtendimentosAbertos();
            
            foreach (var atendimento in atendimentoAberto)
            {
                Console.WriteLine($"Atendimento ID: {atendimento.AtendimentoId}");
                Console.WriteLine($"Atendente: {atendimento.Usuarios.NomeCompleto}");
                Console.WriteLine($"Cliente: {atendimento.Clientes.NomeCompleto}");
                Console.WriteLine($"Comentario Cliente: {atendimento.ComentarioCliente}");
                Console.WriteLine($"Comentario Atendente: {atendimento.ComentarioAtendente}");
                Console.WriteLine($"Área de atendimento: {atendimento.Setores.Descricao}");
                Console.WriteLine($"Data da solicitação: {atendimento.DataSolicitacao}");
                Console.WriteLine($"Data última atualização: {atendimento.UltimaAtualizacao}");
                Console.WriteLine($"Status do Atendimento: {atendimento.StatusAtendimento}");
            }
            
        }

        public void ListarAtendimentosFechados()
        {
            var atendimentos = new AtendimentosRepositorio();

            var atendimentosFechados = atendimentos.ConsultaAtendimentosFechados();
            
            foreach (var atendimento in atendimentosFechados)
            {
                Console.WriteLine($"Atendimento ID: {atendimento.AtendimentoId}");
                Console.WriteLine($"Atendente: {atendimento.Usuarios.NomeCompleto}");
                Console.WriteLine($"Cliente: {atendimento.Clientes.NomeCompleto}");
                Console.WriteLine($"Comentario Cliente: {atendimento.ComentarioCliente}");
                Console.WriteLine($"Comentario Atendente: {atendimento.ComentarioAtendente}");
                Console.WriteLine($"Área de atendimento: {atendimento.Setores.Descricao}");
                Console.WriteLine($"Data da solicitação: {atendimento.DataSolicitacao}");
                Console.WriteLine($"Data última atualização: {atendimento.UltimaAtualizacao}");
                Console.WriteLine($"Status do Atendimento: {atendimento.StatusAtendimento}");
            }
            

        }
           
        public void ExcluirAtendimento()
        {

        }

        public void MoverAtendimentoParaEspera()
        {

        }

        public void AtribuirAtendimento()
        {

        }
    }
}
