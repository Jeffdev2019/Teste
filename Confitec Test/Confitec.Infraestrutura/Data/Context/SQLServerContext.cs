using Confitec.Infraestrutura.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confitec.Infraestrutura.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext() { }

        public SQLServerContext(DbContextOptions<SQLServerContext> options) : base(options) { }

        public DbSet<Usuario> usuario { get; set; }
        public DbSet<HistoricoEscolar> historicoEscolar { get; set; }
        public DbSet<Escolaridade> escolaridade { get; set; }
    }
}
