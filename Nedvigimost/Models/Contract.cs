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
    
    public partial class Contract
    {
        public int Id { get; set; }
        public Nullable<int> IdUsers { get; set; }
        public Nullable<int> IdApplication { get; set; }
        public Nullable<int> IdRequest_for_an_appraiser { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual Application Application { get; set; }
        public virtual Report Report { get; set; }
        public virtual Request_for_an_appraiser Request_for_an_appraiser { get; set; }
        public virtual Users Users { get; set; }
    }
}
