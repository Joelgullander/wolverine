// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_name_name
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class GET_name_name : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_name_name(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var name = (string?)httpContext.GetRouteValue("name");
            if(name == null)
            {
                httpContext.Response.StatusCode = 404;
                return;
            }

            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            
            // The actual HTTP request handler execution
            var result_of_SimpleStringRouteArgument = WolverineWebApi.TestEndpoints.SimpleStringRouteArgument(name);

            await WriteString(httpContext, result_of_SimpleStringRouteArgument);
        }

    }

    // END: GET_name_name
    
    
}

