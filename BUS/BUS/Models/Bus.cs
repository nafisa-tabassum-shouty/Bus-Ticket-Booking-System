//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BUS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bus
    {
        public int BUS_ID { get; set; }
        public string BUS_NUMBER { get; set; }
        public int CAPACITY { get; set; }
        public Nullable<int> ROUTE_ID { get; set; }
    }
}