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
    
    public partial class TBLISLEMLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLISLEMLER()
        {
            this.TBLBANKAHAREKETLER = new HashSet<TBLBANKAHAREKETLER>();
            this.TBLCARIHAREKETLER = new HashSet<TBLCARIHAREKETLER>();
            this.TBLKASAHAREKETLER = new HashSet<TBLKASAHAREKETLER>();
        }
    
        public int ISLEMID { get; set; }
        public string ISLEMAD { get; set; }
        public string KATEGORI { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLBANKAHAREKETLER> TBLBANKAHAREKETLER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIHAREKETLER> TBLCARIHAREKETLER { get; set; }
        public virtual TBLDURUMLAR TBLDURUMLAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKASAHAREKETLER> TBLKASAHAREKETLER { get; set; }
    }
}