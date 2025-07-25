// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_querystring_datetime_nullable
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class GET_querystring_datetime_nullable : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_querystring_datetime_nullable(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            string value_rawValue = httpContext.Request.Query["value"];
            System.Nullable<System.DateTime> value = default;

            if (value_rawValue != null && System.DateTime.TryParse(value_rawValue, System.Globalization.CultureInfo.InvariantCulture, out var value_parsed))
            {
                value = value_parsed;
            }

            
            // The actual HTTP request handler execution
            var result_of_DateTimeNullable = WolverineWebApi.QuerystringEndpoints.DateTimeNullable(value);

            await WriteString(httpContext, result_of_DateTimeNullable);
        }

    }

    // END: GET_querystring_datetime_nullable
    
    
}

