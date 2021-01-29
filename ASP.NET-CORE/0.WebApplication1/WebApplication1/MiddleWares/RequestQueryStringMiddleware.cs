using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.MiddleWares
{
    public class RequestQueryStringMiddleware
    {
        private RequestDelegate next;

        public RequestQueryStringMiddleware(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.RequestMethod = HttpMethods.Get 
                && context.Request.Query["iscertified"] == "true")
            {
                await context.Response.WriteAsync("Message from Class-Based Middleware \n");
            }
            await next(context);
        }
    }
}
