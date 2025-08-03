using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure.Messaging.Messages;
public class DropCompletedEvent
{
    public Guid RequestId { get; set; }
}