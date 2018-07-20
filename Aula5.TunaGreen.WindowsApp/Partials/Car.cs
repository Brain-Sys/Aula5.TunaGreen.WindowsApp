using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5.TunaGreen.WindowsApp
{
    public partial class Car
    {
        public bool Usurata { get; set; }

        public bool IsMoreThan10Years
        {
            get
            {
                if (this.RegistrationDate.HasValue)
                {
                    return DateTime.Now.Year -
                      this.RegistrationDate.Value.Year > 10;
                }
                else
                {
                    throw new ArgumentNullException("non lo so :-(");
                }
            }
        }

        // Parameterless (default)
        // Serializzazione / Deserializzazione
        public Car()
        {

        }

        public Car(string identifier)
        {
            this.Color = "White";
            this.Identifier = identifier;
        }

        public byte[] Stampa()
        {
            return null;
        }
    }
}