using Rebus.Sagas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDrop.Infrastructure.Messaging.Sage;
public class DropAssignmentSagaData : SagaData
{
    public Guid RequestId { get; set; }
    public bool IsAssigned { get; set; }
    public bool IsCompleted { get; set; }
}