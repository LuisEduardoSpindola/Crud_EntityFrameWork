using Exercicio_Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercicio_Crud.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) { }

        public DbSet <Usuario> usuarios { get; set; }
    }
}
