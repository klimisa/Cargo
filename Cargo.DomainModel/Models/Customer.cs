namespace Cargo.DomainModel.Models
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
