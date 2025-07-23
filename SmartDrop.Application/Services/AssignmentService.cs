using SmartDrop.Application.Interfaces;
using SmartDrop.Domain.Entities;
using SmartDrop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Application.Services;
public class AssignmentService : IAssignmentService
{
    public async Task AssignPendingDropsToVehiclesAsync(IEnumerable<Drop> pendingDrops, IEnumerable<Vehicle> availableVehicles)
    {
        var drops = pendingDrops.ToList();
        var vehicles = availableVehicles.ToList();

        if (!drops.Any() || !vehicles.Any())
            return;

        int vehicleIndex = 0;

        foreach (var drop in drops)
        {
            var vehicle = vehicles[vehicleIndex];

            drop.AssignedToVehicleId = vehicle.Id;
            drop.Status = DropStatus.Assigned;

            vehicle.AssignedDrops.Add(drop);

            vehicleIndex = (vehicleIndex + 1) % vehicles.Count;
        }

        await Task.CompletedTask;
    }
}
