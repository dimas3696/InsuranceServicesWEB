//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceServices.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiscountForClientWithPrivilegies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiscountForClientWithPrivilegies()
        {
            this.Contract = new HashSet<Contract>();
        }
    
        public int Id { get; set; }
        public int IdDocumentType { get; set; }
        public Nullable<double> Value { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}