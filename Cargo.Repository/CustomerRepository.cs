using Cargo.DomainModel.Models;
using Cargo.DomainModel.Repository;

namespace Cargo.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        public Customer FindByCustomerId(string customerId)
        {
            throw new System.NotImplementedException();
        }

        public Customer FindByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Customer FindByCargoTrackingId(string trackingId)
        {
            throw new System.NotImplementedException();
        }
    }
}