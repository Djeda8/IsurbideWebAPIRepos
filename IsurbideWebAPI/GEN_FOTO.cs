//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsurbideWebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class GEN_FOTO
    {
        public int ID { get; set; }
        public int IDINCIDENCIA { get; set; }
        public int OTID { get; set; }
        public string FOTO { get; set; }
        public string ROWID { get; set; }
        public System.DateTime FECHAINSERCION { get; set; }
        public Nullable<System.DateTime> FECHAACTUALIZACION { get; set; }
        public int BORRADO { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
        public Nullable<int> FOTOMANT { get; set; }
        public Nullable<int> FOTOREP { get; set; }
    
        public virtual GEN_OT GEN_OT { get; set; }
        public virtual GEN_OTINCIDENCIA GEN_OTINCIDENCIA { get; set; }
    }
}
