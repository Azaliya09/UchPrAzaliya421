//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UchAzaliya.Bases
{
    using System;
    using System.Collections.Generic;
    
    public partial class ComponentProduct
    {
        public int Id_CompProd { get; set; }
        public string Id_Component { get; set; }
        public Nullable<int> Id_Product { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Component Component { get; set; }
        public virtual Product Product { get; set; }
    }
}
