using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "*Nome Obrigatório")]
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Ativo { get; set; }
    }
}
