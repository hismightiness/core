//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_RegionTranslation
    {
        public long RegionTranslationId { get; set; }
        public System.Guid RegionId { get; set; }
        public string Culture { get; set; }
        public string DisplayName { get; set; }
    
        public virtual hcc_Region hcc_Regions { get; set; }
    }
}
