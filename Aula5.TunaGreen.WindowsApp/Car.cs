//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aula5.TunaGreen.WindowsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        public int ID { get; set; }
        public string Model { get; set; }
        public double Km { get; set; }
        public string Identifier { get; set; }
        public string Color { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        public int IDBrand { get; set; }
    
        public virtual Brand Brand { get; set; }
    }
}
