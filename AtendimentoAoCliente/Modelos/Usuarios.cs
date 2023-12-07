using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoAoCliente.Modelos
{
    internal class Usuarios
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public int TipoUsuarioId { get; set; }
        public int SetorId { get; set; }

        public Boolean UsuarioAtivo { get; set; }
                


        TipoUsuario TipoUsuario { get; set; }
        Setores Setores { get; set; }


        public List<Atendimentos> Atendimentos { get; set; }

        
        public Usuarios()
        {

        }
        public Usuarios(string nomeCompleto, string nomeUsuario,
                          string senha, Boolean usuarioAtivo, int tipoUsuarioId, int setorId)
        {

            NomeCompleto = nomeCompleto;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            UsuarioAtivo = usuarioAtivo;
            TipoUsuarioId = tipoUsuarioId;
            SetorId = setorId;

        }
    }
}
