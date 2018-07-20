using Aula5.TunaGreen.DomainModel;
using Aula5.TunaGreen.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5.TunaGreen.ModernWindowsApp
{
    public partial class StationServiceForm : Form
    {
        StationServiceContext ctx = new StationServiceContext();

        public StationServiceForm()
        {
            InitializeComponent();
        }

        private void StationServiceForm_Load(object sender, EventArgs e)
        {
            var carburanti = ctx.FuelTypes.ToList();

            //FuelType ft = new FuelType();
            //ft.Name = "Elettrico";
            //ft.Price = 0.1;
            //ctx.FuelTypes.Add(ft);
            //await ctx.SaveChangesAsync();
        }
    }
}
