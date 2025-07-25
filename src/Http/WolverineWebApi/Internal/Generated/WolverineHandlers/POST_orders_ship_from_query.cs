// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Marten.Publishing;
using Wolverine.Runtime;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_orders_ship_from_query
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class POST_orders_ship_from_query : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public POST_orders_ship_from_query(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Runtime.IWolverineRuntime wolverineRuntime, Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _wolverineRuntime = wolverineRuntime;
            _outboxedSessionFactory = outboxedSessionFactory;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            string id_rawValue = httpContext.Request.Query["id"];
            System.Guid id = default;

            if (id_rawValue != null && System.Guid.TryParse(id_rawValue, System.Globalization.CultureInfo.InvariantCulture, out id))
            {

            }

            await using var documentSession = _outboxedSessionFactory.OpenSession(messageContext);
            var eventStoreOperations = documentSession.Events;
            var eventStream = await documentSession.Events.FetchForWriting<WolverineWebApi.Marten.Order>(id, httpContext.RequestAborted);
            if (eventStream.Aggregate == null)
            {
                await Microsoft.AspNetCore.Http.Results.NotFound().ExecuteAsync(httpContext);
                return;
            }

            
            // The actual HTTP request handler execution
            var orderShipped = WolverineWebApi.Marten.MarkItemEndpoint.ShipFromQuery(id, eventStream.Aggregate);

            eventStream.AppendOne(orderShipped);
            await documentSession.SaveChangesAsync(httpContext.RequestAborted).ConfigureAwait(false);
            // Wolverine automatically sets the status code to 204 for empty responses
            if (httpContext.Response is { HasStarted: false, StatusCode: 200 }) httpContext.Response.StatusCode = 204;
        }

    }

    // END: POST_orders_ship_from_query
    
    
}

