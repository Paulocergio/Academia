using Microsoft.EntityFrameworkCore;


namespace academia.infra.data.Contexto
{
    public class DataContexto : DbContext
    {

        public DataContexto (DbContextOptions<DataContexto>options):base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
