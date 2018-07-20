using Aula5.TunaGreen.SqlServerRepository;
using Aula5.TunaGreen.SqlServerRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
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
            db.Database.Log = (s) => {
                Debug.WriteLine(s);
            };
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // int x = db.ResetRegistrationDate();

            List<SmallCar> ricerca = db.SearchCarsByYear(1970)
                .Take(20)
                .OrderByDescending(c => c.ID)
                .ToList();

            List<Car> list = await ctx.TableCars
                .OrderByDescending(c => c.Km)
                .ToListAsync();
        }
    }
}
