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
    
    public partial class Memberships
    {
        public int Id { get; set; }
        public int IdMembershipType { get; set; }
        public int IdMember { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Members Members { get; set; }
        public virtual MembershipType MembershipType { get; set; }
    }
}
