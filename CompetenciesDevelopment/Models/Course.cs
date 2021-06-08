//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompetenciesDevelopment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Course
    {
        public int id { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"^[^<>*\\]*$")]
        public string name { get; set; }
        [StringLength(30, MinimumLength = 5)]
        [RegularExpression(@"^[^<>*\\]*$")]
        public string lecturer { get; set; }
        [StringLength(20, MinimumLength = 4)]
        [RegularExpression(@"^[^<>*\\]*$")]

      
        public string place { get; set; }
  public string doc { get; set; }
        public string img { get; set; }
  
        [StringLength(100, MinimumLength = 10)]
        [RegularExpression(@"^[^<>*\\]*$")]
        public string description { get; set; }
        public System.DateTime date { get; set; }
        [StringLength(20, MinimumLength = 1)]
        [RegularExpression(@"^[^<>*\\]*$")]
        public string category { get; set; }
    }
}
