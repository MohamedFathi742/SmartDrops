using Rebus.Sagas;
using SmartDrop.Infrastructure.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SmartDrop.Infrastructure.Messaging.Sage;
public class DropAssignmentSaga : Saga<DropAssignmentSagaData>, IAmInitiatedBy<DropAssignedEvent>
{
    protected override void CorrelateMessages(ICorrelationConfig<DropAssignmentSagaData> config)
    {
        config.Correlate<DropAssignedEvent>(m => m.RequestId, d => d.RequestId);
    }

    public async Task Handle(DropAssignedEvent message)
    {
       
        Console.WriteLine($"✅ Drop Assigned to Vehicle: {message.VehicleId}");

        
        Data.IsCompleted = true;

       
    }
}