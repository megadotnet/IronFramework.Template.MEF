//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntiies
{
    using System;using IronFramework.Utility.EntityFramewrok;
    using System.Collections.Generic;
    
    public partial class Product:IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.DateTime> UpdatedTime { get; set; }
        public int CategoryId { get; set; }
    
        #region IEntity Members
            public State State { get; set; } 
        #endregion
          
        public virtual Categroy Categroy { get; set; }
    }
}
