using System;

namespace Cargo.DomainModel.Factories
{
    public class CargoFactory
    {
        public static Models.Cargo NewCargo()
        {
            var cargo = new Models.Cargo(Guid.NewGuid().ToString());
            return cargo;
        }

        public static Models.Cargo NewCargo(Models.Cargo prototype)
        {
            var cargo = new Models.Cargo(Guid.NewGuid().ToString());
            return cargo;
        }
    }
}