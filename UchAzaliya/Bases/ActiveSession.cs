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
    
    public partial class ActiveSession
    {
        public string Login_User { get; set; }
        public Nullable<int> Computer_Number { get; set; }
    
        public virtual User User { get; set; }
    }
}
