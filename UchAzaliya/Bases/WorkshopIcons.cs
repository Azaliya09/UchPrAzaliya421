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
    
    public partial class WorkshopIcons
    {
        public int Id_Icon { get; set; }
        public Nullable<double> X_Position { get; set; }
        public Nullable<double> Y_Position { get; set; }
        public Nullable<double> Width_Icon { get; set; }
        public Nullable<double> Heaight_Icon { get; set; }
        public int Id_Workshop { get; set; }
    
        public virtual Icons Icons { get; set; }
        public virtual Workshop Workshop { get; set; }
    }
}
