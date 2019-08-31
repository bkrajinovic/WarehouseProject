using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Warehouse.Responses;

namespace Warehouse.Extensions{
   public static class GlobalExceptionHandler
   {
       public static void ConfigureExceptionHandler(this IApplicationBuilder app)
       {
           app.UseExceptionHandler(appError =>
           {
               appError.Run(async context =>
               {
                   context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                   context.Response.ContentType = "application/json";
                   var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                   if(contextFeature != null)
                   {
                       await context.Response.WriteAsync(JsonConvert.SerializeObject(new ErrorDetails()
                       {
                           StatusCode = context.Response.StatusCode,
                           Message = contextFeature.Error.Message.ToString()
                       }));
                   }
               });
           });
       }
   }
}