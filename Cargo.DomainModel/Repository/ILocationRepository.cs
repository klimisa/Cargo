using Cargo.DomainModel.Models;

namespace Cargo.DomainModel.Repository
{
    public interface ILocationRepository
    {
        Location FindByPostCode(string postCode);
        Location FindByCityName(string cityName);
    }
}