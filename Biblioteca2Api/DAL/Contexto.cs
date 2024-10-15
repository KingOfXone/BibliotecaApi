using BibliotecaLib.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca2Api.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Libros> Libros { get; set; }
      
    }
}
