// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: HttpMessage1Handler862252953
    [global::System.CodeDom.Compiler.GeneratedCode("JasperFx", "1.0.0")]
    public sealed class HttpMessage1Handler862252953 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            // The actual message body
            var httpMessage1 = (WolverineWebApi.HttpMessage1)context.Envelope.Message;

            System.Diagnostics.Activity.Current?.SetTag("message.handler", "WolverineWebApi.MessageHandler");
            
            // The actual message execution
            WolverineWebApi.MessageHandler.Handle(httpMessage1);

            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: HttpMessage1Handler862252953
    
    
}

