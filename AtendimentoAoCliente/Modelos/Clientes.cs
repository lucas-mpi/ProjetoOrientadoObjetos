using AtendimentoAoCliente.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Modelos
{
    internal class Clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        [NotMapped]
        public List<Atendimentos> Atendimento { get; set; }

        

        public Clientes(string nomeCompleto, string email, string cpf, string telefone)
        {
            NomeCompleto = nomeCompleto;
            Email = email;
            Cpf = cpf;
            Telefone = telefone;

        }

    }
}
