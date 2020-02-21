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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Password=@up@sap13;Persist Security Info=True;User ID=sa;Initial Catalog=DbTeste;Data Source=DESKTOP-QNHV9IG\\SAP");
        }
    }
}
