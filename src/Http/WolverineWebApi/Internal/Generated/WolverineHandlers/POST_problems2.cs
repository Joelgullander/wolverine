// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_problems2
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class POST_problems2 : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public POST_problems2(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            // Reading the request body via JSON deserialization
            var (message, jsonContinue) = await ReadJsonAsync<WolverineWebApi.NumberMessage>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var problemDetails1 = WolverineWebApi.NumberMessageHandler.Validate(message);
            // Evaluate whether the processing should stop if there are any problems
            if (!(ReferenceEquals(problemDetails1, Wolverine.Http.WolverineContinue.NoProblems)))
            {
                await WriteProblems(problemDetails1, httpContext).ConfigureAwait(false);
                return;
            }


            
            // The actual HTTP request handler execution
            WolverineWebApi.NumberMessageHandler.Handle(message);

            // Wolverine automatically sets the status code to 204 for empty responses
            if (httpContext.Response is { HasStarted: false, StatusCode: 200 }) httpContext.Response.StatusCode = 204;
        }

    }

    // END: POST_problems2
    
    
}

