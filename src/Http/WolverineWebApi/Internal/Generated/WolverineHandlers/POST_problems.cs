// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_problems
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class POST_problems : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public POST_problems(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var problemDetailsUsageEndpoint = new WolverineWebApi.ProblemDetailsUsageEndpoint();
            // Reading the request body via JSON deserialization
            var (message, jsonContinue) = await ReadJsonAsync<WolverineWebApi.NumberMessage>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var problemDetails1 = problemDetailsUsageEndpoint.Before(message);
            // Evaluate whether the processing should stop if there are any problems
            if (!(ReferenceEquals(problemDetails1, Wolverine.Http.WolverineContinue.NoProblems)))
            {
                await WriteProblems(problemDetails1, httpContext).ConfigureAwait(false);
                return;
            }


            
            // The actual HTTP request handler execution
            var result_of_Post = WolverineWebApi.ProblemDetailsUsageEndpoint.Post(message);

            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_problems
    
    
}

