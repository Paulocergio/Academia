using codiconaveia.academia.Dominio.Entitis.Account;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace academia.infra.data.Contexto
{
    public class DataContexto : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DataContexto(DbContextOptions<DataContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder); 
        }
    }
}
