//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication8
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moto
    {
        public int patente { get; set; }
        public int usuario_id { get; set; }
        public string modelo { get; set; }
        public string registro { get; set; }
        public string seguro { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
