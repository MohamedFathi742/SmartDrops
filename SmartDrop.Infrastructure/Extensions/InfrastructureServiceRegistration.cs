using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rebus.Config;
using Rebus.Routing.TypeBased;
using SmartDrop.Infrastructure.Messaging.Config;
using SmartDrop.Infrastructure.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure.Extensions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRebus(configure => configure
    .Transport(t => t.UseRabbitMq("amqp://guest:guest@localhost", "smartdrop-queue"))
    .Routing(r => r.TypeBased().Map<DropAssignedEvent>("smartdrop-queue")));
        return services;
    }
}