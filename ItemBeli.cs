//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework3
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemBeli
    {
        public int ItemBeliID { get; set; }
        public string Nota { get; set; }
        public string BarangID { get; set; }
        public Nullable<int> Jumlah { get; set; }
        public Nullable<int> HargaBeli { get; set; }
        public Nullable<int> HargaJual { get; set; }
    
        public virtual Barang Barang { get; set; }
        public virtual Beli Beli { get; set; }
    }
}
