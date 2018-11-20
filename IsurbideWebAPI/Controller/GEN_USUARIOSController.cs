using IsurbideWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IsurbideWebAPI.Controller
{
    public class GEN_USUARIOSController : ApiController
    {
        public IHttpActionResult GetAllGEN_USUARIOS()
        {
            IList<GEN_USUARIOSModel> GEN_USUARIOSModels = null;

            using (var ctx = new XOne_IsurbideEntities())
            {
                GEN_USUARIOSModels = ctx.GEN_USUARIOS
                            .Select(s => new GEN_USUARIOSModel()
                            {
                                ID = s.ID,
                                LOGIN = s.LOGIN,
                                PWD = s.PWD
                            }
                            ).ToList<GEN_USUARIOSModel>();
            }

            if (GEN_USUARIOSModels.Count == 0)
            {
                return NotFound();
            }
            return Ok(GEN_USUARIOSModels);
        }
        
        public IHttpActionResult GetGEN_USUARIOSByLogin(string login)
        {
            GEN_USUARIOSModel user = null;

            using (var ctx = new XOne_IsurbideEntities())
            {
                user = ctx.GEN_USUARIOS
                    .Where(s => s.LOGIN == login)
                    .Select(s => new GEN_USUARIOSModel()
                    {
                        ID = s.ID,
                        LOGIN = s.LOGIN,
                        PWD = s.PWD
                    }).FirstOrDefault<GEN_USUARIOSModel>();
            }

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
