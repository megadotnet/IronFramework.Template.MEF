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
    using System;using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract()]
    public partial class ProductDto : UIPaging
    {
        [Key()] 
        [Required] 
        [DataMember()] public int Id  {get; set; }
     
        [Required] 
        [DataMember()] public string ProductName  {get; set; }
        [DataMember()] public Nullable<System.DateTime> UpdatedTime  {get; set; }
     
        [Required] 
        [DataMember()] public int CategoryId  {get; set; }
    }
}
