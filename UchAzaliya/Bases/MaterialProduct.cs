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
    
    public partial class MaterialProduct
    {
        public int Id_MatProd { get; set; }
        public string Id_Material { get; set; }
        public Nullable<int> Id_Product { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Product Product { get; set; }
    }
}
