//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace slnMumu_MidtermProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Likes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Likes()
        {
            this.LikeDetails = new HashSet<LikeDetails>();
        }
    
        public int LikeID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<int> ProjectID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LikeDetails> LikeDetails { get; set; }
        public virtual Members Members { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
