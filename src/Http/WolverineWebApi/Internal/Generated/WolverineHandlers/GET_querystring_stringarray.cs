// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_stringarray
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class GET_querystring_stringarray : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_stringarray(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var values = httpContext.Request.Query["values"].ToArray();
            
            // The actual HTTP request handler execution
            var result_of_StringArray = WolverineWebApi.QuerystringEndpoints.StringArray(values);

            await WriteString(httpContext, result_of_StringArray);
        }

    }

    // END: GET_querystring_stringarray
    
    
}

