using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5.TunaGreen.WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DB_8049_oec216Entities ctx = new DB_8049_oec216Entities();
            DbSet<Car> tabella = ctx.Cars;

            Car miaAuto = new Car();
            miaAuto.Identifier = "ABCDEF";
            miaAuto.Km = 56000;
            miaAuto.Model = "Fiat 500";

            tabella.Add(miaAuto);
            ctx.SaveChanges();

            // Multiple Active Result Set
            MessageBox.Show("Tutto ok, ID=" + miaAuto.ID.ToString());
        }
    }
}