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
    
    public partial class Tbl_Rentcar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Rentcar()
        {
            this.Tbl_RentContent = new HashSet<Tbl_RentContent>();
            this.Tbl_Reservation = new HashSet<Tbl_Reservation>();
        }
    
        public short ID { get; set; }
        public string CarName { get; set; }
        public string CarImage { get; set; }
        public byte RentCagegoryID { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Sales { get; set; }
        public string About { get; set; }
        public string Oil { get; set; }
        public string Gerbox { get; set; }
        public string Km { get; set; }
        public string ChairCount { get; set; }
        public string Luggage { get; set; }
    
        public virtual Tbl_RentCategory Tbl_RentCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_RentContent> Tbl_RentContent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Reservation> Tbl_Reservation { get; set; }
        public virtual Tbl_SalesList Tbl_SalesList { get; set; }
    }
}
