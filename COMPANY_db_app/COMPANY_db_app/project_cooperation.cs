//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COMPANY_db_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class project_cooperation
    {
        public long Id { get; set; }
        public long Project_Id { get; set; }
        public long Team_Id { get; set; }
        public System.DateTime DateAssigned { get; set; }
    
        public virtual projects projects { get; set; }
        public virtual teams teams { get; set; }
    }
}
