using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Portfolio.Application.Common.Exceptions;
using Portfolio.Application.Common.Interfaces;
using Portfolio.Application.Messaging.Values.Queries.Models;
using Portfolio.Domain.Entities;

namespace Portfolio.Application.Messaging.Values.Queries.Handlers
{
    public class GetDtoValueQueryHandler : IRequestHandler<GetDtoValueQuery, DtoValue>
    {
        private IPortfolioDbContext _context;
        private IMapper _mapper;

        public GetDtoValueQueryHandler(IPortfolioDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DtoValue> Handle(GetDtoValueQuery request, CancellationToken cancellationToken)
        {
            //var entity = await _context.Values.FindAsync(request.Id);
            var entity = new Value {Birtday = DateTime.Now, Id = 1, MyValue = "Hooray"};

            if (entity == null)
                throw new NotFoundException(nameof(Value), request.Id);

            return _mapper.Map<DtoValue>(entity);
        }
    }
}