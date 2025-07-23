using Microsoft.Extensions.DependencyInjection;
using SmartDrop.Application.Interfaces;
using SmartDrop.Application.Services;
using SmartDrop.Infrastructure.Messaging.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IAssignmentService, AssignmentService>();
        services.AddRebusMessaging();
        return services;
    }
}