namespace Cargo.DomainModel.Repository
{
    public interface ICargoRepository
    {
        Models.Cargo FindByCargoTrackingId(string trackingId);
        Models.Cargo FindByCustomerId(string customerId);
    }
}