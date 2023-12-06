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

        public Usuarios? Atendente { get; set; }

        public Clientes Cliente { get; set; }

        public string ComentarioCliente { get; set; }

        public string? ComentarioAtendente { get; set; }

        public Setores AreaAtendimento { get; set; }

        public DateTime DataSolicitacao { get; set; }

        public DateTime? UltimaAtualizacao { get; set; }
        public String? StatusAtendimento { get;set; }


        [NotMapped]
        public Clientes Clientes { get; set; }

        public Atendimentos() { }
        public Atendimentos(Clientes cliente, string comentarioCliente,
                            Setores areaAtendimento, DateTime dataSolicitacao)
        {
            Cliente = cliente;
            ComentarioCliente = comentarioCliente;
            AreaAtendimento = areaAtendimento;
            DataSolicitacao = dataSolicitacao;
        }




    }
}
