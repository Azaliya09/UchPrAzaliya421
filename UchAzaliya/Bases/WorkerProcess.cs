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
    
    public partial class WorkerProcess
    {
        public int Id_WorkProc { get; set; }
        public string Login_Worker { get; set; }
        public string Name_Process { get; set; }
    
        public virtual CreatingProcess CreatingProcess { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
