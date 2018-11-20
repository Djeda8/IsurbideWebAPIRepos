using IsurbideWebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace IsurbideWebAPI.Controller
{
    public class GEN_OTController : ApiController
    {
        public string Get(int i)
        {
            return i.ToString();
        }

        public IHttpActionResult GetAllGEN_OT()
        {
            IList<GEN_OTModel> GEN_OTModels = null;

            using (var ctx = new XOne_IsurbideEntities())
            {
                GEN_OTModels = ctx.GEN_OT.Include("GEN_ESTADO")
                            .Where(s => s.BORRADO == 0)
                            .OrderBy(s => s.NUMERO)
                            .Select(s => new GEN_OTModel()
                            {   ID = s.ID,
                                NUMERO = s.NUMERO,
                                SERIE = s.SERIE,
                                TIPOPARTE = s.TIPOPARTE,
                                CLIENTENOMBRE = s.CLIENTENOMBRE,
                                CLIENTEDIRECCION = s.CLIENTEDIRECCION,
                                FECHAINTERVENCION = s.FECHAINTERVENCION,
                                GEN_ESTADOModel = s.GEN_ESTADO == null ? new GEN_ESTADOModel()
                                {
                                    ID = 1,
                                    CODIGOESTADO = 0,
                                    DESCRIPCION = "PENDIENTE"
                                }

                                : new GEN_ESTADOModel()
                                {
                                    ID = s.GEN_ESTADO.ID,
                                    CODIGOESTADO = s.GEN_ESTADO.CODIGOESTADO,
                                    DESCRIPCION = s.GEN_ESTADO.DESCRIPCION
                                }
                            }
                            ).ToList<GEN_OTModel>();
            }

            if (GEN_OTModels.Count == 0)
            {
                return NotFound();
            }
            return Ok(GEN_OTModels);
        }
    }
}
