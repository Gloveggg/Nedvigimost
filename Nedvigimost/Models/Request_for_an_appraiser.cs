//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nedvigimost.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request_for_an_appraiser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request_for_an_appraiser()
        {
            this.Contract = new HashSet<Contract>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdUsers { get; set; }
        public string Name { get; set; }
        public Nullable<int> Phone { get; set; }
        public string Adress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual Users Users { get; set; }
    }
}