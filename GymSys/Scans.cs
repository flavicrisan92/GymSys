//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymSys
{
    using System;
    using System.Collections.Generic;
    
    public partial class Scans
    {
        public int Id { get; set; }
        public int IdMember { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Members Members { get; set; }
    }
}
