//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace galetova_22106_prilojenie.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kolichestvo_uslug
    {
        public int ID_usligi { get; set; }
        public int ID_zakaza { get; set; }
        public Nullable<int> kolichestvo { get; set; }
    
        public virtual Uslugi Uslugi { get; set; }
        public virtual Zakaz Zakaz { get; set; }
    }
}
