using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo.DomainModel
{
    public class Customer
    {
        private int _customerId;
        private string _name;
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
