using System.Collections.Generic;

namespace Cargo.DomainModel.Models
{
    public class DeliveryHistory
    {
        private Models.Cargo _cargo;
        public Models.Cargo Cargo
        {
            get { return _cargo; }
        }

        private List<HandlingEvent> _handlingEvents;

        public List<HandlingEvent> HandlingEvents
        {
            get { return _handlingEvents; } 
        }

        public DeliveryHistory(Cargo cargo)
        {
            _cargo = cargo;
            _handlingEvents = new List<HandlingEvent>();
        }
    }
}