//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HEYS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLYetki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLYetki()
        {
            this.TBLKullanıcı = new HashSet<TBLKullanıcı>();
        }
    
        public int YetkiId { get; set; }
        public Nullable<int> YetkiDurum { get; set; }
        public string Yetki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLKullanıcı> TBLKullanıcı { get; set; }
    }
}
