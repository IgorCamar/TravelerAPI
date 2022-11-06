using Microsoft.EntityFrameworkCore;

namespace TravelerAPI.Models
{
    public class ServicoDBContext : DbContext
    {
        public ServicoDBContext(DbContextOptions<ServicoDBContext> options)
            : base(options)
        { }

        public DbSet<Servico> Servico { get; set; }


    }
}
