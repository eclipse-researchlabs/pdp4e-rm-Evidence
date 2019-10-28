using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Core.Evidence.Implementation.Commands
{
    public class CreateEvidenceCommand : Core.Database.Tables.Evidence, IRequest<Core.Database.Tables.Evidence>
    {
        public Guid? RiskRootId { get; set; }
        public Guid? TreatmentRootId { get; set; }

        public object PayloadObject { get; set; }
    }
}
