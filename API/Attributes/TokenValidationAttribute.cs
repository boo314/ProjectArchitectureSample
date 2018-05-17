using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace API.Attributes
{
    public class TokenValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var token = "";
            if (actionContext.Request.Headers.Contains("ApiToken"))
            {
                var apiTokenHeader = actionContext.Request.Headers.FirstOrDefault(x => x.Key == "ApiToken");
                token = apiTokenHeader.Value.FirstOrDefault();
            }
            if (token != "Woot")
            {
                actionContext.Response = new HttpResponseMessage();
                actionContext.Response.StatusCode = System.Net.HttpStatusCode.Unauthorized;
            }

            base.OnActionExecuting(actionContext);  
        }
    }
}