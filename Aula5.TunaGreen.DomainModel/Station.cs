using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.DomainModel
{
    public class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<FuelType> Types { get; set; }
    }
}