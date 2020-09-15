using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace Cinema.Web.Api.Filters
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine(context.Exception.Message);

            context.ModelState.AddModelError("ERROR", "Internal Server Error");
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            context.Result = new JsonResult(context.ModelState);
        }

    }
}
