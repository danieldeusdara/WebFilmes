using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Locacao
    {
        [Key]
        public int Id { get; set; }
        public string CpfCliente { get; set; }
        public DateTime DataLocacao { get; set; }

        public IEnumerable<Filme> ListaFilme { get; set; }
    }
}
