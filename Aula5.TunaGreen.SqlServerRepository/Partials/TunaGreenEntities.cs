using Aula5.TunaGreen.SqlServerRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.SqlServerRepository
{
    public partial class TunaGreenEntities : IRepo
    {
        public IQueryable<Car> TableCars
        {
            get
            {
                return this.Cars.AsQueryable();
            }
        }

        public IQueryable<Brand> TableBrands
        {
            get
            {
                return this.Brands.AsQueryable();
            }
        }

        public void Init()
        {
#if DEBUG
            // this.Database.Connection.ConnectionString = "";
#endif

#if !DEBUG
            // this.Database.Connection.ConnectionString = "";
#endif
        }

        public void Save()
        {
            // Log delle entity che risultano pending
            var list = this.ChangeTracker.Entries()
                .Where(e => e.State != System.Data.Entity.EntityState.Unchanged)
                .ToList();

            this.SaveChanges();
        }
    }
}