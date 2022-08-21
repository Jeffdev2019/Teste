using Confitec.WebAPI.Infra.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.WebAPI.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext() { }

        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<HistoricoEscolar> HistoricoEscolar { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Escolaridade>().HasData(new Escolaridade { Id = 1, Descricao = "Infantil" });
            modelBuilder.Entity<Escolaridade>().HasData(new Escolaridade { Id = 2, Descricao = "Fundamental" });
            modelBuilder.Entity<Escolaridade>().HasData(new Escolaridade { Id = 3, Descricao = "Médio" });
            modelBuilder.Entity<Escolaridade>().HasData(new Escolaridade { Id = 4, Descricao = "Superior" });
        }
    }
}
