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
    
    public partial class GEN_FAMILIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GEN_FAMILIA()
        {
            this.GEN_OTUSUARIO = new HashSet<GEN_OTUSUARIO>();
        }
    
        public int ID { get; set; }
        public string ROWID { get; set; }
        public int IDEMPRESA { get; set; }
        public Nullable<int> ID_INT { get; set; }
        public string TIPOPARTE { get; set; }
        public string CODIGOFAMILIA { get; set; }
        public string CODIGOSUBFAMILIA { get; set; }
        public string CODIGOARTICULO { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHAINSERCION { get; set; }
        public Nullable<System.DateTime> FECHAACTUALIZACION { get; set; }
        public int BORRADO { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
        public Nullable<int> MARCADO { get; set; }
    
        public virtual GEN_EMPRESA GEN_EMPRESA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_OTUSUARIO> GEN_OTUSUARIO { get; set; }
    }
}
