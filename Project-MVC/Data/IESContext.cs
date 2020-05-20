using Microsoft.EntityFrameworkCore;
using Modelo.Cadastros;
using Project_MVC.Models;

namespace Project_MVC.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) :base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

    }
}
