using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.DomainModel
{
    public class FuelType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool Electric { get; set; }
        public int? Available { get; set; }
        public Nullable<double> Liters { get; set; }

        public FuelType()
        {

        }
    }
}