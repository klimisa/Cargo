using System;
using System.Data;

namespace Cargo.DomainModel.Models
{
    public class HandlingEvent
    {
        private static string LOADING_EVENT = "LOAD";

        public string EventId
        {
            get
            {
                return string.Format("{0}-{1}-{2}", _cargo.TrackingId, _type, _completionTime.ToString("yyyyMMddhhmmss"));
            }
        }

        private DateTime _completionTime;

        public DateTime CompletionTime
        {
            get { return _completionTime; }
        }

        //TODO: Maybe an Enumerator; 
        private string _type;
        public string Type
        {
            get { return _type; }
        }

        private CarrierMovement _carrierMovement;

        //TODO: How are we implementing 0..1 associations
        // I could a NoCarrierMovement but it's not expressing
        // the 0..1 so well. I think.
        //TODO: What about other types that don't have a carrier movement. It should have a constraint to limit it.
        public CarrierMovement CarrierMovement
        {
            get { return _carrierMovement; }
            set { _carrierMovement = value; }
        }

        private Models.Cargo _cargo;
        public Models.Cargo Cargo
        {
            get { return _cargo; }
        }


        //TODO: I should make the constructor internal
        public HandlingEvent(Cargo cargo,string type, DateTime completionTime)
        {
            if (cargo == null)
            {
                throw new ArgumentNullException("Cargo must be provided!");
            }

            //TODO: Type must be one a the known type else exception
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentNullException("Type must be provided!");
            }

            if (completionTime > DateTime.Now)
            {
                throw new ArgumentOutOfRangeException("Completion must not be in the future!");
            }

            _cargo = cargo;
            _type = type;
            _completionTime = completionTime;
        }

        public static HandlingEvent NewLoading(Cargo cargo, CarrierMovement loadedOnto, DateTime completionTime)
        {
            var handlingEvent = new HandlingEvent(cargo, LOADING_EVENT, DateTime.Now.AddMinutes(-1))
            {
                CarrierMovement = loadedOnto
            };
            return handlingEvent;
        }
    }
}