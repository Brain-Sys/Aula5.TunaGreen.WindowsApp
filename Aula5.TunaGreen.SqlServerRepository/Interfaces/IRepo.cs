using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.SqlServerRepository.Interfaces
{
    public interface IRepo
    {
        void Init();
        IQueryable<Car> TableCars { get; }
        IQueryable<Brand> TableBrands { get; }
    }
}