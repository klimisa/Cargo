using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo.DomainModel
{
    public class Cargo
    {
        private int _trackingId;
        public int TrackingId
        {
            get { return _trackingId; }
            set { _trackingId = value; }
        }

        public Dictionary<string, Customer> Customers;

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

        public List<HandlingEvent> Handled;
         
        public Cargo()
        {
            Customers = new Dictionary<string, Customer>();
        }
    }
}
