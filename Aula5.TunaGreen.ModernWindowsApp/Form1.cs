using Aula5.TunaGreen.SqlServerRepository;
using Aula5.TunaGreen.SqlServerRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Aula5.TunaGreen.ModernWindowsApp
{
    public partial class Form1 : Form
    {
        IRepo ctx;
        TunaGreenEntities db = new TunaGreenEntities();

        // Il ctor non può essere async
        public Form1()
        {
            InitializeComponent();
            ctx = ServiceLocator.Resolve<IRepo>("repo");

            ctx.Init();
            db.Database.Log = (s) =>
            {
                Debug.WriteLine(s);
                File.AppendAllText("E:\\Log_Aula5.txt", s);
            };

            ctx.Save();

            //bool pending = db.ChangeTracker.HasChanges();
            //db.ChangeTracker.DetectChanges();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = true;
            // int x = db.ResetRegistrationDate()

            var car = db.Cars
                .OrderBy(c => c.ID)
                .Where(c => c.Color == "Antracite")
                .Take(5)
                .ToList();

            var bmw = db.TableBrands
                .Include("Cars")
                .FirstOrDefault(b => b.Name == "BMW");

            foreach (var item in bmw.Cars)
            {
                Debug.WriteLine(item.ID);
            }

            Car newCar = new Car();
            db.Cars.Add(newCar);
            DbEntityEntry<Car> auto = db.Entry<Car>(newCar);
            // db.Configuration.AutoDetectChangesEnabled = false;
            // db.Configuration.EnsureTransactionsForFunctionsAndCommands = false;
            

            int q = db.ChangeTracker.Entries<Car>().Count();

            //.ToList()
            //.OrderBy(c => c.Km)
            //.Take(10);

            List<SmallCar> ricerca = db.SearchCarsByYear(1970)
                .Take(20)
                .OrderByDescending(c => c.ID)
                .ToList();

            List<Car> list = await ctx.TableCars
                .OrderByDescending(c => c.Km)
                .ToListAsync();
        }

        private void btnCreateBrand_Click(object sender, EventArgs e)
        {
            Car car = db.Cars.FirstOrDefault(c => c.Km < 45000);

            if (car != null)
            {
                car.Km++;
                DbEntityEntry<Car> obj = db.ChangeTracker.Entries<Car>()
                    .Where(en => en.State == EntityState.Modified).FirstOrDefault();
                Car c = obj.Entity;
                var prima = (double)obj.OriginalValues["Km"];
                var dopo = (double)obj.CurrentValues["Km"];

                DbPropertyValues values = obj.GetDatabaseValues();


                db.Database.BeginTransaction();
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    db.Database.CurrentTransaction.Rollback();
                }

                db.Database.CurrentTransaction.Commit();
            }

            List<DbEntityEntry> list = db.ChangeTracker.Entries()
                .Where(en => en.State != EntityState.Unchanged)
                .ToList();

            

            //int c = db.ChangeTracker.Entries()
            //    .Where(en => en.State == EntityState.Added)
            //    .Count();

            //Brand b = new Brand();
            //b.Name = "Peugeot";
            //b.Country = "FR";
            //db.Brands.Add(b);

            //c = db.ChangeTracker.Entries()
            //    .Where(en => en.State == EntityState.Added)
            //    .Count();
        }
    }
}
