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
    
    public partial class TBLBANKAHAREKETLER
    {
        public int BANKAHAREKETID { get; set; }
        public Nullable<int> HESAPID { get; set; }
        public string HESAPBELGENO { get; set; }
        public Nullable<decimal> GIREN { get; set; }
        public Nullable<decimal> CIKAN { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> ISLEMID { get; set; }
        public Nullable<int> PERSONEL { get; set; }
        public Nullable<int> DURUM { get; set; }
    
        public virtual TBLBANKALAR TBLBANKALAR { get; set; }
        public virtual TBLDURUMLAR TBLDURUMLAR { get; set; }
        public virtual TBLDURUMLAR TBLDURUMLAR1 { get; set; }
        public virtual TBLISLEMLER TBLISLEMLER { get; set; }
        public virtual TBLPERSONELLER TBLPERSONELLER { get; set; }
    }
}
