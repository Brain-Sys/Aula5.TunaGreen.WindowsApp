using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5.TunaGreen.WindowsApp
{
    public partial class Form1 : Form
    {
        // ctx
        DB_8049_oec216Entities ctx = new DB_8049_oec216Entities();

        public Form1()
        {
            InitializeComponent();

            ctx.Database.Log = writeLog;
            //ctx.Database.Log = (text) => { Console.WriteLine(text); };
        }

        private void writeLog(string text)
        {
            // Scrive nell'output di VS
            Debug.WriteLine(text);
            File.AppendAllText("E:\\Log_Aula5.txt", text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

        private async void btnMassiveCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < 100; i++)
            {
                Car c = new Car();
                c.Km = rnd.Next(0, 50000);
                c.Model = "Modello " + rnd.Next(0, 50000).ToString();
                c.Identifier = "-";

                ctx.Cars.Add(c);
            }

            await ctx.SaveChangesAsync();
            MessageBox.Show("Finito!!!!");
        }

        private async void txtSearchKm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                int km = Int32.Parse(this.txtSearchKm.Text);

                List<Car> list = await ctx.Cars
                    .Where(auto => auto.Km < km)
                    .ToListAsync();

                MessageBox.Show(list.Count.ToString());
            }
        }

        private async void btnChangeCar_Click(object sender, EventArgs e)
        {
            //var list1 = ctx.Cars
            //    .Where(c => c.ID > 45 /* && c.Model.Contains("86") && c.Km > 200*/)
            //    .Where(c => c.Model.Contains("86"))
            //    .Where(c => c.Km > 200)
            //    .ToList();

            IQueryable<Car> query = ctx.Cars.AsQueryable();

            if (DateTime.Now.Day == 19)
            {
                query = query.Where(c => c.Km > 1000);
            }

            //if (DateTime.Now.Month == 7)
            //{
            //    query = query.Where(c => c.ID == 307);
            //}

            query = query
                .OrderByDescending(c => c.Km);
            //.ThenBy(c => c.ID)
            //.ThenByDescending(c => c.Identifier);

            Car car = query.FirstOrDefault();

            if (car != null)
            {
                car.Identifier = "BY198PE";
                car.Km++;
                await ctx.SaveChangesAsync();
            }

            //List<Car> automobili = ctx.Database
            //    .SqlQuery<Car>("SELECT Identifier, ID, Model, Km FROM dbo.Cars ORDER BY Km")
            //    .ToList();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.txtId.Text);

            //Car delete = ctx.Cars.Where(c => c.ID == id).FirstOrDefault();
            Car delete = await ctx.Cars.FirstOrDefaultAsync(c => c.ID == id);

            if (delete != null)
            {
                ctx.Cars.Remove(delete);
                //await ctx.SaveChangesAsync();
            }

            string sql = $"DELETE FROM dbo.Cars WHERE ID={id}";
            int numRecords = await ctx.Database.ExecuteSqlCommandAsync(sql);

        }

        //private bool filtraPerKm(Car auto)
        //{
        //    return auto.Km < 5000;
        //}
    }
}