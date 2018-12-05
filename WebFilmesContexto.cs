using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class WebFilmesContexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


        }

        public WebFilmesContexto()
            : base("WebFilmes")
        {
            var ensureDLLIsCopied =
                System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        
        public virtual DbSet<Genero> Genero { get; set; }       
        public virtual DbSet<Filme> Filme { get; set; }
        public virtual DbSet<Locacao> Locacao { get; set; }
        public virtual DbSet<LocacaoFilme> LocacaoFilme {get;set;}
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
