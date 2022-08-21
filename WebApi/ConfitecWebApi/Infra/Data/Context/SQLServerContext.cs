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

            modelBuilder.Entity<Escolaridade>(a =>
            {
                a.HasKey(E => E.IdEscolaridade);
                a.Property(E => E.IdEscolaridade).UseIdentityColumn(1, 1);
                a.HasData(new Escolaridade { IdEscolaridade = 1, Descricao = "Infantil" });
                a.HasData(new Escolaridade { IdEscolaridade = 2, Descricao = "Fundamental" });
                a.HasData(new Escolaridade { IdEscolaridade = 3, Descricao = "Médio" });
                a.HasData(new Escolaridade { IdEscolaridade = 4, Descricao = "Superior" });
            });


            modelBuilder.Entity<Usuario>(a =>
            {
                a.HasKey(E => E.IdUsuario);
                a.Property(E => E.IdUsuario).UseIdentityColumn(1,1);
                a.HasOne(e => e.Escolaridade)
                    .WithMany(z => z.Usuarios)
                    .HasForeignKey(f => f.EscolaridadeId);
                a.HasOne(e => e.Historico)
                    .WithMany(z => z.Usuarios)
                    .HasForeignKey(f => f.HistoricoEscolarId);
            });

            modelBuilder.Entity<HistoricoEscolar>(a =>
            {
                a.HasKey(E => E.IdHistoricoEscolar);
                a.Property(E => E.IdHistoricoEscolar).UseIdentityColumn(1,1);
            });


        }
    }
}
