//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEF6_SQLite
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_ObjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_ObjectType()
        {
            this.Table_ObjectInfoType = new HashSet<Table_ObjectInfoType>();
            this.Table_PropertyType = new HashSet<Table_PropertyType>();
        }
    
        public long id { get; set; }
        public string Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Type { get; set; }
        public string BitSize { get; set; }
        public string Flags_Access { get; set; }
        public string Flags_Category { get; set; }
        public string Flags_PdoMapping { get; set; }
        public string Flags_SafetyMapping { get; set; }
        public string Flags_Attribute { get; set; }
        public string Flags_Transition { get; set; }
        public string Flags_SdoAccess { get; set; }
        public string Flags_Backup { get; set; }
        public string Flags_Setting { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_ObjectInfoType> Table_ObjectInfoType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_PropertyType> Table_PropertyType { get; set; }
    }
}
