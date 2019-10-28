using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Evidence.Implementation.Commands;

namespace Core.Evidence.Interfaces.Services
{
    public interface IEvidenceService
    {
        Task<Database.Tables.Evidence> Create(CreateEvidenceCommand command);
    }
}
