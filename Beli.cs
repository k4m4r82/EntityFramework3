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
    
    public partial class Beli
    {
        public Beli()
        {
            this.ItemBelis = new HashSet<ItemBeli>();
        }
    
        public string Nota { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<System.DateTime> Tanggal { get; set; }
        public string Keterangan { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ItemBeli> ItemBelis { get; set; }
    }
}