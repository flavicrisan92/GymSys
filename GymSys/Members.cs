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
    
    public partial class Members
    {
        public Members()
        {
            this.Memberships = new HashSet<Memberships>();
            this.Scans = new HashSet<Scans>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public bool IsActive { get; set; }
    
        public virtual ICollection<Memberships> Memberships { get; set; }
        public virtual ICollection<Scans> Scans { get; set; }
    }
}
