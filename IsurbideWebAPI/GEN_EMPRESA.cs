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
    
    public partial class GEN_EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GEN_EMPRESA()
        {
            this.GEN_CITA = new HashSet<GEN_CITA>();
            this.GEN_CLIENTE = new HashSet<GEN_CLIENTE>();
            this.GEN_CONTACTO = new HashSet<GEN_CONTACTO>();
            this.GEN_FAMILIA = new HashSet<GEN_FAMILIA>();
            this.GEN_MATERIAL = new HashSet<GEN_MATERIAL>();
            this.GEN_OT = new HashSet<GEN_OT>();
            this.GEN_OTTAREA = new HashSet<GEN_OTTAREA>();
            this.GEN_TAREA = new HashSet<GEN_TAREA>();
            this.GEN_USUARIOS = new HashSet<GEN_USUARIOS>();
            this.GEN_VEHICULO = new HashSet<GEN_VEHICULO>();
        }
    
        public int ID { get; set; }
        public string ROWID { get; set; }
        public int CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
        public int BORRADO { get; set; }
        public Nullable<int> MARCADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_CITA> GEN_CITA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_CLIENTE> GEN_CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_CONTACTO> GEN_CONTACTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_FAMILIA> GEN_FAMILIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_MATERIAL> GEN_MATERIAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_OT> GEN_OT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_OTTAREA> GEN_OTTAREA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_TAREA> GEN_TAREA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_USUARIOS> GEN_USUARIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_VEHICULO> GEN_VEHICULO { get; set; }
    }
}
