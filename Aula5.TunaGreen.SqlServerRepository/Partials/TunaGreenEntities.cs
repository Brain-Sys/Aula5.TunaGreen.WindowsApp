using Aula5.TunaGreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.SqlServerRepository
{
    public partial class TunaGreenEntities : IRepo
    {
        public void Init()
        {
#if DEBUG
            // this.Database.Connection.ConnectionString = "";
#endif

#if !DEBUG
            // this.Database.Connection.ConnectionString = "";
#endif
        }
    }
}