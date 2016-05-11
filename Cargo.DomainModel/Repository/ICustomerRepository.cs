using Cargo.DomainModel.Models;

namespace Cargo.DomainModel.Repository
{
    public interface ICustomerRepository
    {
        Customer FindByCustomerId(string customerId);
        Customer FindByName(string name);
        Customer FindByCargoTrackingId(string trackingId);
    }
}