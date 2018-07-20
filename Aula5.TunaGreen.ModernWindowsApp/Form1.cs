using Aula5.TunaGreen.SqlServerRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Aula5.TunaGreen.ModernWindowsApp
{
    public partial class Form1 : Form
    {
        TunaGreenEntities ctx = new TunaGreenEntities();

        // Il ctor non può essere async
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            List<Car> list = await ctx.Cars
                .OrderByDescending(c => c.Km)
                .ToListAsync();
        }
    }
}
