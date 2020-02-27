using BaseApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApi.Data
{
    public class DbTesteContext : DbContext
    {
        public DbSet<Documento> Documents { get; set; }
        public DbSet<Cotacao> Quotations { get; set; }
        public DbTesteContext(DbContextOptions<DbTesteContext> options)
            : base(options) {
        }
    }
}
