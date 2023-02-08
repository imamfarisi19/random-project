using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PenelitianFTS.SqliteRun
{
    public class SqliteFtsContext : DbContext
    {
        public SqliteFtsContext()
        {
        }

        public SqliteFtsContext(DbContextOptions<SqliteFtsContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=FullTextSearch.db");


        public virtual DbSet<BagianBuku> BagianBukuSet { get; set; }
        public virtual DbSet<BagianBuku_index> BagianBuku_indexz { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}
