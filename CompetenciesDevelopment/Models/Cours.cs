//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Courses.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lecturer { get; set; }
        public string place { get; set; }
        public byte[] img { get; set; }
        public string description { get; set; }
        public System.DateTime date { get; set; }
    }
}
