using Biblioteca.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.API.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Livro> Livros { get; set; }
    }
}
