using Cargo.DomainModel.Models;
using Cargo.DomainModel.Repository;

namespace Cargo.Repository
{
    public class LocationRepository: ILocationRepository
    {
        public Location FindByPostCode(string postCode)
        {
            throw new System.NotImplementedException();
        }

        public Location FindByCityName(string cityName)
        {
            throw new System.NotImplementedException();
        }
    }
}