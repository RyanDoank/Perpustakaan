﻿global using Microsoft.EntityFrameworkCore;

namespace Perpustakaan.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Perpustakaandb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<BookClass> Books { get; set; }
    }
}
