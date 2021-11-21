using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Clustering.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clustering.DataBase
{
    public class ClusteringContext : DbContext
    {

        public DbSet<Cluster>  Clusters { get; set; }
        public DbSet<CleanObject> CleanObjects { get; set; }
        public DbSet<ClusteringResult> ClusteringResults { get; set; }
        public DbSet<RawSet> RawSets { get; set; }
        public DbSet<RawObject> RawObjects { get; set; }
        public DbSet<CleanSet> CleanSets { get; set; }

        public string DbPath { get; private set; }

        public ClusteringContext()
        {
            DbPath = "clustering.db";
        }

        public void ClearAllTable()
        {
            
            Clusters.Clear();
            CleanObjects.Clear();
            ClusteringResults.Clear();
            RawSets.Clear();
            RawObjects.Clear();
        }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<double[], string>(
                v => DoubleArrayToStringConverter.DoubleToString(v),
                v => DoubleArrayToStringConverter.StringToDouble(v));
            modelBuilder.Entity<CleanObject>().Property(e => e.ObjData).HasConversion(converter);
            modelBuilder.Entity<RawObject>().Property(e => e.ObjData).HasConversion(converter);
            base.OnModelCreating(modelBuilder);

        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
                .UseSqlite($"Data Source={DbPath}");
    }

    public static class DBSetExtention
    {
        public static void Clear<T>(this DbSet<T> set) where T : class
        {
            set.RemoveRange(set);
        }
    }
}