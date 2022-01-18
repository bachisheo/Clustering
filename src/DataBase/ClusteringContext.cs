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
        private static string DataBasePath = "clustering.db";
        public DbSet<Cluster> Clusters { get; set; }
        public DbSet<CleanObject> CleanObjects { get; set; }
        public DbSet<ClusteringResult> ClusteringResults { get; set; }
        public DbSet<RawSet> RawSets { get; set; }
        public DbSet<RawObject> RawObjects { get; set; }
        public DbSet<CleanSet> CleanSets { get; set; }

        public string DbPath { get; private set; }

        public ClusteringContext()
        {
            var log = FileLogger.Instance;
            log.Log("ClusteringContext was created");
            DbPath = DataBasePath;
        }

        public void ClearAllTable()
        {
            Clusters.Clear();
            CleanObjects.Clear();
            RawSets.Clear();
            RawObjects.Clear();
            CleanSets.Clear();
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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
                .UseLazyLoadingProxies()
                .UseSqlite($"Data Source={DbPath}");
    }

    public static class DbSetExtention
    {
        public static void Clear<T>(this DbSet<T> set) where T : class
        {
            set.RemoveRange(set);
        }
    }
}