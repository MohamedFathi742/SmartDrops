using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Application.DTOs;
public class DropAssignmentResultDto
{
    public Guid DropId { get; set; }

    public Guid? AssignedVehicleId { get; set; }

    public string Status { get; set; } = "Pending";
}