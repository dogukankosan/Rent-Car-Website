//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RodinaTurkey.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Reservation
    {
        public short ID { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public Nullable<short> CarID { get; set; }
        public string ContentText { get; set; }
        public Nullable<byte> PickupAdressID { get; set; }
        public Nullable<byte> PickupDropID { get; set; }
        public Nullable<System.DateTime> FirstDate { get; set; }
        public Nullable<System.DateTime> LastDate { get; set; }
    
        public virtual Tbl_Rentcar Tbl_Rentcar { get; set; }
        public virtual Tbl_Pickup Tbl_Pickup { get; set; }
        public virtual Tbl_Pickup Tbl_Pickup1 { get; set; }
    }
}
