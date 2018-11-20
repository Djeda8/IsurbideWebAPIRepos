using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsurbideWebAPI.Models
{
    public class GEN_OTModel
    {
        public int ID { get; set; }
        public Nullable<int> ESTADOID { get; set; }
        public int IDEMPRESA { get; set; }
        public string CODIGOPARTEID { get; set; }
        public string ID_INT { get; set; }
        public string CODIGOTIPO { get; set; }
        public string TIPOPARTE { get; set; }
        public int EJERCICIO { get; set; }
        public string SERIE { get; set; }
        public int NUMERO { get; set; }
        public System.DateTime FECHAALTA { get; set; }
        public Nullable<System.DateTime> FECHAINTEGRACIONMOVILIDAD { get; set; }
        public Nullable<System.DateTime> FECHAINTEGRACIONORIGEN { get; set; }
        public Nullable<int> FORZARINTEGRACIONORIGEN { get; set; }
        public string ROWID { get; set; }
        public System.DateTime FECHAINSERCION { get; set; }
        public Nullable<System.DateTime> FECHAACTUALIZACION { get; set; }
        public int BORRADO { get; set; }
        public string CLIENTECODIGO { get; set; }
        public string CLIENTENOMBRE { get; set; }
        public string CLIENTEDIRECCION { get; set; }
        public string CLIENTEPOBLACION { get; set; }
        public Nullable<int> IDRESPONSABLE { get; set; }
        public System.DateTime FECHAINTERVENCION { get; set; }
        public string TIEMPO { get; set; }
        public string DESC_MANT { get; set; }
        public string DESC_SERV { get; set; }
        public Nullable<int> ADMINISTRADORCODIGO { get; set; }
        public string ADMINISTRADORNOMBRE { get; set; }
        public string ADMINISTRADORTELEFONO { get; set; }
        public string ADMINISTRADOREMAIL { get; set; }
        public string AFECTADONOMBRE { get; set; }
        public string AFECTADOTELEFONO { get; set; }
        public string PERSONANOMBRE { get; set; }
        public string PERSONATELEFONO { get; set; }
        public GEN_ESTADOModel GEN_ESTADOModel { get; set; }
        public virtual ICollection<GEN_CITAModel> GEN_CITAModel { get; set; }
    }
}