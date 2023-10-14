using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Sharepoint.Dao;

namespace Sharepoint.Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddSharePointService(this IServiceCollection services)
        {
            services.AddSingleton<IInformationsService, InformationService>();
            services.AddSingleton<InformationDAO, InformationDAO>();

            services.AddSingleton<IQAService, QAService>();
            services.AddSingleton<QADAO, QADAO>();

            services.AddSingleton<IEventService, EventService>();
            services.AddSingleton<EventDAO, EventDAO>();

            services.AddSingleton<IGalleryService, GalleryService>();
            services.AddSingleton<GalleryDAO, GalleryDAO>();



            return services;
        }
    }
}
