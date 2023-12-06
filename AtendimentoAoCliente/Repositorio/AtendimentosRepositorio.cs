using AtendimentoAoCliente.Contextos;
using AtendimentoAoCliente.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Repositorio
{
    internal class AtendimentosRepositorio
    {
        private readonly AtendimentoDbContext _context;

        public AtendimentosRepositorio ()
        {
            _context = new AtendimentoDbContext();
        }

        public IQueryable<Atendimentos> ConsultaAtendimentoCliente(string identificadorUsuario, int identificadorSolicitacao)
        {
            return _context.Atendimentos.Where(a => a.AtendimentoId == identificadorSolicitacao)
                    .Include(c => c.Clientes.Cpf == identificadorUsuario || c.Clientes.Email == identificadorUsuario).AsQueryable();

        }

        public IQueryable<Atendimentos> ConsultaAtendimentosAbertos()
        {
            return _context.Atendimentos.Where(a => a.StatusAtendimento == "Pendente").AsQueryable();
        }

        public IQueryable<Atendimentos> ConsultaAtendimentosFechados()
        {
            return _context.Atendimentos.Where(a => a.StatusAtendimento == "Finalizado").AsQueryable();
        }


        public void AdicionarAtendimento(Atendimentos atendimentos)
        {
            _context.Atendimentos.Add(atendimentos);
            _context.SaveChanges();
        }

    }
}
