//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace btap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class thongtinmathang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thongtinmathang()
        {
            this.ctdondathangs = new HashSet<ctdondathang>();
        }
    
        public int mamathang { get; set; }
        public string tenmathang { get; set; }
        public string manhinh { get; set; }
        public string hedieuhanh { get; set; }
        public string chip { get; set; }
        public string camera { get; set; }
        public string pin { get; set; }
        public string anh { get; set; }
        public string RAM { get; set; }
        public string bonhotrong { get; set; }
        public string cnmanhinh { get; set; }
        public Nullable<int> namramat { get; set; }
        public Nullable<int> gia { get; set; }
        public Nullable<int> mahangsanxuat { get; set; }
        public string tinhtrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ctdondathang> ctdondathangs { get; set; }
        public virtual hangsanxuat hangsanxuat { get; set; }
    }
}