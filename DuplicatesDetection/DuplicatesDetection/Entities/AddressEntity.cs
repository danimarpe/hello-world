using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesDetection.Entities
{
    public class AddressEntity
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }

        public override bool Equals(object addressObject)
        {
            AddressEntity address = (AddressEntity)addressObject;

            if (this.Street.Equals(address.Street) &&
                this.City.Equals(address.City) &&
                this.State.Equals(address.State) &&
                this.Zip_Code.Equals(address.Zip_Code))
            {
                return true;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            int hash = 23 + 31 * Street.GetHashCode() + City.GetHashCode() + State.GetHashCode() + Zip_Code.GetHashCode();

            return hash / 4;
        }
    }
}
