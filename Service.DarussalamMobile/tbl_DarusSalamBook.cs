//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service.DarussalamMobile
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_DarusSalamBook
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DarusSalamBook()
        {
            this.tbl_DarussalamMobileCart = new HashSet<tbl_DarussalamMobileCart>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Writer { get; set; }
        public string Publisher { get; set; }
        public Nullable<int> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> OutOfStock { get; set; }
        public Nullable<int> InStock { get; set; }
        public string Barcode { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DarussalamMobileCart> tbl_DarussalamMobileCart { get; set; }
    }
}
