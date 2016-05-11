using System;
using System.Collections.Generic;

namespace Cargo.DomainModel.Models
{
    public class Cargo
    {
        private string _trackingId;
        public string TrackingId
        {
            get { return _trackingId; }
        }

        //TODO: How do I implement Many-To-One relation ?
        // as a hashtable
        public Dictionary<string, Customer> _customerRoles;
        public Dictionary<string, Customer> CustomerRoles
        {
            get { return _customerRoles; }
        }

        private DeliverySpecification _goal;
        public DeliverySpecification Goal
        {
            get { return _goal; }
            set { _goal = value; }
        }

        private DeliveryHistory _deliveryHistory;
        public DeliveryHistory DeliveryHistory
        {
            get { return _deliveryHistory; }
            set { _deliveryHistory = value; }
        }
         
        public Cargo(string trackingId)
        {
            if (string.IsNullOrWhiteSpace(trackingId))
            {
                throw new ArgumentNullException("You must provide tracking id.");
            }

            _trackingId = trackingId;
            _deliveryHistory = new DeliveryHistory(this);
            _customerRoles = new Dictionary<string, Customer>();
        }
    }
}
