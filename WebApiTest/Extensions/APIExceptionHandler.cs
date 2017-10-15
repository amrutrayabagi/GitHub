using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc.Filters;

namespace WebApiTest.Extensions
{
    public class APIExceptionHandler : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnException(actionExecutedContext);
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                ReasonPhrase = "An Error occured while processing your request!"
            };
        }

        public override Task OnExceptionAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage()
            {
                StatusCode = System.Net.HttpStatusCode.InternalServerError,
                ReasonPhrase = "An Error occured while processing your request!",                
                
            };
            return base.OnExceptionAsync(actionExecutedContext, cancellationToken);
        }

    }
}