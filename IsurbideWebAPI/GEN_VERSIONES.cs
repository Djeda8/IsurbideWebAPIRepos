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
    
    public partial class GEN_VERSIONES
    {
        public int ID { get; set; }
        public string ROWID { get; set; }
        public Nullable<int> PRIMERUSUARIOID { get; set; }
        public Nullable<int> ULTIMOUSUARIOID { get; set; }
        public Nullable<int> MID { get; set; }
        public string VERSION_SW { get; set; }
        public string VERSION_BBDD { get; set; }
        public Nullable<System.DateTime> FECHAPRIMERLOGIN { get; set; }
        public Nullable<System.DateTime> FECHAULTIMOLOGIN { get; set; }
        public string LOGACTIVADO_SON { get; set; }
        public string LOGLEVEL { get; set; }
        public string MANTENIMIENTODB_SON { get; set; }
        public string DATABASENAME { get; set; }
        public string LICENSE { get; set; }
        public string CONNSTRING { get; set; }
        public string HOSTNAME { get; set; }
        public string HOSTNAME2 { get; set; }
        public Nullable<int> INTERVAL { get; set; }
        public Nullable<int> INTERVALTYPE { get; set; }
        public Nullable<int> TIMEOUT { get; set; }
        public string CONNECTIONMODE { get; set; }
        public Nullable<int> SERVERPORT { get; set; }
        public string FULLDUPLEX_SON { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string SYNCHRONIZE_SON { get; set; }
        public string COMPRESSUP_SON { get; set; }
        public string COMPRESSDOWN_SON { get; set; }
        public Nullable<int> BATCHSIZEUP { get; set; }
        public Nullable<int> ITX_TERMINAL { get; set; }
    
        public virtual GEN_USUARIOS GEN_USUARIOS { get; set; }
        public virtual GEN_USUARIOS GEN_USUARIOS1 { get; set; }
    }
}
