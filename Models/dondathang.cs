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
    
    public partial class dondathang
    {
        public int madondathang { get; set; }
        public Nullable<int> makhachhang { get; set; }
        public string nguoinhan { get; set; }
        public string sdtnguoinhan { get; set; }
        public string diachinguoinhan { get; set; }
        public string emailnguoinhan { get; set; }
    
        public virtual thongtinkhachhang thongtinkhachhang { get; set; }
    }
}
