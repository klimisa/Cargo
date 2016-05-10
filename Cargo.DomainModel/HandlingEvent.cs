using System;

namespace Cargo.DomainModel
{
    public class HandlingEvent
    {
        private DateTime _completionTime;

        public DateTime CompletionTime
        {
            get { return _completionTime; }
            set { _completionTime = value; }
        }

        //TODO: Maybe an Enumerator; 
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
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

        private Cargo _handledCargo;
        public Cargo HandledCargo
        {
            get { return _handledCargo; }
            set { _handledCargo = value; }
        }

    }
}