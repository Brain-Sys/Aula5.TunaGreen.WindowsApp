using System.Web;
using System.Web.Mvc;

namespace Aula5.TunaGreen.OfficialWebsite
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
