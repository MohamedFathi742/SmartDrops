using Microsoft.Extensions.DependencyInjection;
using Rebus.Config;
using Rebus.Routing.TypeBased;

namespace SmartDrop.Infrastructure.Messaging.Config;
public static class RebusConfiguration
{
    public static IServiceCollection AddRebusMessaging(this IServiceCollection services)
    {
        services.AddRebus(configure => configure
           .Transport(t => t.UseRabbitMq("amqp://guest:guest@localhost:5672", "smartdrop-queue"))
            .Routing(r => r.TypeBased().MapAssemblyOf<object>("smartdrop-queue"))
            //.Options(o => o.EnableSagaAuditing())
        );

        return services;
    }
}

