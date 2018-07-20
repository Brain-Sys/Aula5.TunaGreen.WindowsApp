using Aula5.TunaGreen.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
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
            modelBuilder.Entity<FuelType>().ToTable("TIPI_CARBURANTI");

            base.OnModelCreating(modelBuilder);
        }

        public virtual int ResetRegistrationDate()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ResetRegistrationDate");
        }

        //public virtual ObjectResult<SmallCar> SearchCarsByYear(Nullable<int> year)
        //{
        //    var yearParameter = year.HasValue ?
        //        new ObjectParameter("Year", year) :
        //        new ObjectParameter("Year", typeof(int));

        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SmallCar>("SearchCarsByYear", yearParameter);
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FuelType>().ToTable("KKFHJFJHBVDFJH");
        //    modelBuilder.Entity<FuelType>()
        //        .Property(ft => ft.Electric)
        //        .HasColumnName("TIPO");
        //}

        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Station> Stations { get; set; }
    }
}