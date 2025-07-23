using SmartDrop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Domain.Entities;
public class Drop
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Description { get; set; } = string.Empty;

    public DropStatus Status { get; set; } = DropStatus.Pending;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Guid? AssignedToVehicleId { get; set; } 

    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
