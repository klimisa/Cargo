using Cargo.DomainModel.Models;

namespace Cargo.DomainModel.Repository
{
    public interface ICarrierMovementRepository
    {
        CarrierMovement FindByScheduleId(string scheduleId);

        CarrierMovement FindByFromTo(Location from, Location to);
    }
}