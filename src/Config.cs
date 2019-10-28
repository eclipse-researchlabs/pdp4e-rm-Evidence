using System;
using System.ComponentModel;
using AutoMapper;
using Core.Evidence.Implementation.Commands;
using Core.Evidence.Implementation.Services;
using Core.Evidence.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Evidence
{
    public class Config
    {
        public static void InitializeServices(ref IServiceCollection services)
        {
            // Services
            services.AddScoped<IEvidenceService, EvidenceService>();

            // Queries
        }
    }

    public class ContainersProProfile : Profile
    {
        public ContainersProProfile()
        {
            CreateMap<CreateEvidenceCommand, Database.Tables.Evidence>()
                .ForMember(x => x.Payload, src => src.MapFrom(x => x.PayloadObject.ToString()))
                ;

        }
    }
}
