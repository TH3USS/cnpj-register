using CNPJ_Register.Models;
using Microsoft.EntityFrameworkCore;

namespace CNPJ_Register.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
    }

}
