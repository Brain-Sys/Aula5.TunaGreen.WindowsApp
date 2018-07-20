using Aula5.TunaGreen.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.Repository
{
    public class StationServiceContext : DbContext
    {
        public StationServiceContext()
            : base("DB_StationService")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FuelType>()
                .Property(ft => ft.Name).HasMaxLength(10);

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FuelType>().ToTable("KKFHJFJHBVDFJH");
        //    modelBuilder.Entity<FuelType>()
        //        .Property(ft => ft.Electric)
        //        .HasColumnName("TIPO");
        //}

        public DbSet<FuelType> FuelTypes { get; set; }
    }
}