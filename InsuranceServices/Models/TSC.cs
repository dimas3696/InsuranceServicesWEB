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
    
    public partial class TSC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSC()
        {
            this.CityOrCountryOfRegToZone = new HashSet<CityOrCountryOfRegToZone>();
        }
    
        public int Id { get; set; }
        public int IdCityOfRegistration { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
    
        public virtual CityOfRegistration CityOfRegistration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CityOrCountryOfRegToZone> CityOrCountryOfRegToZone { get; set; }
    }
}