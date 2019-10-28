using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Core.Database;
using Core.Evidence.Implementation.Commands;
using MediatR;

namespace Core.Evidence.Implementation.CommandHandlers
{
    public class CreateEvidenceCommandHandler : IRequestHandler<CreateEvidenceCommand, Core.Database.Tables.Evidence>
    {
        private IMapper _mapper;
        private IBeawreContext _beawreContext;

        public CreateEvidenceCommandHandler(IBeawreContext beawreContext, IMapper mapper)
        {
            _beawreContext = beawreContext;
            _mapper = mapper;
        }

        public Task<Database.Tables.Evidence> Handle(CreateEvidenceCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Database.Tables.Evidence>(request);
            _beawreContext.Evidence.Add(entity);
            _beawreContext.SaveChanges();
            return Task.FromResult(entity);
        }
    }
}
