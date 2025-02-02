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
    
    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            this.Carts = new HashSet<Carts>();
            this.OrderDetails = new HashSet<OrderDetails>();
        }
    
        public int ProductID { get; set; }
        public int ProjectID { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public int Inventory { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime ExpireDate { get; set; }
        public string Thumbnail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carts> Carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
