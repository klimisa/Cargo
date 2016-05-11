using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo.DomainModel.Repository;

namespace Cargo.Repository
{
    public class CargoRepository: ICargoRepository
    {
        public DomainModel.Models.Cargo FindByCargoTrackingId(string trackingId)
        {
            throw new NotImplementedException();
        }

        public DomainModel.Models.Cargo FindByCustomerId(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}
