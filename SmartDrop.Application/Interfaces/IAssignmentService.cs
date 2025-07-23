using SmartDrop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Application.Interfaces;

public interface IAssignmentService
{
    Task AssignPendingDropsToVehiclesAsync(IEnumerable<Drop> pendingDrops, IEnumerable<Vehicle> availableVehicles);
}