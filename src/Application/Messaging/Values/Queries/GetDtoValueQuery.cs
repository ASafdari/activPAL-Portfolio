using MediatR;
using Portfolio.Application.Messaging.Values.Queries.Models;

namespace Portfolio.Application.Messaging.Values.Queries
{
    public class GetDtoValueQuery : IRequest<DtoValue>
    {
        public int Id { get; }

        public GetDtoValueQuery(int id)
        {
            Id = id;
        }
    }
}