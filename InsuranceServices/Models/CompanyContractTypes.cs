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
    
    public partial class CompanyContractTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyContractTypes()
        {
            this.ContractFranchise = new HashSet<ContractFranchise>();
        }
    
        public int Id { get; set; }
        public int IdCompanyMiddleman { get; set; }
        public int IdContractType { get; set; }
    
        public virtual CompanyMiddleman CompanyMiddleman { get; set; }
        public virtual ContractType ContractType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractFranchise> ContractFranchise { get; set; }
    }
}
