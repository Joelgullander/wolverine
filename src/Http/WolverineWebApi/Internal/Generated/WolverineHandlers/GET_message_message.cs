// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using WolverineWebApi;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_message_message
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class GET_message_message : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly WolverineWebApi.Recorder _recorder;

        public GET_message_message(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, WolverineWebApi.Recorder recorder) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _recorder = recorder;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var message = (string?)httpContext.GetRouteValue("message");
            if(message == null)
            {
                httpContext.Response.StatusCode = 404;
                return;
            }

            var serviceEndpoints = new WolverineWebApi.ServiceEndpoints();
            
            // The actual HTTP request handler execution
            var result_of_GetMessage = serviceEndpoints.GetMessage(message, _recorder);

            await WriteString(httpContext, result_of_GetMessage);
        }

    }

    // END: GET_message_message
    
    
}

