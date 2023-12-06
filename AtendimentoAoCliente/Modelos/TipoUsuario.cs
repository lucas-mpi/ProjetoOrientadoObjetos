using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Modelos
{
    internal class TipoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoUsuarioId { get; set; }
        public string Descricao { get; set;  }

        public TipoUsuario(string descricao)
        {
            Descricao = descricao;
        }
    }
}
