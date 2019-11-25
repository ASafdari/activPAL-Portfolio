using System.Threading;
using System.Threading.Tasks;
using MediatR.Pipeline;
using Microsoft.Extensions.Logging;

namespace Portfolio.Application.Common.Behaviours
{
    /// <summary>
    /// Responsible for logging all types of Mediatr IRequest/>
    /// </summary>
    public class RequestLogger<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger<TRequest> _logger;

        public RequestLogger(ILogger<TRequest> logger)
        {
            _logger = logger;
        }

        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var name = typeof(TRequest).Name;

            _logger.LogInformation("Request: {Name} {@Request}",
                name, request);

            return Task.CompletedTask;
        }
    }
}