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
    
    public partial class TBLODALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLODALAR()
        {
            this.TBLCARIKONUKHAREKETLER = new HashSet<TBLCARIKONUKHAREKETLER>();
            this.TBLREZERVASYONLAR = new HashSet<TBLREZERVASYONLAR>();
        }
    
        public int ODAID { get; set; }
        public string ODANO { get; set; }
        public string KAT { get; set; }
        public string KAPASITE { get; set; }
        public string OZELLIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string TELEFON { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLCARIKONUKHAREKETLER> TBLCARIKONUKHAREKETLER { get; set; }
        public virtual TBLDURUMLAR TBLDURUMLAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLREZERVASYONLAR> TBLREZERVASYONLAR { get; set; }
    }
}
