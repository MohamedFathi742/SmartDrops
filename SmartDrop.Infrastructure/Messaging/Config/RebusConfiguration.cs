using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Auditing.Sagas;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure.Messaging.Config;
public static class RebusConfiguration
{
    public static IServiceCollection AddRebusMessaging(this IServiceCollection services)
    {
        services.AddRebus(configure => configure
            .Transport(t => t.UseRabbitMq("amqp://guest:guest@localhost", "smartdrop-queue"))
            .Routing(r => r.TypeBased().MapAssemblyOf<object>("smartdrop-queue"))
            .Options(o => o.EnableSagaAuditing())
        );

        return services;
    }
}

