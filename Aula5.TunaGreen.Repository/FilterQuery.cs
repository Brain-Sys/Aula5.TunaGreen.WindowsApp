using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.Repository
{
    public class FilterQuery : DatabaseLogFormatter
    {
        public FilterQuery(DbContext context, Action<string> act)
            :base(context, act)
        {

        }

        public override void Executing<TResult>(DbCommand command, DbCommandInterceptionContext<TResult> interceptionContext)
        {
            // command.CommandText += " AND Provincia = 'LO'";
            base.Executing(command, interceptionContext);
        }
    }
}