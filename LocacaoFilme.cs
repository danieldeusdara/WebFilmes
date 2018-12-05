using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LocacaoFilme
    {
        [Key]
        public int Id { get; set; }
        public int LocacaoId { get; set; }
        public int FilmeId { get; set; }

        public virtual Locacao Locacao {get;set;}
        public virtual Filme Filme { get; set; }
    }
}
