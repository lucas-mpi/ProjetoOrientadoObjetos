using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AtendimentoAoCliente.Modelos
{
    [Table("Setores")]
    internal class Setores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SetorId { get; set; }
        public string Descricao { get; set; }

        ICollection<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        ICollection<Atendimentos> Atendimentos { get; set; } = new List<Atendimentos>();    


        public Setores(string descricao)
        {
            Descricao = descricao;
        }

       
    }
}
