using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AtendimentoAoCliente.Modelos
{
    internal class TipoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoUsuarioId { get; set; }
        public string Descricao { get; set;  }

        ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();


        public TipoUsuario(string descricao)
        {
            Descricao = descricao;
        }
    }
}
