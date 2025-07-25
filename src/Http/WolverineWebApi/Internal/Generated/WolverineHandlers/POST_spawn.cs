// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Runtime;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_spawn
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class POST_spawn : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;

        public POST_spawn(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Runtime.IWolverineRuntime wolverineRuntime) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _wolverineRuntime = wolverineRuntime;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            // Reading the request body via JSON deserialization
            var (input, jsonContinue) = await ReadJsonAsync<WolverineWebApi.SpawnInput>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            
            // The actual HTTP request handler execution
            (var stringValue, var outgoingMessages) = WolverineWebApi.MessageSpawnerEndpoint.Post(input);

            
            // Outgoing, cascaded message
            await messageContext.EnqueueCascadingAsync(outgoingMessages).ConfigureAwait(false);

            await WriteString(httpContext, stringValue);
            
            // Have to flush outgoing messages just in case Marten did nothing because of https://github.com/JasperFx/wolverine/issues/536
            await messageContext.FlushOutgoingMessagesAsync().ConfigureAwait(false);

        }

    }

    // END: POST_spawn
    
    
}

