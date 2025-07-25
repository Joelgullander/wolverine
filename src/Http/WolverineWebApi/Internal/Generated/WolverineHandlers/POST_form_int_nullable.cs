// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_form_int_nullable
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class POST_form_int_nullable : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public POST_form_int_nullable(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            string age_rawValue = httpContext.Request.Form["age"];
            System.Nullable<int> age = default;

            if (age_rawValue != null && int.TryParse(age_rawValue, System.Globalization.CultureInfo.InvariantCulture, out var age_parsed))
            {
                age = age_parsed;
            }

            // Just saying hello in the code! Also testing the usage of attributes to customize endpoints
            
            // The actual HTTP request handler execution
            var result_of_UsingFormParsingNullable = WolverineWebApi.TestEndpoints.UsingFormParsingNullable(age);

            await WriteString(httpContext, result_of_UsingFormParsingNullable);
        }

    }

    // END: POST_form_int_nullable
    
    
}

