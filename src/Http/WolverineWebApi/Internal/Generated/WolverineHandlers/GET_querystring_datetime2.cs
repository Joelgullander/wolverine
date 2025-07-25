// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_datetime2
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class GET_querystring_datetime2 : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_datetime2(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            string value_rawValue = httpContext.Request.Query["value"];
            System.DateTime value = default;

            if (value_rawValue != null && System.DateTime.TryParse(value_rawValue, System.Globalization.CultureInfo.InvariantCulture, out value))
            {

            }

            
            // The actual HTTP request handler execution
            var result_of_DateTime2 = WolverineWebApi.QuerystringEndpoints.DateTime2(value);

            await WriteString(httpContext, result_of_DateTime2);
        }

    }

    // END: GET_querystring_datetime2
    
    
}

