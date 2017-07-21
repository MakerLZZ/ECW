//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECW.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShippingAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShippingAddress()
        {
            this.Indent = new HashSet<Indent>();
        }
    
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Region { get; set; }
        public string RegionDetails { get; set; }
        public int Postcode { get; set; }
        public string ConsigneeName { get; set; }
        public string PhoneNumber { get; set; }
        public bool Condition { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Indent> Indent { get; set; }
        public virtual User User { get; set; }
    }
}