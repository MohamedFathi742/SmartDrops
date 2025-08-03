using Rebus.Handlers;
using Rebus.Sagas;
using SmartDrop.Infrastructure.Messaging.Messages;

namespace SmartDrop.Infrastructure.Messaging.Sage;
public class DropAssignmentSaga : Saga<DropAssignmentSagaData>,
    IAmInitiatedBy<DropAssignedEvent>,
    IHandleMessages<DropAssignedEvent>
{
    protected override void CorrelateMessages(ICorrelationConfig<DropAssignmentSagaData> config)
    {
        config.Correlate<DropCompletedEvent>(m => m.RequestId, d => d.RequestId);
        config.Correlate<DropCompletedEvent>(m => m.RequestId, d => d.RequestId);
    }

    public async Task Handle(DropAssignedEvent message)
    {
        Console.WriteLine($"Drop Assigned to Vehicle: {message.VehicleId}");
        Data.IsCompleted = false;
    }

    public async Task Handle(DropCompletedEvent message)
    {
        Console.WriteLine($"Drop Completed for Request: {message.RequestId}");
        Data.IsCompleted = true;
        MarkAsComplete(); 
    }
}