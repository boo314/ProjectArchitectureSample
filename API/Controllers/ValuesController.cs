using API.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        [TokenValidation]
        public IHttpActionResult Get()
        {
            return Content(HttpStatusCode.OK, "");
        }
    }
}
