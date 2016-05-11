using Cargo.DomainModel.Models;
using Cargo.DomainModel.Repository;

namespace Cargo.Repository
{
    public class CarrierMovementRepository: ICarrierMovementRepository
    {
        public CarrierMovement FindByScheduleId(string scheduleId)
        {
            throw new System.NotImplementedException();
        }

        public CarrierMovement FindByFromTo(Location @from, Location to)
        {
            throw new System.NotImplementedException();
        }
    }
}