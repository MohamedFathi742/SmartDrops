using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure.Messaging.Messages;
public class DropAssignedEvent
{
    public Guid RequestId { get; set; }
    public string VehicleId { get; set; }
    public List<string> DropIds { get; set; }
}