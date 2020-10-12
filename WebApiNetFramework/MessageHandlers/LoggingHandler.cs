using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiNetFramework.MessageHandlers
{
    public class LoggingHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine("Process request");
            return new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            //var response = await base.SendAsync(request, cancellationToken);
            //Debug.WriteLine("Process response");
            //return response;
        }
    }
}