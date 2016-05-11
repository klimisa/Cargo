namespace Cargo.DomainModel.Models
{
    public class Location
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _postCode;
        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }
    }
}
