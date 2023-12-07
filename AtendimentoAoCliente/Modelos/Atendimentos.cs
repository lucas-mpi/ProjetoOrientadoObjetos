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
    internal class Atendimentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AtendimentoId { get; set; }

        public int ClienteId { get; set; }

        public string ComentarioCliente { get; set; }

        public string? ComentarioAtendente { get; set; }

        public int SetorId { get; set; }

        public int? UsuarioId { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public DateTime? UltimaAtualizacao { get; set; }
        public String? StatusAtendimento { get;set; }


        public Clientes Clientes { get; set; }
        public Setores Setores {get ; set; }
        public Usuarios? Usuarios { get; set; }

        public Atendimentos() { }
        public Atendimentos(int clienteId, string comentarioCliente,
                            int setorId, DateTime dataSolicitacao)
        {
            ClienteId = clienteId;
            ComentarioCliente = comentarioCliente;
            SetorId = setorId;
            DataSolicitacao = dataSolicitacao;
        }




    }
}
