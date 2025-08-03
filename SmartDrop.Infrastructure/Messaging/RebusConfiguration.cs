using Microsoft.Extensions.DependencyInjection;
using Rebus.Config;
using Rebus.Persistence.InMem;
using Rebus.Routing.TypeBased;
using SmartDrop.Infrastructure.Messaging.Messages;
namespace SmartDrop.Infrastructure.Messaging;

public static class RebusConfiguration
{
    public static IServiceCollection AddRebusMessaging(this IServiceCollection services)
    {
        services.AddRebus(configure => configure
            .Transport(t => t.UseRabbitMq("amqp://guest:guest@localhost", "smartdrop-queue"))
            .Routing(r => r.TypeBased().Map<DropAssignedEvent>("smartdrop-queue"))
            .Sagas(s => s.StoreInMemory()) 
            .Options(o =>
            {
                o.SetNumberOfWorkers(1);
                o.SetMaxParallelism(1);
            }));

        return services;
    }
}