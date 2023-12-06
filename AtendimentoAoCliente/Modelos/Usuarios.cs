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
        private bool v;
        private IQueryable<Usuarios> tipo;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public Boolean UsuarioAtivo { get; set; }
        public TipoUsuario Categoria { get; set; }
        public Setores SetorUsuario { get; set; }

        [NotMapped]
        public List<Atendimentos> Atendimentos { get; set; }

        
        public Usuarios()
        {

        }
        public Usuarios(string nomeCompleto, string nomeUsuario,
                          string senha, Boolean usuarioAtivo, TipoUsuario categoria, Setores setorUsuario)
        {

            NomeCompleto = nomeCompleto;
            NomeUsuario = nomeUsuario;
            Senha = senha;
            UsuarioAtivo = usuarioAtivo;
            Categoria = categoria;
            SetorUsuario = setorUsuario;

        }
    }
}
