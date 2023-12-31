﻿using AtendimentoAoCliente.Repositorio;


namespace AtendimentoAoCliente.UI
{
    internal class ClientesUI
    {
        
        readonly ClienteRepositorio clientes = new();

        public void ListarCliente()
        {
            var listaCliente = clientes.ObtemClientes();

            Console.WriteLine("Lista de Clientes: ");
            Console.WriteLine();
            foreach (var lista in listaCliente)
            {
                Console.WriteLine($"Id: {lista.ClienteId}");
                Console.WriteLine($"Nome: {lista.NomeCompleto}");
                Console.WriteLine($"Email: {lista.Email}");
                Console.WriteLine($"CPF: {lista.Cpf}");
                Console.WriteLine($"Telefone: {lista.Telefone}");
                Console.WriteLine("-------------------------------");
            }

        }

        public void DeletarCliente()
        {
            Console.WriteLine("Deletar Cliente");

            Console.Write("Informe o Id do cliente para deletar: ");
            int id = int.Parse(Console.ReadLine());

            clientes.DeletarCliente(id); 



        }

    }
}
