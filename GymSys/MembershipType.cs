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
    
    public partial class MembershipType
    {
        public MembershipType()
        {
            this.Memberships = new HashSet<Memberships>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<double> Price { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime Created { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public int MonthsNumber { get; set; }
        public int DaysNumber { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Memberships> Memberships { get; set; }
    }
}
