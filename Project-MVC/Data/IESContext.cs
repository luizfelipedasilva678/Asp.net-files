using Microsoft.EntityFrameworkCore;
using Project_MVC.Models;

namespace Project_MVC.Data
{
    public class IESContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
        }

    }
}
