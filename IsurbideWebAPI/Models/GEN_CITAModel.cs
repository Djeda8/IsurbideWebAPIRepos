using System;

namespace IsurbideWebAPI.Models
{
    public class GEN_CITAModel
    {
        public int ID { get; set; }
        public string ROWID { get; set; }
        public int USUARIOID { get; set; }
        public Nullable<int> OTID { get; set; }
        public int IDEMPRESA { get; set; }
        public string ID_INT { get; set; }
        public System.DateTime FECHAHORAINICIO { get; set; }
        public System.DateTime FECHAHORAFIN { get; set; }
        public string DESCRIPCION { get; set; }
        public System.DateTime FECHAINSERCION { get; set; }
        public Nullable<System.DateTime> FECHAACTUALIZACION { get; set; }
        public int BORRADO { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
        public Nullable<int> MARCADO { get; set; }
        public string CODIGOTIPO { get; set; }
        public Nullable<int> EJERCICIO { get; set; }
        public string SERIE { get; set; }
        public Nullable<int> NUMERO { get; set; }
        public string CODIGOTIPOFASE { get; set; }

        public virtual GEN_OT GEN_OT { get; set; }
    }
}