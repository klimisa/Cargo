using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cargo.DomainModel
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
