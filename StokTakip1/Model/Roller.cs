//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip1.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Roller
    {
        public Roller()
        {
            this.Kullanici_Role = new HashSet<Kullanici_Role>();
        }
    
        public int RoleId { get; set; }
        public string RolAdi { get; set; }
    
        public virtual ICollection<Kullanici_Role> Kullanici_Role { get; set; }
    }
}
