using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomFilters.Filters
{
    public class NewCustomActionFilter : Attribute, IActionFilter, IResultFilter, IOrderedFilter
    {
        public int Order { get; set; }

        IHttpContextAccessor _httpContextAccessor = null;

        public NewCustomActionFilter(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }


        public void OnActionExecuting(ActionExecutingContext context)
        {
            DoLogging("On Action Executing", context.RouteData);


            int Hours = Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (Hours < 10)
            {
                context.HttpContext.Response.WriteAsync("<h1>You cant access this area before 10 AM..</h1>");
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);

            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.Canceled)
                DoLogging("On Action Executed", context.RouteData);
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ViewResult)
                DoLogging("On Result Executing", context.RouteData);
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            if (context.Result is ViewResult)
                DoLogging("On Result Executed", context.RouteData);
        }
        public void DoLogging(string FunctionName, RouteData routedata)
        {
            string Controller, Action;

            Controller = routedata.Values["controller"].ToString();
            Action = routedata.Values["action"].ToString();
            string str = string.Format("1 - Function Name ={0}, Controller Name={1}, Action={2}", FunctionName, Controller, Action);
            _httpContextAccessor.HttpContext.Response.WriteAsync("<br>" + str + "<br>");


        }


    }
}
