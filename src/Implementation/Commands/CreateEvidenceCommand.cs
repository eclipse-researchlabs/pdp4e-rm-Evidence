using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Evidence.Implementation.Commands
{
    public class CreateEvidenceCommand
    {
        public Guid? RiskRootId { get; set; }
        public Guid? TreatmentRootId { get; set; }

        public string Payload { get; set; }
    }
}
