using Aula5.TunaGreen.SqlServerRepository;
using Aula5.TunaGreen.SqlServerRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Aula5.TunaGreen.ModernWindowsApp
{
    public partial class Form1 : Form
    {
        IRepo ctx;

        // Il ctor non può essere async
        public Form1()
        {
            InitializeComponent();
            ctx = ServiceLocator.Resolve<IRepo>("repo");

            ctx.Init();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Car> list = await ctx.TableCars
                .OrderByDescending(c => c.Km)
                .ToListAsync();
        }
    }
}
