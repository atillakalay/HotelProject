//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelProject.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLUYRUKLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLUYRUKLAR()
        {
            this.TBLCARILER = new HashSet<TBLCARILER>();
        }
    
        public int UYRUKID { get; set; }
        public string ULKEAD { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARILER> TBLCARILER { get; set; }
        public virtual TBLDURUMLAR TBLDURUMLAR { get; set; }
    }
}
