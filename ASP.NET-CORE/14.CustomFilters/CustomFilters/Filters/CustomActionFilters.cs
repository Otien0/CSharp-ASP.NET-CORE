using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using RouteData = Microsoft.AspNetCore.Routing.RouteData;
using Microsoft.AspNetCore.Mvc;

namespace CustomFilters.Filters
{
    public class CustomActionFilters : Attribute,IActionFilter, IResultFilter, IOrderedFilter
    {
        public int Order { get; set; }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            DoLogging("On Action Executing", context.RouteData, context.HttpContext);

            int Hours = Convert.ToInt32(DateTime.Now.ToString("HH"));

            if (Hours < 10)
            {
                context.HttpContext.Response.WriteAsync("<h1>You can't access this area before 10 AM..</h1>");
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.Canceled)
                DoLogging("On Action Executed", context.RouteData, context.HttpContext);
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.Result is ViewResult)
                DoLogging("On Result Executing", context.RouteData, context.HttpContext);
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            if (context.Result is ViewResult)
                DoLogging("On Result Executed", context.RouteData, context.HttpContext);
        }

        public void DoLogging(string FunctionName, RouteData routedata, HttpContext _httpContext)
        {
            string Controller, Action;

            Controller = routedata.Values["controller"].ToString();
            Action = routedata.Values["action"].ToString();
            string str = string.Format("1 - Function Name ={0}, Controller Name={1}, Action={2}", FunctionName, Controller, Action);
            _httpContext.Response.WriteAsync("<br>" + str + "<br>");
        }
    }
}
