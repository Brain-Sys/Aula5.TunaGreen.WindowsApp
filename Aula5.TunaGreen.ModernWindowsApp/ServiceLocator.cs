using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.ModernWindowsApp
{
    public static class ServiceLocator
    {
        public static T Resolve<T>(string setting) where T : class
        {
            T result = null;
            string classe = ConfigurationManager.AppSettings[setting];

            Type type = Type.GetType(classe);
            if (type != null)
            {
                result = Activator.CreateInstance(type) as T;
            }

            return result;
        }
    }
}