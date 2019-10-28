using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Evidence.Implementation.Commands;
using Core.Evidence.Interfaces.Services;
using MediatR;

namespace Core.Evidence.Implementation.Services
{
    public class EvidenceService : IEvidenceService
    {
        private IMediator _mediator;

        public EvidenceService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Database.Tables.Evidence> Create(CreateEvidenceCommand command) => await _mediator.Send(command);
    }
}
