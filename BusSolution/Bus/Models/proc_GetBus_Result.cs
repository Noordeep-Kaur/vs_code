//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bus.Models
{
    using System;
    
    public partial class proc_GetBus_Result
    {
        public int RouteID { get; set; }
        public int TripID { get; set; }
        public string CompanyName { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public System.TimeSpan FromTime { get; set; }
        public System.TimeSpan ToTime { get; set; }
        public string FromDescription { get; set; }
        public string ToDescription { get; set; }
        public int Fare { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
